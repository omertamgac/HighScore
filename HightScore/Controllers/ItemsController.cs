using HightScore.BL.Managers.Abstract;
using HightScore.Entities.DbContexts;
using HightScore.Entities.Model.Concrete;
using HightScore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace HightScore.Controllers
{
    public class ItemsController : Controller
    {
        private readonly IitemManager _itemManager;
        private readonly ICategoryManager _categoryManager;
        private readonly IPlatformManager _platformManager;
        private readonly IitemPlatformManager _itemPlatformManager;
        private readonly IitemCategoryManager _itemCategoryManager;
        private readonly IUserReviewManager _userReviewManager;
        private readonly AppDbContext _context;

        public ItemsController(
            IitemManager itemManager,
            ICategoryManager categoryManager,
            IPlatformManager platformManager,
            IitemPlatformManager itemPlatformManager,
            IitemCategoryManager itemCategoryManager,
            IUserReviewManager userReviewManager,
            AppDbContext context
        )
        {
            _itemManager = itemManager;
            _categoryManager = categoryManager;
            _platformManager = platformManager;
            _itemPlatformManager = itemPlatformManager;
            _itemCategoryManager = itemCategoryManager;
            _userReviewManager = userReviewManager;
            _context = context;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult CreateGame()
        {
            ViewBag.Categories = _categoryManager.GetAll();
            ViewBag.Platforms = _platformManager.GetAll();
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateGame(GameVM model, List<int> Categories, List<int> Platforms, IFormFile photo)
        {
            if (ModelState.IsValid)
            {
                string photoFileName = null;

                if (photo != null && photo.Length > 0)
                {
                    photoFileName = Guid.NewGuid().ToString() + Path.GetExtension(photo.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", photoFileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await photo.CopyToAsync(stream);
                    }
                }

                var game = new Item
                {
                    Title = model.Title,
                    Description = model.Description,
                    RelaseDate = model.RelaseDate,
                    Iframe = model.Iframe,
                    photo = photoFileName,
                    ItemCategories = Categories.Select(c => new ItemCategory { categoryId = c }).ToList(),
                    ItemPlatforms = Platforms.Select(p => new ItemPlatform { platformId = p }).ToList(),
                };

                var result = _itemManager.Insert(game);

                if (result > 0)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while adding the game.");
                }
            }

            ViewBag.Categories = _categoryManager.GetAll();
            ViewBag.Platforms = _platformManager.GetAll();
            return View(model);
        }



        public async Task<IActionResult> Details(int id, int pageNumber = 1, int pageSize = 5)
        {
            var game = await _itemManager.GetGameByIdAsync(id);
            var categories = await _itemCategoryManager.GetByIdAsync(id);
            var platforms = await _itemPlatformManager.GetByIdAsync(id);
            var userReviews = await _userReviewManager.GetReviewsByItemIdAsync(id) ?? new List<UserReview>();

            if (game == null)
            {
                return NotFound();
            }

            double averageRating = await _itemManager.GetAverageRatingAsync(id);

            int totalReviews = userReviews.Count();
            int totalPages = (int)Math.Ceiling(totalReviews / (double)pageSize);

            var paginatedReviews = userReviews
                                    .Skip((pageNumber - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToList();

            var viewModel = new GameVM
            {
                Title = game.Title,
                Description = game.Description,
                RelaseDate = game.RelaseDate,
                Iframe = game.Iframe,
                photo = game.photo,
                Categories = categories.Select(c => c.category.CategoryName).ToList(),
                Platforms = platforms.Select(p => p.platform.PlatformName).ToList(),
                UserReviews = paginatedReviews,
                AverageRating = averageRating,
                ItemId = id,
                CurrentPage = pageNumber,
                TotalPages = totalPages
            };

            return View(viewModel);
        }






        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> GameDelete(int id)
        {
            var game = await _itemManager.FindByIdAsync(id);

            if (game != null)
            {
                await _itemManager.DeleteAsync(game);
            }

            return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditGame(int id)
        {
            var game = await _itemManager.FindByIdAsync(id);
            var gameCategories = await _itemCategoryManager.GetByIdAsync(id);
            var gamePlatforms = await _itemPlatformManager.GetByIdAsync(id);

            if (game == null)
            {
                return NotFound();
            }

            ViewBag.Categories = await _categoryManager.GetAllAsync();
            ViewBag.Platforms = await _platformManager.GetAllAsync();

            var model = new GameEditVM
            {
                Id = id,
                Description = game.Description,
                Iframe = game.Iframe,
                RelaseDate = game.RelaseDate,
                Title = game.Title,
                ExistingPhoto = game.photo,
                SelectedCategories = gameCategories.Select(c => c.categoryId).ToList(),
                SelectedPlatforms = gamePlatforms.Select(p => p.platformId).ToList()
            };

            return View(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> EditGame(GameEditVM model, IFormFile? photo)
        {
            if (ModelState.IsValid)
            {
                var game = await _itemManager.FindByIdAsync(model.Id);
                if (game != null)
                {
                    game.Title = model.Title;
                    game.Description = model.Description;
                    game.RelaseDate = model.RelaseDate;
                    game.Iframe = model.Iframe;

                    if (photo != null && photo.Length > 0)
                    {
                        string photoFileName = Guid.NewGuid().ToString() + Path.GetExtension(photo.FileName);
                        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", photoFileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await photo.CopyToAsync(stream);
                        }

                        game.photo = photoFileName;
                    }
                    else
                    {
                        game.photo = model.ExistingPhoto;
                    }

                    await _itemCategoryManager.RemoveByItemIdAsync(game.Id);
                    await _itemPlatformManager.RemoveByItemIdAsync(game.Id);

                    if (model.SelectedCategories != null)
                    {
                        var newCategories = model.SelectedCategories.Select(c => new ItemCategory { itemId = game.Id, categoryId = c }).ToList();
                        foreach (var itemCategory in newCategories)
                        {
                            await _itemCategoryManager.AddAsync(itemCategory);
                        }
                    }

                    if (model.SelectedPlatforms != null)
                    {
                        var newPlatforms = model.SelectedPlatforms.Select(p => new ItemPlatform { itemId = game.Id, platformId = p }).ToList();
                        foreach (var itemPlatform in newPlatforms)
                        {
                            await _itemPlatformManager.AddAsync(itemPlatform);
                        }
                    }

                    var result = _itemManager.Update(game);

                    if (result > 0)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "An error occurred while updating the game.");
                    }
                }
            }

            ViewBag.Categories = await _categoryManager.GetAllAsync();
            ViewBag.Platforms = await _platformManager.GetAllAsync();
            return View(model);
        }

        [Authorize(Roles = "User")]
        public async Task<IActionResult> CreateComment(int itemId, int rating, string comment)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var result = await _userReviewManager.CreateComment(itemId, userId, rating, comment);

            if (result)
            {
                return RedirectToAction("Details", new { id = itemId });
            }
            else
            {
                ModelState.AddModelError(string.Empty, "You have already submitted a review for this item.");
                return RedirectToAction("Details", new { id = itemId });
            }
        }

        [Authorize(Roles = "Admin, User")]
        [HttpPost]
        public async Task<IActionResult> DeleteReview(int itemId, string userId)
        {
            var review = await _context.UserReviews.FindAsync(itemId, userId);

            if (review == null)
            {
                return NotFound();
            }

            _context.UserReviews.Remove(review);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", new { id = itemId });
        }

        [HttpPost]
        public async Task<IActionResult> EditReview([FromBody] EditReviewVM model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var review = await _context.UserReviews
                           .FirstOrDefaultAsync(r => r.ItemId.ToString() == model.ItemId && r.UserId == userId);

            if (review == null)
            {
                return Json(new { success = false, message = "Review not found." });
            }

            // Kullanıcı ya da admin kontrolü yapılır
            if (review.UserId == userId)
            {
                review.UserRating = model.UserRating;
                review.Comment = model.Comment;

                _context.UserReviews.Update(review);
                await _context.SaveChangesAsync();

                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false, message = "Unauthorized." });
            }
        }

    }
}
