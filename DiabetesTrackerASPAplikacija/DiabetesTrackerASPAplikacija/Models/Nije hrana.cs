using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesTrackerASPAplikacija.Models
{
    public class Nije_hrana: Dnevni_unos
    {
        TipUnosa tip;
        Double vrijednost;

        [Required]
        public TipUnosa Tip { get => tip; set => tip = value; }
        [Required]
        public double Vrijednost { get => vrijednost; set => vrijednost = value; }

        public int KorisnikId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
    }
}
