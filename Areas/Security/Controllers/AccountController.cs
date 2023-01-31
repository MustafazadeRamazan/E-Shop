using eshop_srytr.Controllers;
using eshop_srytr.Models.ApplicationServices.Abstraction;
using eshop_srytr.Models.Identity;
using eshop_srytr.Models.ViewModels;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using System.Web;

namespace eshop_srytr.Areas.Security.Controllers
{
    [Area("Security")]
    public class AccountController : Controller
    {
        ISecurityApplicationService security;

        public AccountController(ISecurityApplicationService security)
        {
            this.security = security;
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerVM)
        {
            if (ModelState.IsValid)
            {
                string[] erros = await security.Register(registerVM, Roles.Customer);

                if (erros == null)
                {
                    LoginViewModel loginVM = new LoginViewModel()
                    {
                        UserName = registerVM.UserName,
                        Password = registerVM.Password
                    };
                    return await Login(loginVM);
                }                
            }

            return View(registerVM);
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginVM)
        {
            if (ModelState.IsValid)
            {
                loginVM.LoginFailed = !await security.Login(loginVM);
                if (loginVM.LoginFailed == false)
                {
                    //return RedirectToAction(nameof(ProductController.Index), nameof(ProductController).Replace("Controller", ""), new { area = "", id = 1 });
                    return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", ""), new { area = "" });
                }
            }

            return View(loginVM);
        }

        public async Task<IActionResult> Logout()
        {
            await security.Logout();
            return RedirectToAction(nameof(Login));
        }

    }
}
