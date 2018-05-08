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

        public List<string> Lijekovi { get => lijekovi; set => lijekovi = value; }
        public List<double> DozaLijeka { get => dozaLijeka; set => dozaLijeka = value; }
        internal TipTerapije Tip { get => tip; set => tip = value; }

    }
}