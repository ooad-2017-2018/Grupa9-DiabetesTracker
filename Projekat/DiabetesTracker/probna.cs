using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesTracker
{
    public class probna
    {
        string proba;

        public probna(string proba)
        {
            this.proba = proba;
        }

        public string Proba { get => proba; set => proba = value; }
    }
}
