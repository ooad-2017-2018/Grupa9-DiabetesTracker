using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiabetesTrackerASPAplikacija.Models
{
    public class NamirnicaHranaPoveznica
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Id namirnice")]
        public int NamirnicaId { get; set; }
        [Required]
        [DisplayName("Id hrane")]
        public int HranaId { get; set; }
    }
}