namespace Wet
{
    public class Datas
    {
        public List<Models.Patient> Patients { get; set; } = new List<Models.Patient> {
            new() {
                Name = "Cati",
                Numer = 231,
                Diagnozs = new() { 
                    new Models.Diagnosis() {Name = "Diag1" }, 
                    new Models.Diagnosis() {Name = "Diag2" },
                    new Models.Diagnosis() {Name = "Diag3" }
                },
                Simptoms = new() {
                    new() {Name = "Sim1"},
                    new() {Name = "Sim3"}
                    } 
            },
            new() {
                Name = "Tom",
                Numer = 321,
                Diagnozs = new() {
                    new() {Name = "Diag1" },
                    new() {Name = "Diag3" }
                },
                Simptoms = new() {
                    new() {Name = "Sim1"},
                    new() {Name = "Sim2"}
                    }
                }
            };
        public List<Models.Symptom> Symptoms { get; set; } = new List<Models.Symptom> { 
            new() {Name = "Sim1" }, 
            new() {Name = "Sim2" }, 
            new() {Name = "Sim3" } 
        };
        public List<Models.Diagnosis> Diagnoses { get; set; } = new List<Models.Diagnosis> { 
            new Models.Diagnosis() {Name = "Diag1" }, 
            new Models.Diagnosis() {Name = "Diag2" }, 
            new Models.Diagnosis() {Name = "Diag3" } 
        };
    }
}
