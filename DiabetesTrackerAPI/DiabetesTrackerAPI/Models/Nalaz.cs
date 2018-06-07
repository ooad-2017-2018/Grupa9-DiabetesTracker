namespace DiabetesTrackerAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nalaz")]
    public partial class Nalaz
    {
        public int Id { get; set; }

        [Required]
        public string NazivFajla { get; set; }

        public int KorisnikId { get; set; }

        public int? Korisnik_Id { get; set; }

        public int? Korisnik_Id1 { get; set; }

        public string TekstNalaza { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }

        public virtual Korisnik Korisnik2 { get; set; }
    }
}
