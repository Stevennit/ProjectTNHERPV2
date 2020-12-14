using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Hiver.Application.System.Users;
using Hiver.Data.Entities;
using Hiver.Utilities.Constants;
using Hiver.ViewModels.Common;
using Hiver.ViewModels.System.Users;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;

namespace Hiver.WebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserService _userService;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IConfiguration _config;
        private readonly IConfiguration _configuration;


        public LoginController(IUserService userService,
            IConfiguration configuration, UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            IConfiguration config)
        {
            _userService = userService;
            _configuration = configuration;
            _userManager = userManager;
            _signInManager = signInManager;
            _config = config;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var user = await _userManager.FindByNameAsync(request.UserName);

            if (user == null) {
                return View("Tài khoản không tồn tại");
            } 


            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
            if (!result.Succeeded)
            {
                return View("Mật khẩu không đúng");
            }

            var claims = new[]
            {
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.GivenName,user.FirstName),
                new Claim(ClaimTypes.Name, request.UserName)
            };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity));


            return RedirectToAction("Index", "Home");
        }
               
    }
}