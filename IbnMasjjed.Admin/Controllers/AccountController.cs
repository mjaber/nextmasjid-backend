using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IbnMasjjed.Admin.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        public AccountController()
        {
            
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([FromForm] Models.LoginModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                return View(loginModel);
            }

            if(!(loginModel.Username == "admin" && loginModel.Password == "12341234"))
            {
                ModelState.AddModelError("", "خطأ في اسم المسخدم او كلمة المرور");
                return View(loginModel);
            }

           /*var loginResult = await _accountProxy.AdminLogin(new DomainView.Models.LoginModel() { Username = loginModel.Username, Password = loginModel.Password });

            if (loginResult.IsSuccess)
            {
            }
            else
            {
                ModelState.AddModelError("", "خطأ في اسم المسخدم او كلمة المرور");
                return View(loginModel);
            }*/

            var claims = new List<Claim>()
                        {
                            new Claim("UserId", "CBFFE2D1-96EC-40FC-E122-08D8327D72FA"),
                            new Claim("FullName", "مدير النظام"),
                             new Claim("Username", "Admin")
                        };

                //await UserSignInAsync(claims);

                var claimIdenties = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimPrincipal = new ClaimsPrincipal(claimIdenties);
                var authenticationManager = Request.HttpContext;

                // Sign In.  
                await authenticationManager.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimPrincipal, new AuthenticationProperties() { IsPersistent = false });

                return RedirectToAction("Index", "Home");
        
        }


        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Login", "Account");
        }

    }
}
