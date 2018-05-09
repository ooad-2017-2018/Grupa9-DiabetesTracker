using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesTracker.Model
{
    public class Terapija
    {
        TipTerapije tip;
        List<String> lijekovi;
        List<double> dozaLijeka;

        public List<string> Lijekovi {
            get => lijekovi;
            set
            {
                if (value.Count == 0) throw new Exception("Morate unijeti barem jedan lijek");
                lijekovi = value;
            }
        }
        public List<double> DozaLijeka {
            get => dozaLijeka;
            set {
                if (value.Count != Lijekovi.Count) throw new Exception("Broj unijetih doza lijeka se mora podudarati sa brojem unijetih lijekova");
                else if (value.Count == 0) throw new Exception("Morate unijeti barem jednu dozu lijeka");
                else dozaLijeka = value;
            }
        }

        public TipTerapije Tip { get => tip; set => tip = value; }

    }
}