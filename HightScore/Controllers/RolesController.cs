using HightScore.Entities.Model.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HightScore.Controllers
{
    public class RolesController : Controller
    {

        private readonly RoleManager<Role> _roleManager;

        public RolesController(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }


        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Role model)
        {
            if (ModelState.IsValid)
            {

                var result = await _roleManager.CreateAsync(model);
                if (result.Succeeded)
                {
                    return RedirectToAction("Create");
                }

                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                }
            }
            return View(model);
        }


    }
}
