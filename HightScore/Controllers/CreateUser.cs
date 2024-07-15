using HightScore.Entities.Model.Concrete;
using HightScore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HightScore.Controllers
{
    public class CreateUser : Controller
    {
        private UserManager<MetaUser> _userManager;
        public CreateUser(UserManager<MetaUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new MetaUser { UserName = model.UserName, Email = model.Email };
                IdentityResult result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "CreateUser");
                }

                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View();
        }
    }
}
