using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Wet.Models;

namespace Wet.Controllers
{
    [Route("{action}")]
    public class HomeController : Controller
    {
        private WetContext context { get; }

        public HomeController()
        {
            //this.context = context;
            //context.Patients.AddRange(new List<Models.Patient> {
            //new() {
            //    Name = "Cati",
            //    Numer = 231,
            //    Diagnozs = new() {
            //        new Models.Diagnosis() {Name = "Diag1" },
            //        new Models.Diagnosis() {Name = "Diag2" },
            //        new Models.Diagnosis() {Name = "Diag3" }
            //    },
            //    Simptoms = new() {
            //        new() {Name = "Sim1"},
            //        new() {Name = "Sim3"}
            //        }
            //},
            //new() {
            //    Name = "Tom",
            //    Numer = 321,
            //    Diagnozs = new() {
            //        new() {Name = "Diag1" },
            //        new() {Name = "Diag3" }
            //    },
            //    Simptoms = new() {
            //        new() {Name = "Sim1"},
            //        new() {Name = "Sim2"}
            //        }
            //    }
            //});
            //context.SaveChanges();
        }
        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("/Profile")]
        public ActionResult Profile(int number = 0)
        {
            return View(context.Patients.Include(y => y.Simptoms).Include(j => j.Diagnozs).FirstOrDefault(x => x.Numer == number));

        }

        [Route("/Patients")]
        public ActionResult Patients(int number = 0)
        {
            return View(context.Patients.Include(y => y.Simptoms).Include(j => j.Diagnozs).ToList());
        }

        [Route("/login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        [Route("/logout")]
        public IResult Logout()
        {
            HttpContext.SignOutAsync();
            return Results.Redirect("/lk");
        }

        [HttpPost]
        [Route("/login")]
        public IResult Login(string login, string password)
        {
            // если email и/или пароль не установлены, посылаем статусный код ошибки 400
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
                return Results.Unauthorized();

            // находим пользователя 
            var person = UserConstants.Users.FirstOrDefault(p => p.EmailAddress == login && p.Password == password);
            // если пользователь не найден, отправляем статусный код 401
            if (person is null) return Results.Unauthorized();

            var claims = new List<Claim> { new Claim(ClaimTypes.Name, person.Username) };
            // создаем объект ClaimsIdentity
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Cookies");
            // установка аутентификационных куки
            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
            return Results.Redirect("/lk");
        }
    }
}
