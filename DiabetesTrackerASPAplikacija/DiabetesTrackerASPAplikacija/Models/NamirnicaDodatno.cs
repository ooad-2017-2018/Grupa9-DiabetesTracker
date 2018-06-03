using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiabetesTrackerASPAplikacija.Models
{
    public class NamirnicaDodatno
    {
        String vrsta;
        Double secer, ugljikohidrati, masti;
        int id;

        [Required]
        public string Vrsta { get => vrsta; set => vrsta = value; }
        [Required]
        public double Secer { get => secer; set => secer = value; }
        [Required]
        public double Ugljikohidrati { get => ugljikohidrati; set => ugljikohidrati = value; }
        [Required]
        public double Masti { get => masti; set => masti = value; }
        public int Id { get => id; set => id = value; }
    }
}