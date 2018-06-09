using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesTracker.Model
{
    public class Nije_hrana: Dnevni_unos
    {
        TipUnosa tip;
        Double vrijednost;

        //refactoring:remove setting method
        public TipUnosa Tip { get => tip; }
        public double Vrijednost { get => vrijednost; }
    }
}
