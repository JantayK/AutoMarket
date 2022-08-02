using AutoMarket.BLL.Services;
using AutoMarket.DAL.Data;
using AutoMarket.DAL.Models;
using AutoMarket.WEB.ViewModels.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AutoMarket.WEB.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IUserService _userService;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager,
            UserService userService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User()
                {
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    FirstName = model.FirstName,
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    await _userManager.AddToRoleAsync(user, "user");
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
                return View(model);
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            var model = new UserLoginViewModel()
            {
                ReturnUrl = returnUrl
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager
                    .PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrWhiteSpace(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return View(model.ReturnUrl);
                    }
                    return View(model);
                }
            }
            else
            {
                ModelState.AddModelError("", "Неправильный логин и(или) Пароль.");
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [AcceptVerbs("Get", "Post")]
        public async Task<IActionResult> CheckEmail(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
                return Json(false);
            return Json(true);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit()
        {
            var user = await _userManager.FindByIdAsync(User
                .FindFirstValue(ClaimTypes.NameIdentifier));
            if (user == null)
            {
                return NotFound();
            }

            var model = new UserEditViewModel()
            {
                Email = user.Email,
                FirstName = user.FirstName,
                PhoneNumber = user.PhoneNumber
            };
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit(UserEditViewModel model)
        {
            if(ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(User
                    .FindFirstValue(ClaimTypes.NameIdentifier));

                if(user != null)
                {
                    user.Email = model.Email;
                    user.PhoneNumber = model.PhoneNumber;
                    user.FirstName = model.FirstName;

                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                }
                ModelState.AddModelError("", "User was not found");
            }
            return View(model);
        }

        [HttpGet]
        [Authorize]
        public IActionResult ChangePassword()
        {
            var model = new UserChangePasswordViewModel()
            {
                Id = User.FindFirstValue(ClaimTypes.NameIdentifier)
            };

            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> ChangePassword(UserChangePasswordViewModel model)
        {
            if(ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.Id);
                if(user == null)
                {
                    return NotFound();
                }

                var result = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }
    }
}
