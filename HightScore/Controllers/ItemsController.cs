using HightScore.BL.Managers.Abstract;
using HightScore.Entities.Model.Concrete;
using HightScore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HightScore.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ItemsController : Controller
    {
        private readonly IitemManager _itemManager;
        private readonly ICategoryManager _categoryManager;
        private readonly IPlatformManager _platformManager;
        private readonly IitemPlatformManager _itemPlatformManager;
        private readonly IitemCategoryManager _itemCategoryManager;
        public ItemsController(IitemManager itemManager,
        ICategoryManager categoryManager,
        IPlatformManager platformManager,
        IitemPlatformManager itemPlatformManager,
        IitemCategoryManager itemCategoryManager
        )
        {
            _itemManager = itemManager;
            _categoryManager = categoryManager;
            _platformManager = platformManager;
            _itemPlatformManager = itemPlatformManager;
            _itemCategoryManager = itemCategoryManager;
        }


        [HttpGet]
        public IActionResult CreateGame()
        {
            ViewBag.Categories = _categoryManager.GetAll();
            ViewBag.Platforms = _platformManager.GetAll();
            return View();
        }

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
                    UserAverageRating = model.UserAverageRating,
                    MediaAverageRating = model.MediaAverageRating,
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



        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var game = await _itemManager.GetGameByIdAsync(id);
            var categories = await _itemCategoryManager.GetByIdAsync(id);
            var platforms = await _itemPlatformManager.GetByIdAsync(id);

            if (game == null)
            {
                return NotFound();
            }

            var viewModel = new GameVM
            {
                Title = game.Title,
                Description = game.Description,
                RelaseDate = game.RelaseDate,
                Iframe = game.Iframe,
                photo = game.photo,
                UserAverageRating = game.UserAverageRating,
                MediaAverageRating = game.MediaAverageRating,
                Categories = categories.Select(c => c.category.CategoryName).ToList(),
                Platforms = platforms.Select(p => p.platform.PlatformName).ToList(),
            };

            return View(viewModel);
        }

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


        [HttpPost]
        public async Task<IActionResult> EditGame(int id, GameEditVM model, List<int> SelectedCategories, List<int> SelectedPlatforms, IFormFile photo)
        {
            try
            {
                if (id != model.Id)
                {
                    return BadRequest();
                }

                if (ModelState.IsValid)
                {
                    Item game = await _itemManager.GetGameByIdAsync(id); // Ensure to include related entities
                    if (game == null)
                    {
                        return NotFound();
                    }

                    string photoFileName = game.photo;
                    if (photo != null && photo.Length > 0)
                    {
                        if (!string.IsNullOrEmpty(photoFileName))
                        {
                            var oldFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", photoFileName);
                            if (System.IO.File.Exists(oldFilePath))
                            {
                                System.IO.File.Delete(oldFilePath);
                            }
                        }

                        photoFileName = Guid.NewGuid().ToString() + Path.GetExtension(photo.FileName);
                        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", photoFileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await photo.CopyToAsync(stream);
                        }
                    }

                    game.Title = model.Title;
                    game.Description = model.Description;
                    game.RelaseDate = model.RelaseDate;
                    game.Iframe = model.Iframe;
                    game.photo = photoFileName;
                    game.UserAverageRating = model.UserAverageRating;
                    game.MediaAverageRating = model.MediaAverageRating;

                    // Update ItemCategories
                    var existingCategories = game.ItemCategories.Select(c => c.categoryId).ToList();
                    var categoriesToRemove = existingCategories.Except(SelectedCategories).ToList();
                    var categoriesToAdd = SelectedCategories.Except(existingCategories).ToList();

                    foreach (var categoryId in categoriesToRemove)
                    {
                        var categoryToRemove = game.ItemCategories.FirstOrDefault(c => c.categoryId == categoryId);
                        if (categoryToRemove != null)
                        {
                            game.ItemCategories.Remove(categoryToRemove);
                        }
                    }

                    foreach (var categoryId in categoriesToAdd)
                    {
                        game.ItemCategories.Add(new ItemCategory { categoryId = categoryId });
                    }

                    // Update ItemPlatforms
                    var existingPlatforms = game.ItemPlatforms.Select(p => p.platformId).ToList();
                    var platformsToRemove = existingPlatforms.Except(SelectedPlatforms).ToList();
                    var platformsToAdd = SelectedPlatforms.Except(existingPlatforms).ToList();

                    foreach (var platformId in platformsToRemove)
                    {
                        var platformToRemove = game.ItemPlatforms.FirstOrDefault(p => p.platformId == platformId);
                        if (platformToRemove != null)
                        {
                            game.ItemPlatforms.Remove(platformToRemove);
                        }
                    }

                    foreach (var platformId in platformsToAdd)
                    {
                        game.ItemPlatforms.Add(new ItemPlatform { platformId = platformId });
                    }

                    var result = await _itemManager.UpdateAsync(game);

                    if (result > 0)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "An error occurred while updating the game.");
                    }
                }
                else
                {
                    foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                    {
                        Console.WriteLine(error.ErrorMessage);
                    }
                }

                ViewBag.Categories = await _categoryManager.GetAllAsync();
                ViewBag.Platforms = await _platformManager.GetAllAsync();
                return View(model);
            }
            catch (Exception ex)
            {
                // Hata detaylarını logla
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return StatusCode(500, "Internal server error");
            }
        }




    }
}
