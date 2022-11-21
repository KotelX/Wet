using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wet.Models
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Name { get; set; }
        public long Numer { get; set; }
        public List<Symptom> Simptoms { get; set; } = new List<Symptom>();
        public List<Diagnosis> Diagnozs { get; set; } = new List<Diagnosis>();
    }
}
