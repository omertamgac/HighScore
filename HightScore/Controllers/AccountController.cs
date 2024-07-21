using HightScore.Entities.Model.Concrete;
using HightScore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HightScore.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<MetaUser> _userManager;
        private RoleManager<Role> _roleManager;
        private SignInManager<MetaUser> _signInManager;
        private IEmailSender _emailSender;
        public AccountController(UserManager<MetaUser> userManager, RoleManager<Role> roleManager,
            SignInManager<MetaUser> signInManager, IEmailSender emailSender)
        {

            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    await _signInManager.SignOutAsync();
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, true);

                    if (!await _userManager.IsEmailConfirmedAsync(user))
                    {
                        ModelState.AddModelError("", "Please confirm your account");
                        return View(model);
                    }


                    if (result.Succeeded)
                    {
                        await _userManager.ResetAccessFailedCountAsync(user);
                        await _userManager.SetLockoutEndDateAsync(user, null);

                        return RedirectToAction("Index", "Home");
                    }

                    else if (result.IsLockedOut)
                    {
                        var lockoutDate = await _userManager.GetLockoutEndDateAsync(user);
                        var timeLeft = lockoutDate.Value - DateTime.UtcNow;
                        ModelState.AddModelError("", $"Your account is locked, Please try again  {timeLeft.Minutes} minute later ");
                    }
                    else
                    {
                        ModelState.AddModelError("", "E-mail or password is wrong");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "No account found for this email address");
                }
            }
            return View(model);
        }



        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new MetaUser { UserName = model.UserName, Email = model.Email };
                IdentityResult result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var url = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token = token }, protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(user.Email, "Account Verify", $"Please <a href='{url}'>click here</a> to confirm your account.");

                    TempData["message"] = "Please click on the confirmation link in your email.";
                    return RedirectToAction("Login", "Account");
                }


                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View();
        }



        public async Task<IActionResult> ConfirmEmail(string Id, string token)
        {

            if (Id == null || token == null)
            {
                TempData["message"] = "Token is invalid";
                return View();
            }


            var user = await _userManager.FindByIdAsync(Id);

            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);

                if (result.Succeeded)
                {
                    TempData["message"] = "Your Account Has Been Verified";
                    return View();
                }
            }

            TempData["message"] = "Account has not found";
            return View();

        }


        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }





}
