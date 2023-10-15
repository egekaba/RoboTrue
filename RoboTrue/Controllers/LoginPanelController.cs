
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoboTrue.DataAcsess.Contexts;
using RoboTrue.UI.Models;
using System.Security.Claims;

namespace RoboTrue.UI.Controllers
{


    public class LoginPanelController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        private readonly SqlDbContext _dbcontext;
        public LoginPanelController(SqlDbContext dbContext)
        {
            _dbcontext = dbContext;

        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {


            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Login(KullaniciDto dto)
        {

            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            var kullanici = _dbcontext.Kullanicii.Include(p => p.KayitliOlduguDepartman).Where(p => p.Email == dto.Email && p.Sifre == dto.Sifre).FirstOrDefault();

            if (kullanici == null)
            {
                ModelState.AddModelError("", "Email yada Password Hatalidir");
                return View(dto);
            }


            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Email, dto.Email),
                new Claim(ClaimTypes.Name,kullanici.KullaniciAdi),
                new Claim(ClaimTypes.Name,kullanici.Sifre)


            };

            var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authenticationProperty = new AuthenticationProperties

            {
                IsPersistent = dto.RememberMe
            };



            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimIdentity),
                authenticationProperty);




            return RedirectToAction("Index", kullanici.KayitliOlduguDepartman.DepartmanAdi, new { Area = kullanici.KayitliOlduguDepartman.DepartmanAdi });

        }


        [AllowAnonymous]
        public async Task<IActionResult> Logout(KullaniciDto dto)
        {

            var claimIdentity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
            var authenticationProperty = new AuthenticationProperties

            {
                IsPersistent = dto.RememberMe
            };


            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", new { Area = "LoginPanel" });
        }

    }
}
