using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesTracker.Model
{
    abstract class Dnevni_unos
    {
        DateTime datum;
        Kategorije tipKategorije;

        public DateTime Datum { get => datum; set => datum = value; }
        public Kategorije TipKategorije { get => tipKategorije; set => tipKategorije = value; }
    }
}
