using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesTracker.Model
{
    class Nije_hrana: Dnevni_unos
    {
        TipUnosa tip;
        Double vrijednost;

        public TipUnosa Tip { get => tip; set => tip = value; }
        public double Vrijednost { get => vrijednost; set => vrijednost = value; }
    }
}
