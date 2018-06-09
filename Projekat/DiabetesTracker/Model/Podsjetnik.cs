using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesTracker.Model
{
    public class Podsjetnik
    {
        TipPodsjetnika tip;
        DateTime datum;
        Ponavljanja ponavljanje;
        String opis;

        //refactoring:remove setting method
        public TipPodsjetnika Tip { get => tip; }
        public DateTime Datum { get => datum; }
        public Ponavljanja Ponavljanje { get => ponavljanje; }
        public string Opis { get => opis; }
    }
}
