using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesTracker.Model
{
    public class Namirnica
    {
        String vrsta;
        Double secer, ugljikohidrati, masti;

        public Namirnica(string vrsta, double secer, double ugljikohidrati, double masti)
        {
            this.vrsta = vrsta;
            this.secer = secer;
            this.ugljikohidrati = ugljikohidrati;
            this.masti = masti;
        }

        public string Vrsta { get => vrsta; set => vrsta = value; }
        public double Secer { get => secer; set => secer = value; }
        public double Ugljikohidrati { get => ugljikohidrati; set => ugljikohidrati = value; }
        public double Masti { get => masti; set => masti = value; }
    }
}
