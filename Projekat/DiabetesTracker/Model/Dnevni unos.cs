using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesTracker.Model
{
    public abstract class Dnevni_unos
    {
        DateTime datum;
        Kategorije tipKategorije;


        //refactoring:remove setting method
        public DateTime Datum { get => datum; }
        public Kategorije TipKategorije { get => tipKategorije; }
    }
}
