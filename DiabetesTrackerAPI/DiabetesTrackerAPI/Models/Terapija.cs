namespace DiabetesTrackerAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Terapija")]
    public partial class Terapija
    {
        public int Id { get; set; }

        public int Tip { get; set; }

        public int KorisnikId { get; set; }

        public int? Korisnik_Id { get; set; }

        [Required]
        [StringLength(1000)]
        public string Lijekovi { get; set; }

        [Required]
        [StringLength(1000)]
        public string DozaLijeka { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }
    }
}
