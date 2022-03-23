﻿using Kili.Models;
using Kili.Models.General;
using Kili.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;

namespace Kili.Controllers
{
    public class LoginController : Controller
    {
        private UserAccount_Services UserAccount_Services;

        public LoginController()
        {
            UserAccount_Services = new UserAccount_Services();
        }


        public IActionResult Authentification()
        {

                UserAccountViewModel viewModel = new UserAccountViewModel { Authentifie = HttpContext.User.Identity.IsAuthenticated };
                if (viewModel.Authentifie)
                {
                    viewModel.UserAccount = UserAccount_Services.ObtenirUserAccount(HttpContext.User.Identity.Name);
                    return View(viewModel);
                }
                return View(viewModel);
        }

        [HttpPost]
        public IActionResult Authentification(UserAccountViewModel viewModel, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                UserAccount utilisateur = UserAccount_Services.Authentifier(viewModel.UserAccount.UserName, viewModel.UserAccount.Password);
                if (utilisateur != null)
                {
                    var userClaims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name, utilisateur.Id.ToString()),
                        new Claim(ClaimTypes.Role, utilisateur.Role.ToString()),
                    };

                    var ClaimIdentity = new ClaimsIdentity(userClaims, "User Identity");

                    var userPrincipal = new ClaimsPrincipal(new[] { ClaimIdentity });

                    HttpContext.SignInAsync(userPrincipal);

                    if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                        return Redirect(returnUrl);

                    return Redirect("/");
                }
               ModelState.AddModelError("UserAccount.UserName", "UserName et/ou mot de passe incorrect(s)");
            }
            return View(viewModel);
        }

        public ActionResult Deconnexion()
        {
            HttpContext.SignOutAsync();
            return Redirect("/");
        }


    }
}
