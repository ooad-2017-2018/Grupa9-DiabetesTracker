using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesTrackerASPAplikacija.Models
{
    public class Namirnica
    {
        String vrsta;
        Double secer, ugljikohidrati, masti;
        int id;
        public Namirnica(string vrsta, double secer, double ugljikohidrati, double masti)
        {
            this.vrsta = vrsta;
            this.secer = secer;
            this.ugljikohidrati = ugljikohidrati;
            this.masti = masti;
        }

        [Required]
        public string Vrsta { get => vrsta; set => vrsta = value; }
        [Required]
        public double Secer { get => secer; set => secer = value; }
        [Required]
        public double Ugljikohidrati { get => ugljikohidrati; set => ugljikohidrati = value; }
        [Required]
        public double Masti { get => masti; set => masti = value; }
        public int Id { get => id; set => id = value; }

        public int HranaId { get; set; }

        public virtual Hrana Hrana { get; set; }

        public int UnosHraneId { get; set; }

        public virtual UnosHrane UnosHrane { get; set; }
    }
}
