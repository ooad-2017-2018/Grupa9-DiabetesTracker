namespace DiabetesTrackerRestAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Namirnica")]
    public partial class Namirnica
    {
        public int Id { get; set; }

        [Required]
        public string Vrsta { get; set; }

        public double Secer { get; set; }

        public double Ugljikohidrati { get; set; }

        public double Masti { get; set; }

        public int HranaId { get; set; }

        public int? Hrana_Id { get; set; }

        public int? Hrana_Id1 { get; set; }

        public virtual Dnevni_unos Dnevni_unos { get; set; }

        public virtual Dnevni_unos Dnevni_unos1 { get; set; }

        public virtual Dnevni_unos Dnevni_unos2 { get; set; }
    }
}
