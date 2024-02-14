
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AllPaczkinoMVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.Extensions.Options;
using Microsoft.Graph.Models.Security;

namespace AllPaczkinoMVC.Controllers
{
    public class IdentityController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public IdentityController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager; 
        }
        public async Task<IActionResult> Signup()
        {
            var model = new SignupViewModel() { Role = Roles.Member };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Signup(SignupViewModel model)
        {
            if (ModelState.IsValid)
            {
              
                if ((await _userManager.FindByEmailAsync(model.Email)) == null)
                {
                    var user = new IdentityUser
                    {
                        Email = model.Email,
                        UserName = model.Email
                    };

                    var result = await _userManager.CreateAsync(user, model.Password);
                    //zeby byla pewnosc ze to odpowiedni user
                    user = await _userManager.FindByEmailAsync(model.Email);
                    var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    if (result.Succeeded)
                    {
                        var confirmationLink = Url.Action("ConfirmEmail", "Identity", new { userId = user.Id, @token = token });
                       // await emailSender.SendEmailAsync(emailOptions.SenderEmail, user.Email, "ConfirmationLink", confirmationLink);
                        
                        await _userManager.AddToRoleAsync(user, model.Role.ToString());
                        return RedirectToAction("Signin");
                    }

                    ModelState.AddModelError("Signup", string.Join("", result.Errors.Select(x => x.Description)));
                    return View(model);
                }
                else
                {
                    return RedirectToAction("EmailUsed");
                }
            }
            
            return View(model);
        }


        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            return new NotFoundResult();
        }
        public IActionResult Signin()
        {
            return View(new SigninViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Signin(SigninViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {

                    var user = await _userManager.FindByEmailAsync(model.Username);

                    var userClaims = await _userManager.GetClaimsAsync(user);

                    if (await _userManager.IsInRoleAsync(user, "Member"))
                    {
                        return RedirectToAction("Member", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("Login", "Cannot login.");
                }
            }
            return View(model);
        }

        public async Task<IActionResult> AccessDenied()
        {
            return View();
        }

        public async Task<IActionResult> EmailUsed()
        {
            return View();
        }

        public async Task<IActionResult> Signout()
        {
            return RedirectToAction("Signin");
        }
    }
}