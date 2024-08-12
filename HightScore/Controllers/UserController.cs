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


        public async Task<IActionResult> Users(IEnumerable<string> selectedRoles = null)
        {
            // Rolleri al
            var roles = await _roleManager.Roles.ToListAsync();
            var roleNames = roles.Select(r => r.Name).ToList();

            // Kullanıcıları filtrele
            IQueryable<MetaUser> usersQuery = _userManager.Users;

            if (selectedRoles != null && selectedRoles.Any())
            {
                // Seçilen rollere göre kullanıcıları filtrele
                var allUsersInRoles = new List<MetaUser>();

                foreach (var roleName in selectedRoles)
                {
                    var usersInRole = await _userManager.GetUsersInRoleAsync(roleName);
                    allUsersInRoles.AddRange(usersInRole);
                }

                // Kullanıcıları birleştir ve benzersiz hale getir
                var distinctUsers = allUsersInRoles.Distinct();
                usersQuery = usersQuery.Where(user => distinctUsers.Contains(user));
            }

            var users = await usersQuery.ToListAsync();

            // Kullanıcı rollerini al
            var userRoles = new Dictionary<string, List<string>>();
            foreach (var user in users)
            {
                var rolesForUser = await _userManager.GetRolesAsync(user);
                userRoles[user.Id] = rolesForUser.ToList();
            }

            var model = new UserListViewModel
            {
                Users = users,
                Roles = roles,
                SelectedRoles = selectedRoles,
                UserRoles = userRoles
            };

            return View(model);
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


        [HttpPost]
        public async Task<IActionResult> Ban(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                // Kullanıcının hesabını kilitle (banla)
                var lockoutEndDate = DateTimeOffset.MaxValue; // Hesabı süresiz kilitle
                await _userManager.SetLockoutEndDateAsync(user, lockoutEndDate);
                await _userManager.SetLockoutEnabledAsync(user, true);
            }

            return RedirectToAction("Users");
        }

        [HttpPost]
        public async Task<IActionResult> Unban(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                await _userManager.SetLockoutEnabledAsync(user, false);
                await _userManager.SetLockoutEndDateAsync(user, null);
            }

            return RedirectToAction("Users");
        }



    }
}
