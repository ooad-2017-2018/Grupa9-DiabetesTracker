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
        String fizickaAktivnost;
        Double vrijednostHiperglikemije;
        Double vrijednostHipoglikemije;
        Double ciljaniNivoGlukoze;
        Double donjaGranicaGlukoze;
        Double gornjaGranicaGlukoze;
        List<Dnevni_unos> dnevniUnosi;
        List<Nalaz> nalazi;
        List<Podsjetnik> podsjetnici;
        Terapija terapija;

        public string TipDijabetesa
        {
            get => tipDijabetesa;
            set
            {
                if (value.Length == 0)
                    throw new Exception("Polje ne smije biti prazno");
                tipDijabetesa = value;
            }
        }
        public double Visina
        {
            get => visina;
            set
            {
                if (value > 0 && value < 300)
                    visina = value;
                else throw new Exception("Neispravna visina");
            }
        }
        public double Tezina
        {
            get => tezina;
            set
            {
                if (value > 0)
                    tezina = value;
                else if (Convert.ToString(value).Length == 0)
                    throw new Exception("Polje Težina mora biti popunjeno");

                else throw new Exception("Neispravna težina");
            }
        }
        public string FizickaAktivnost
        {
            get => fizickaAktivnost;
            set
            {
                if (value.Length == 0)
                    throw new Exception("Polje ne smije biti prazno");
                fizickaAktivnost = value;
            }
        }
        public double VrijednostHiperglikemije
        {
            get => vrijednostHiperglikemije;
            set
            {
                if (value > 0)
                    vrijednostHiperglikemije = value;
                else throw new Exception("Vrijednost mora biti veca od 0");
            }
        }
        public double VrijednostHipoglikemije
        {
            get => vrijednostHipoglikemije;
            set
            {
                if (value > 0)
                    vrijednostHipoglikemije = value;
                else throw new Exception("Vrijednost mora biti veca od 0");
            }
        }
        public double CiljaniNivoGlukoze
        {
            get => ciljaniNivoGlukoze;
            set
            {
                if (value > 0 && value > DonjaGranicaGlukoze && value < GornjaGranicaGlukoze)
                    ciljaniNivoGlukoze = value;
                else
                {
                    if (value == 0) throw new Exception("Vrijednost mora biti veca od 0");
                    else if (value < DonjaGranicaGlukoze) throw new Exception("Vrijednost ne smije biti manja od donje granice glukoze");
                    else if (value > GornjaGranicaGlukoze) throw new Exception("Vrijednost ne smije biti veća od gornje granice glukoze");
                }
            }
        }
        public double DonjaGranicaGlukoze
        {
            get => donjaGranicaGlukoze;
            set
            {
                if (value > 0 && value < GornjaGranicaGlukoze)
                    donjaGranicaGlukoze = value;
                else
                {
                    if (value == 0) throw new Exception("Vrijednost mora biti veca od 0");
                    else if (value > GornjaGranicaGlukoze) throw new Exception("Vrijednost ne smije biti veća od gornje granice glukoze");
                }
            }
        }
        public double GornjaGranicaGlukoze
        {
            get => gornjaGranicaGlukoze;
            set
            {
                if (value > 0 && value > DonjaGranicaGlukoze)
                    gornjaGranicaGlukoze = value;
                else
                {
                    if (value == 0) throw new Exception("Vrijednost mora biti veca od 0");
                    else if (value < DonjaGranicaGlukoze) throw new Exception("Vrijednost ne smije biti manja od donje granice glukoze");
                }
            }
        }

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
