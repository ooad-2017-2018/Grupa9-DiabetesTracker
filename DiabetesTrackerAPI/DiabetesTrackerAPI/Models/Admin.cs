namespace DiabetesTrackerAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        public int Id { get; set; }

        public int Spol { get; set; }

        [Required]
        public string Ime { get; set; }

        [Required]
        public string Prezime { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string PotvrdaPassworda { get; set; }

        [Required]
        public string EMail { get; set; }

        [Required]
        [StringLength(13)]
        public string JMBG1 { get; set; }

        public int Spol1 { get; set; }

        public DateTime DatumRodjenja { get; set; }
    }
}
