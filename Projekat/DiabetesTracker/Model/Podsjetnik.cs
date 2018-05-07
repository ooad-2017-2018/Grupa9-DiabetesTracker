using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesTracker.Model
{
    class Podsjetnik
    {
        TipPodsjetnika tip;
        DateTime datum;
        Ponavljanja ponavljanje;
        String opis;

        public TipPodsjetnika Tip { get => tip; set => tip = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public Ponavljanja Ponavljanje { get => ponavljanje; set => ponavljanje = value; }
        public string Opis { get => opis; set => opis = value; }
    }
}
