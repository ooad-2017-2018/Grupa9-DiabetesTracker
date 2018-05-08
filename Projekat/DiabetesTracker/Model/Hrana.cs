using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesTracker.Model
{
    public class Hrana: Dnevni_unos
    {
        List<Namirnica> namirnice = new List<Namirnica>();
        List<int> kolicine = new List<int>();

        public List<int> Kolicine { get => kolicine; }
        public List<Namirnica> Namirnice { get => namirnice; }
    }
}
