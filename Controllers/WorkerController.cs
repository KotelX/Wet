using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Wet.Models;

namespace Wet.Controllers
{
    [Route("/")]
    [Authorize]
    public class WorkerController : Controller
    {
        private WetContext context { get; }

        private Doctor Doctor { get; set; }

        public WorkerController(WetContext context)
        {
            this.context = context;
            Doctor = context.Doctors.FirstOrDefault(x => x.EmailAddress == this.User.FindFirst(ClaimTypes.Email).Value);
            ViewData["UserName"] = Doctor.Name;
        }

        [Route("/PatientsInfo")]
        public IActionResult PatientsInfo(int number = 0)
        {
            //context.Doctors.AddRange(UserConstants.Users);
            //context.SaveChanges();
            
            return View();

        }

        [HttpDelete]
        [Route("/PatientsInfoDeliteDiagnoz")]
        public ActionResult PatientsInfoDeliteDiagnoz(string diagnozId, string patientId)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("/PatientsInfoDeliteSimptom")]
        public ActionResult PatientsInfoDeliteSimptom(string simptomId, string patientId)
        {
            return Ok();
        }

        [Route("/lk")]
        public ActionResult Lk()
        {
            return View();
        }

        [Route("/CreatePatient")]
        public ActionResult CreatePatient(Patient patient = null)
        {
            return View();
        }

        [AllowAnonymous]
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

        [AllowAnonymous]
        [HttpPost]
        [Route("/login")]
        public IResult Login(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
                return Results.Unauthorized();

            var person = UserConstants.Users.FirstOrDefault(p => p.EmailAddress == login && p.Password == password);
            if (person is null) return Results.Unauthorized();

            var claims = new List<Claim> { new Claim(ClaimTypes.Email, person.EmailAddress) };

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Cookies");

            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
            return Results.Redirect("/lk");
        }
    }
}
