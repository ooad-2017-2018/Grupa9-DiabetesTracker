using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiabetesTracker.Model;

namespace DiabetesTracker.ViewModel
{
    class HranaViewModel
    {
        Hrana hrana;
        DnevniUnosViewModel parent;

        public HranaViewModel(DnevniUnosViewModel parent)
        {
            this.parent = parent;
        }

        public List<int> Kolicine { get => hrana.Kolicine; }
        public List<Namirnica> Namirnice { get => hrana.Namirnice; }
        public Hrana Hrana { get => hrana; set => hrana = value; }
        public DnevniUnosViewModel Parent { get => parent; set => parent = value; }

        public void dodajNamirnicu(Namirnica namirnica)
        {
            hrana.Namirnice.Add(namirnica);
        }

        public void dodajKolicinu(int kolicina)
        {
            hrana.Kolicine.Add(kolicina);
        }


    }
}
