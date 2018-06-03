using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesTrackerASPAplikacija.Models
{
    public abstract class Dnevni_unos
    {
        DateTime datum;
        Kategorije tipKategorije;
        int id;
        [Required]
        public DateTime Datum { get => datum; set => datum = value; }

        [Required]
        [DisplayName("Tip kategorije")]
        public Kategorije TipKategorije { get => tipKategorije; set => tipKategorije = value; }
        public int Id { get => id; set => id = value; }

        /*public int KorisnikId { get; set; }

        public virtual Korisnik Korisnik { get; set; }*/
    }
}
