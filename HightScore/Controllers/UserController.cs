using HightScore.Entities.Model.Concrete;
using HightScore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HightScore.Controllers
{
    public class UserController : Controller
    {
        private UserManager<MetaUser> _userManager;
        private RoleManager<Role> _roleManager;
        public UserController(UserManager<MetaUser> userManager,
            RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }


        public IActionResult Users()
        {

            return View(_userManager.Users);
        }

        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
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
                return RedirectToAction("Index", "Home");
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

            return RedirectToAction("Index", "Home");
        }




    }
}
