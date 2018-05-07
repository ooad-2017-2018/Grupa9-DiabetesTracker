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
        public TipPodsjetnika Tip { get => podsjetnik.Tip; set => podsjetnik.Tip = value; }
        public DateTime Datum { get => podsjetnik.Datum; set => podsjetnik.Datum = value; }
        public Ponavljanja Ponavljanje { get => podsjetnik.Ponavljanje; set => podsjetnik.Ponavljanje = value; }
        public string Opis { get => podsjetnik.Opis; set => podsjetnik.Opis = value; }

    }
}
