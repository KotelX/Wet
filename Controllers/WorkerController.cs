using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Wet.Models;

namespace Wet.Controllers
{
    [Route("/")]
    public class WorkerController : Controller
    {
        [Route("/login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("/LK")]
        public ActionResult LK()
        {
            return View();
        }
    }
}
