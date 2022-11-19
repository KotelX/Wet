using Microsoft.AspNetCore.Mvc;

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
    }
}
