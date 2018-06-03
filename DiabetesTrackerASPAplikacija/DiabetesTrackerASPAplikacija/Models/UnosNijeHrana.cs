using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiabetesTrackerASPAplikacija.Models
{
    public class UnosNijeHrana
    {
        DateTime datum;
        Kategorije tipKategorije;
        int id;

        TipUnosa tip;
        Double vrijednost;

        [Required]
        public TipUnosa Tip { get => tip; set => tip = value; }
        [Required]
        public double Vrijednost { get => vrijednost; set => vrijednost = value; }
        
        [Required]
        public DateTime Datum { get => datum; set => datum = value; }

        [Required]
        [DisplayName("Tip kategorije")]
        public Kategorije TipKategorije { get => tipKategorije; set => tipKategorije = value; }
        public int Id { get => id; set => id = value; }

        public int KorisnikId { get; set; }

        public virtual Korisnik Korisnik { get; set; }


    }
}