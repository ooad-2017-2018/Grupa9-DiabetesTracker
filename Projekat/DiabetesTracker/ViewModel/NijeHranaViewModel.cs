using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiabetesTracker.Model;

namespace DiabetesTracker.ViewModel
{
    class NijeHranaViewModel
    {
        Nije_hrana nijeHrana;
        DnevniUnosViewModel parent;

        public NijeHranaViewModel(DnevniUnosViewModel parent)
        {
            this.parent = parent;
        }

        public Nije_hrana NijeHrana { get => nijeHrana; set => nijeHrana = value; }
        public DnevniUnosViewModel Parent { get => parent; set => parent = value; }
        public TipUnosa Tip { get => nijeHrana.Tip; }
        public double Vrijednost { get => nijeHrana.Vrijednost; }
    }
}
