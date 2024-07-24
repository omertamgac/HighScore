using HightScore.BL.Managers.Abstract;
using HightScore.Entities.Model.Concrete;
using HightScore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace HightScore.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private UserManager<MetaUser> _userManager;
        private RoleManager<Role> _roleManager;
        private readonly IitemManager _itemManager;
        private readonly ICategoryManager _categoryManager;
        private readonly IPlatformManager _platformManager;
        private readonly IitemPlatformManager _itemPlatformManager;
        private readonly IitemCategoryManager _itemCategoryManager;

        public HomeController(ILogger<HomeController> logger, UserManager<MetaUser> userManager,
            RoleManager<Role> roleManager, IitemManager itemManager, ICategoryManager categoryManager,
            IPlatformManager platformManager, IitemPlatformManager itemPlatformManager, IitemCategoryManager _itemcategoryManager)
        {
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _itemManager = itemManager;
            _categoryManager = categoryManager;
            _platformManager = platformManager;
            _itemPlatformManager = itemPlatformManager;
            _itemCategoryManager = _itemcategoryManager;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var items = await _itemManager.GetAllGamesAsync();
            var games = items.Select(item => new CardVM
            {
                Id = item.Id,
                photo = item.photo,
                name = item.Title,
                Score = item.MediaAverageRating
            }).ToList();

            return View(games);
        }



        public IActionResult Users()
        {

            return View(_userManager.Users);
        }

        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                ViewBag.Roles = await _roleManager.Roles.Select(i => i.Name).ToListAsync();

                return View(new EditVM
                {
                    Id = user.Id,
                    Email = user.Email,
                    UserName = user.UserName,
                    Password = user.PasswordHash,
                    ConfirmPassword = user.PasswordHash,
                    Phone = user.PhoneNumber,
                    SelectedRoles = await _userManager.GetRolesAsync(user),
                });
            }
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Edit(string id, EditVM model)
        {

            if (id != model.Id)
            {
                return RedirectToAction("Index");
            }

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.Id);
                if (user != null)
                {
                    user.Email = model.Email;
                    user.UserName = model.UserName;
                    user.PhoneNumber = model.Phone;


                    var result = await _userManager.UpdateAsync(user);


                    if (result.Succeeded && !string.IsNullOrEmpty(model.Password))
                    {
                        await _userManager.RemovePasswordAsync(user);
                        await _userManager.AddPasswordAsync(user, model.Password);
                    }


                    if (result.Succeeded)
                    {
                        await _userManager.RemoveFromRolesAsync(user, await _userManager.GetRolesAsync(user));
                        if (model.SelectedRoles != null)
                        {
                            await _userManager.AddToRolesAsync(user, model.SelectedRoles);
                        }

                        return RedirectToAction("Users");
                    }

                    foreach (var err in result.Errors)
                    {
                        ModelState.AddModelError("", err.Description);
                    }
                }
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                await _userManager.DeleteAsync(user);
            }

            return RedirectToAction("Index");
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
                    return RedirectToAction("Index");
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



    }
}
