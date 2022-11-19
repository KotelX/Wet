using Microsoft.AspNetCore.Mvc;

namespace Wet.Controllers
{
    public class WorkerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
