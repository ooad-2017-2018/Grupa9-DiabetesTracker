namespace DiabetesTrackerAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NamirnicaDodatno")]
    public partial class NamirnicaDodatno
    {
        public int Id { get; set; }

        [Required]
        public string Vrsta { get; set; }

        public double Secer { get; set; }

        public double Ugljikohidrati { get; set; }

        public double Masti { get; set; }
    }
}
