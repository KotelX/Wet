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
        public int Breed { get; set; }
        public bool Gender { get; set; }
        public string OwnerName { get; set; }
        public string OwnerSurname { get; set; }
        public string OwnerEmail { get; set; }
        public string OwnerPhone { get; set; }
        public string Comment { get; set; }
        public DateTime Birthday { get; set; }
        public List<Visiting> Visitings { get; set; } = new List<Visiting>();
    }
}
