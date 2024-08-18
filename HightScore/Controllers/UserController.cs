using HighScore.Entities.DbContexts;
using HighScore.Entities.Model.Concrete;
using HighScore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HighScore.Controllers
{
    public class UserController : Controller
    {
        private UserManager<MetaUser> _userManager;
        private RoleManager<Role> _roleManager;
        private readonly AppDbContext _context;
        public UserController(UserManager<MetaUser> userManager,
            RoleManager<Role> roleManager, AppDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }


        public IActionResult Users(string selectedRole, int pageNumber = 1)
        {
            int pageSize = 10;

            var usersQuery = _userManager.Users.AsQueryable();

            if (!string.IsNullOrEmpty(selectedRole))
            {
                var roleIds = _context.Roles
                    .Where(r => r.Name == selectedRole)
                    .Select(r => r.Id)
                    .ToList();

                var userIds = _context.UserRoles
                    .Where(ur => roleIds.Contains(ur.RoleId))
                    .Select(ur => ur.UserId)
                    .ToList();

                usersQuery = usersQuery.Where(u => userIds.Contains(u.Id));
            }

            var users = usersQuery
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var userRoles = new Dictionary<string, List<string>>();
            foreach (var user in users)
            {
                var roles = _userManager.GetRolesAsync(user).Result;
                userRoles[user.Id] = roles.ToList();
            }

            var totalUsers = usersQuery.Count();

            var model = new UserListViewModel
            {
                Users = users,
                UserRoles = userRoles,
                Roles = _context.Roles.ToList(),
                SelectedRoles = new List<string> { selectedRole },
            };

            ViewBag.TotalPages = (int)Math.Ceiling(totalUsers / (double)pageSize);
            ViewBag.CurrentPage = pageNumber;

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
                var lockoutEndDate = DateTimeOffset.MaxValue;
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
