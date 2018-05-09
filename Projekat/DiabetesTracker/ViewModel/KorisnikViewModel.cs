using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiabetesTracker.Model;
using System.Windows.Input;

using System.ComponentModel;

namespace DiabetesTracker.ViewModel
{
    public class KorisnikViewModel:INotifyPropertyChanged
    {
        String potvrdaPassworda;

        Korisnik korisnik;

        public string PotvrdaPassworda { get => potvrdaPassworda; set => potvrdaPassworda = value; }

        public KorisnikViewModel(Korisnik korisnik)
        {
            this.korisnik = korisnik;
            DodajKorisnika = new RelayCommand(new Action(async () => await this.spremanjeKorisnika(null)));
        }
        public void getKorisnik() { }
        public void setKorisnik() { }
        public void dodajDnevniUnos(Dnevni_unos dnevniUnos) { }
        public void dodajTerapiju(Terapija terapija) { }
        public void kreirajPodsjetnik() { }
        public void pregledajNalaz() { }
        public void pregledajKalendar() { }
        public void registracija() { }
        public void prijava() { }
        public void pregledajDijagram() { }
        public void validacija() { }
        public ICommand DodajKorisnika { get; set; }
        
        public async Task spremanjeKorisnika(object parameter)
        {
            if (this.korisnik.Password != this.PotvrdaPassworda)
            {
                await (new Windows.UI.Popups.MessageDialog("Passwordi nisu isti")).ShowAsync();
            }
            else
            {
                try
                {
                    //doraditi ovaj dio
                    //!!!!!!

                    if (this.korisnik.Ime == null || korisnik.Prezime == null || korisnik.Password == null || korisnik.Username == null || korisnik.EMail == null)
                        throw new Exception("Nijedno polje ne smije biti prazno");
                    Korisnik kor = new Korisnik
                    {
                        Ime = korisnik.Ime,
                        Prezime = korisnik.Prezime,
                        Password = korisnik.Password,
                        Username = korisnik.Username,
                        EMail = korisnik.EMail

                    };
                    await Pomocna.dodajKorisnika(kor);



                    await (new Windows.UI.Popups.MessageDialog("Registracija je uspjela")).ShowAsync();
                }

                catch (Exception ex)
                {
                    await (new Windows.UI.Popups.MessageDialog(ex.Message)).ShowAsync();
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
