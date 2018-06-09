using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiabetesTracker.Model;

namespace DiabetesTracker.ViewModel
{
    class PodsjetnikViewModel
    {
        Podsjetnik podsjetnik;

        public PodsjetnikViewModel(Podsjetnik podsjetnik)
        {
            this.podsjetnik = podsjetnik;
        }

        public Podsjetnik Podsjetnik { get => podsjetnik; set => podsjetnik = value; }
        public TipPodsjetnika Tip { get => podsjetnik.Tip; }
        public DateTime Datum { get => podsjetnik.Datum; }
        public Ponavljanja Ponavljanje { get => podsjetnik.Ponavljanje; }
        public string Opis { get => podsjetnik.Opis; }

    }
}
