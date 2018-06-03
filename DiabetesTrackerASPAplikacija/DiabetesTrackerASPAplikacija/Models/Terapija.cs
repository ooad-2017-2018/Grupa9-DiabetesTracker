using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesTrackerASPAplikacija.Models
{
    public class Terapija
    {
        TipTerapije tip;
        String lijekovi;
        String dozaLijeka;
        int id;
        [Required]
        [StringLength(1000,MinimumLength =1,ErrorMessage ="Duzina mora biti veca od 0")]
        public String Lijekovi {
            get => lijekovi;
            set
            {
                //if (value.Count == 0) throw new Exception("Morate unijeti barem jedan lijek");
                lijekovi = value;
            }
        }
        [Required]
        [StringLength(1000, MinimumLength = 1, ErrorMessage = "Duzina mora biti veca od 0")]
        public string DozaLijeka {
            get => dozaLijeka;
            set {
                /*if (value.Count != Lijekovi.Count) throw new Exception("Broj unijetih doza lijeka se mora podudarati sa brojem unijetih lijekova");
                else if (value.Count == 0) throw new Exception("Morate unijeti barem jednu dozu lijeka");
                else*/ dozaLijeka = value;
            }
        }
        [Required]
        public TipTerapije Tip { get => tip; set => tip = value; }
        public int Id { get => id; set => id = value; }

        public int KorisnikId { get; set; }

        public virtual Korisnik Korisnik { get; set; }

    }
}