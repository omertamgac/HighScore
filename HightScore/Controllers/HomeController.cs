using HightScore.BL.Managers.Abstract;
using HightScore.Entities.Model.Concrete;
using HightScore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using X.PagedList;
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
            IQueryable<Item> query = _itemManager.GetAllGamesQuery();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                query = query.Where(g => g.Title.Contains(searchQuery, StringComparison.OrdinalIgnoreCase));
            }

            var items = await query
                .OrderByDescending(game => game.Id)
                .Skip((page - 1) * 9)
                .Take(9)
                .ToListAsync();

            var games = items.Select(item => new CardVM
            {
                Id = item.Id,
                photo = item.photo,
                name = item.Title,
                AverageRating = _itemManager.GetAverageRatingAsync(item.Id).Result
            }).ToList();

            var pagedGames = new StaticPagedList<CardVM>(games, page, 9, query.Count());

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
