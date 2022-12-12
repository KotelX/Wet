using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

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
