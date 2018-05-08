using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiabetesTracker.Model;
namespace DiabetesTracker.ViewModel
{
    public class KorisnikViewModel
    {
        Korisnik korisnik;
        public KorisnikViewModel(Korisnik korisnik)
        {
            this.korisnik = korisnik;
        }
        public void getKorisnik() { }
        public void setKorisnik() { }
        //public void dodajDnevniUnos(DnevniUnos dnevniUnos) { }
        public void dodajTerapiju(Terapija terapija) { }
        public void kreirajPodsjetnik() { }
        public void pregledajNalaz() { }
        public void pregledajKalendar() { }
        public void registracija() { }
        public void prijava() { }
        public void pregledajDijagram() { }
        public void validacija() { }
    }
}
