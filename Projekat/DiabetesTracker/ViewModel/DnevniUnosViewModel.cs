using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiabetesTracker.Model;

namespace DiabetesTracker.ViewModel
{
    class DnevniUnosViewModel
    {
        Dnevni_unos dnevniUnos;
        HranaViewModel dijete1;
        NijeHranaViewModel dijete2;

        public DnevniUnosViewModel(Dnevni_unos dnevniUnos)
        {
            this.dnevniUnos = dnevniUnos;
        }

        public DateTime Datum { get => dnevniUnos.Datum; set => dnevniUnos.Datum = value; }
        public Kategorije TipKategorije { get => dnevniUnos.TipKategorije; set => dnevniUnos.TipKategorije = value; }
        public Dnevni_unos DnevniUnos { get => dnevniUnos; set => dnevniUnos = value; }
        public HranaViewModel Dijete1 { get => dijete1; set => dijete1 = value; }
        public NijeHranaViewModel Dijete2 { get => dijete2; set => dijete2 = value; }
    }
}
