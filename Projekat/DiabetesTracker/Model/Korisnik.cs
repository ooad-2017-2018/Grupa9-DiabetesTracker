using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesTracker.Model
{
    public class Korisnik:Osoba
    {
        String tipDijabetesa;
        Double visina;
        Double tezina;
        Double fizickaAktivnost;
        Double vrijednostHiperglikemije;
        Double vrijednostHipoglikemije;
        Double ciljaniNivoGlukoze;
        Double donjaGranicaGlukoze;
        Double gornjaGranicaGlukoze;
        List<Dnevni_unos> dnevniUnosi;
        List<Nalaz> nalazi;
        List<Podsjetnik> podsjetnici;
        Terapija terapija;

        public string TipDijabetesa { get => tipDijabetesa; set => tipDijabetesa = value; }
        public double Visina { get => visina; set => visina = value; }
        public double Tezina { get => tezina; set => tezina = value; }
        public double FizickaAktivnost { get => fizickaAktivnost; set => fizickaAktivnost = value; }
        public double VrijednostHiperglikemije { get => vrijednostHiperglikemije; set => vrijednostHiperglikemije = value; }
        public double VrijednostHipoglikemije { get => vrijednostHipoglikemije; set => vrijednostHipoglikemije = value; }
        public double CiljaniNivoGlukoze { get => ciljaniNivoGlukoze; set => ciljaniNivoGlukoze = value; }
        public double DonjaGranicaGlukoze { get => donjaGranicaGlukoze; set => donjaGranicaGlukoze = value; }
        public double GornjaGranicaGlukoze { get => gornjaGranicaGlukoze; set => gornjaGranicaGlukoze = value; }
        public List<Dnevni_unos> DnevniUnosi { get => dnevniUnosi; set => dnevniUnosi = value; }
        public List<Nalaz> Nalazi { get => nalazi; set => nalazi = value; }
        public Terapija Terapija { get => terapija; set => terapija = value; }

        public List<Podsjetnik> Podsjetnici { get => podsjetnici; set => podsjetnici = value; }

        public void dodajDnevniUnos(Dnevni_unos dnevniUnos)
        {
            dnevniUnosi.Add(dnevniUnos);
        }

        public void dodajNalaz(Nalaz nalaz)
        {
            nalazi.Add(nalaz);
        }








        public void dodajPodsjetnik(Podsjetnik podsjetnik)
        {
            podsjetnici.Add(podsjetnik);
        }
    }
}
