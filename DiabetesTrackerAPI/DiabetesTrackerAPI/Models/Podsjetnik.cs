namespace DiabetesTrackerAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Podsjetnik")]
    public partial class Podsjetnik
    {
        public int Id { get; set; }

        public int Tip { get; set; }

        public DateTime Datum { get; set; }

        public int Ponavljanje { get; set; }

        [Required]
        public string Opis { get; set; }

        public int KorisnikId { get; set; }

        public int? Korisnik_Id { get; set; }

        public int? Korisnik_Id1 { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }

        public virtual Korisnik Korisnik2 { get; set; }
    }
}
