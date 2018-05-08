using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesTracker.ViewModel
{
    public class DoktorViewModel
    {
        Doktor doktor;
        public DoktorViewModel(Doktor doktor)
        {
            this.doktor = doktor;
        }
        public void getDoktor() { }
        public void setDoktor() { }
        public void pregledajNalaz() { }
        public void dodajNalaz() { }
    }
}
