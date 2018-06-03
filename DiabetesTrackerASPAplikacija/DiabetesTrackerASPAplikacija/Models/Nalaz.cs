using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Windows.UI.Xaml.Media.Imaging;

namespace DiabetesTrackerASPAplikacija.Models
{
    public class Nalaz
    {
        int id;
        String nazivFajla;
        //      BitmapImage slika;
        String tekstNalaza;

        [Required]
        [DisplayName("Naziv nalaza")]
        public string NazivFajla { get => nazivFajla; set => nazivFajla = value; }

        [DisplayName("Tekst nalaza")]
        public string TekstNalaza { get; set; }

        public int Id { get => id; set => id = value; }
        //    public BitmapImage Slika { get => slika; set => slika = value; }

        public int KorisnikId { get; set; }

        public virtual Korisnik Korisnik { get; set; }

    }
}