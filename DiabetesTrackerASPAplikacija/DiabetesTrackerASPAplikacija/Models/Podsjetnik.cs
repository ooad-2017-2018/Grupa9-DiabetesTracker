using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesTrackerASPAplikacija.Models
{
    public class Podsjetnik
    {
        TipPodsjetnika tip;
        DateTime datum;
        Ponavljanja ponavljanje;
        String opis;
        int id;
        [Required]
        [DisplayName ("Tip podsjetnika")]
        public TipPodsjetnika Tip { get => tip; set => tip = value; }
        [Required]
        public DateTime Datum { get => datum; set => datum = value; }
        [Required]
        public Ponavljanja Ponavljanje { get => ponavljanje; set => ponavljanje = value; }
        [Required]
        public string Opis { get => opis; set => opis = value; }
        public int Id { get => id; set => id = value; }

        public int KorisnikId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
    }
}