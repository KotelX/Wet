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
            return View();

        }

        [Route("/Patients")]
        public ActionResult Patients(int number = 0)
        {
            return View();
        }
    }
}
