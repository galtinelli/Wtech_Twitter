using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Twitter.Web.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Twitter.Web.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            if (userService.Any(x => x.EmailAddress == user.EmailAddress
                && x.Password == user.Password && x.Status == Status.Active))
            {
                //kullanıcı var db tablosunda
                User logged = userService.GetByDefault(x =>
                    x.EmailAddress == user.EmailAddress && x.Password == user.Password);

                //kullanıcının login olduğu bilgisini farklı yerlerde tutabiliriz
                // Cookie
                // Session
                // Redis gibi cache db de tutabiliriz.

                var claims = new List<Claim>()
            {
            new Claim("ID", logged.ID.ToString()),
            new Claim(ClaimTypes.Name, logged.FirstName),
            new Claim(ClaimTypes.Surname, logged.LastName),
            new Claim(ClaimTypes.Email, logged.EmailAddress),
            new Claim("Image", logged.ImageUrl)
            };

                //Giriş işlemleri ve ardından yönetici sayfasına yönlendireceğiz
                var userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Home", new { area = "Administrator" });
            }
            return View();
        }

        //Kullanıcı kayıt işlemleri

        public async Task<IActionResult> Register(Guid id)
        {
            User user = new User();
            return View(user);
        }

        [HttpPost]

        public async Task<IActionResult> Register(User user)
        {
            return View();
        }


        //Kullanıcı çıkış işlemleri
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
