using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [Route("/lk")]
        public ActionResult Lk()
        {
            return View();
        }

        [Route("/CreatePatient")]
        public ActionResult CreatePatient()
        {
            return View();
        }
    }
}
