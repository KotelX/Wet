using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Wet.Models;

namespace Wet.Controllers
{
    [Route("/")]
    public class WorkerController : Controller
    {
        private WetContext context { get; }

        public WorkerController(WetContext context)
        {
            this.context = context;
        }

        [Route("/login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [Route("/login")]
        public IActionResult Login(string login, string password)
        {
            return View();
        }

        [Route("/PatientsInfo")]
        public IActionResult PatientsInfo(int number = 0)
        {
            return View(context.Patients.Include(y => y.Simptoms).Include(j => j.Diagnozs).FirstOrDefault(x => x.Numer == number));

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

        [Route("/LK")]
        public ActionResult LK()
        {
            return View();
        }
    }
}
