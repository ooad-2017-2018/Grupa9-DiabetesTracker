using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI;
using Windows.UI.ViewManagement;
using DiabetesTracker.Model;
using Windows.UI.Popups;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DiabetesTracker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Registracija2 : Page
    {
        List<string> tipDijabetesa = new List<string>();
        List<string> fizickaAktivnost = new List<string>();

        

        Korisnik korisnik;
        public Registracija2()
        {


            tipDijabetesa.Add("Tip 1");
            tipDijabetesa.Add("Tip 2");
            tipDijabetesa.Add("Gestacijski dijabetes");

            fizickaAktivnost.Add("Malo ili nimalo");
            fizickaAktivnost.Add("1-3 dana sedmično");
            fizickaAktivnost.Add("3-5 dana sedmično");
            fizickaAktivnost.Add("6-7 dana sedmično");

            this.InitializeComponent();



            setTitleBarBackground();
        }

        private void setTitleBarBackground()
        {
            //Instanca Title Bar-a
            var titleBar = ApplicationView.GetForCurrentView().TitleBar;

            //postavi boju
            titleBar.BackgroundColor = Color.FromArgb(0, 97, 137, 197);

            //postavi boju dugmadi
            titleBar.ButtonBackgroundColor = Color.FromArgb(0, 97, 137, 197);

            //promjena naziva prozora (TitleBar)
            ApplicationView appView = ApplicationView.GetForCurrentView();
            appView.Title = "Registracija";
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                korisnik.TipDijabetesa = TipDijabetesaBox.SelectedItem.ToString();
                korisnik.Visina = Convert.ToDouble(VisinaBox.Text);
                korisnik.Tezina = Convert.ToDouble(TezinaBox.Text);
                korisnik.FizickaAktivnost = FizickaAktivnostBox.SelectedItem.ToString();
                this.Frame.Navigate(typeof(Terapija), korisnik);  
            }
            catch(Exception izuzetak)
            {
                if(VisinaBox.Text.Length == 0 || TezinaBox.Text.Length == 0) await (new MessageDialog("Morate popuniti sva polja")).ShowAsync();
                else if (izuzetak.Message.Equals("Object reference not set to an instance of an object.")) await (new MessageDialog("Morate odabrati opciju iz padajućeg menija")).ShowAsync();
                //else if (izuzetak.Message.Equals("Input string was not in a correct format.")) 
                else await (new MessageDialog(izuzetak.Message)).ShowAsync();
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            korisnik = e.Parameter as Korisnik;
        }
    }
}
