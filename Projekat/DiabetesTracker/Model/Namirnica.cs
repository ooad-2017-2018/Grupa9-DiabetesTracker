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

        //refactoring:remove setting method
        public string Vrsta { get => vrsta; }
        public double Secer { get => secer; }
        public double Ugljikohidrati { get => ugljikohidrati; }
        public double Masti { get => masti; }
    }
}
