﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Wet.Controllers
{
    [Route("{action}")]
    public class HomeController : Controller
    {
        public HomeController(WetContext context)
        {
            var pat = context.Patients.ToList();
            var sim = context.Simptoms.ToList();
        }
        [Route("/")]
        public ActionResult Index()
        {
            ViewData["Title"] = "hui";
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
