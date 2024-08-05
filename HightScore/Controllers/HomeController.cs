using HightScore.BL.Managers.Abstract;
using HightScore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using X.PagedList.Extensions;
namespace HightScore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IitemManager _itemManager;
        private readonly ICategoryManager _categoryManager;
        private readonly IPlatformManager _platformManager;
        public HomeController(
            ILogger<HomeController> logger,
            IitemManager itemManager,
            ICategoryManager categoryManager,
            IPlatformManager platformManager
            )
        {
            _logger = logger;
            _itemManager = itemManager;
            _categoryManager = categoryManager;
            _platformManager = platformManager;
        }


        public async Task<IActionResult> Index(string searchQuery, int page = 1)
        {
            var items = await _itemManager.GetAllGamesAsync();
            var games = items.Select(item => new CardVM
            {
                Id = item.Id,
                photo = item.photo,
                name = item.Title,
                Score = 9
            }).ToList();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                games = games.Where(g => g.name.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            var pagedGames = games.OrderByDescending(game => game.Id).ToPagedList(page, 9);

            return View(pagedGames);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
