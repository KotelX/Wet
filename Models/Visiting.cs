using System.ComponentModel.DataAnnotations;

namespace Wet.Models
{
    public class Visiting
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public double Price { get; set; }
        public List<Symptom> Symptoms { get; set; } = new();
        public List<Diagnosis> Diagnosis { get; set; } = new();
    }
}
