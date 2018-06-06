using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesTrackerASPAplikacija.Models
{
    public class Hrana: Dnevni_unos
    {

        //List<Namirnica> namirnice = new List<Namirnica>();
        String kolicine;

        [Required]
        String Kolicine { get; set; }
        
        //public List<Namirnica> Namirnice { get => namirnice; }

        public int KorisnikId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
    }
}
