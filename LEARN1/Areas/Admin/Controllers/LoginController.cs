using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LEARN1.Data.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TeduCoreApp.Models.AccountViewModels;
using TeduCoreApp.Utilities.Dtos;

namespace LEARN1.Areas.Admin.Controllers
{
   [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        //private readonly IEmailSender _emailSender;

        public LoginController(ILogger<LoginController> logger, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            //_emailSender = emailSender;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        
        public async Task<IActionResult> Authen(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user =await _userManager.FindByNameAsync(model.UserName);
                 await _signInManager.SignInAsync(user,false);
                return View();
            }

            // If we got this far, something failed, redisplay form
            return new ObjectResult(new GenericResult(false, model));
        }

    }
}