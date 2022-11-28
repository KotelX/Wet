using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Wet.Controllers
{
    [Route("{action}")]
    public class HomeController : Controller
    {
        private WetContext context { get; }
        public HomeController(WetContext context)
        {
            this.context = context;
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

            //for (int i = 0; i < 10; i++)
            //{

            //}
            //foreach (int i in 5)
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
    }
}

