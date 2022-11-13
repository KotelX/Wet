namespace Wet
{
    public class Datas
    {
        public List<Models.Patient> Patients { get; set; } = new List<Models.Patient> {
            new() {
                Id = 1,
                Name = "Cati",
                Numer = 231,
                Diagnozs = new() { new Models.Diagnosis() {Id = 1, Name = "Diag1" }, new Models.Diagnosis() { Id = 2, Name = "Diag2" } },
                Simptoms = new() {
                    new() { Id = 1, Name = "Sim1"},
                    new() { Id = 3, Name = "Sim3"}
                    } 
            },
            new() {
                Id = 2,
                Name = "Tom",
                Numer = 321,
                Diagnozs = new() {
                    new() {Id = 1, Name = "Diag1" },
                    new() { Id = 3, Name = "Diag3" }
                },
                Simptoms = new() {
                    new() { Id = 1, Name = "Sim1"},
                    new() { Id = 2, Name = "Sim2"}
                    }
                }
            };
        public List<Models.Symptom> Symptoms { get; set; } = new List<Models.Symptom> { 
            new() { Id = 1, Name = "Sim1" }, 
            new() { Id = 2, Name = "Sim2" }, 
            new() { Id = 3, Name = "Sim3" } 
        };
        public List<Models.Diagnosis> Diagnoses { get; set; } = new List<Models.Diagnosis> { 
            new Models.Diagnosis() { Id = 1, Name = "Diag1" }, 
            new Models.Diagnosis() { Id = 2, Name = "Diag2" }, 
            new Models.Diagnosis() { Id = 3, Name = "Diag3" } 
        };
    }
}
