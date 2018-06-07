namespace DiabetesTrackerAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UnosNijeHrana")]
    public partial class UnosNijeHrana
    {
        public int Id { get; set; }

        public int Tip { get; set; }

        public double Vrijednost { get; set; }

        public DateTime Datum { get; set; }

        public int TipKategorije { get; set; }

        public int KorisnikId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
    }
}
