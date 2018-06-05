namespace DiabetesTrackerRestAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NamirnicaHranaPoveznica")]
    public partial class NamirnicaHranaPoveznica
    {
        public int Id { get; set; }

        public int NamirnicaId { get; set; }

        public int HranaId { get; set; }
    }
}
