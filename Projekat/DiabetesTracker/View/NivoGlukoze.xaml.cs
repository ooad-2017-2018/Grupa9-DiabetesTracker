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
    public sealed partial class NivoGlukoze : Page
    {
        Korisnik korisnik;
        public NivoGlukoze()
        {
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

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            korisnik = e.Parameter as Korisnik;
        }

        private async void Dugme_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                korisnik.DonjaGranicaGlukoze = Convert.ToDouble(DonjaBox.Text);
                korisnik.CiljaniNivoGlukoze = Convert.ToDouble(CiljaniBox.Text);
                korisnik.GornjaGranicaGlukoze = Convert.ToDouble(GornjaBox.Text);
                korisnik.VrijednostHipoglikemije = Convert.ToDouble(HipoBox.Text);
                korisnik.VrijednostHiperglikemije = Convert.ToDouble(HiperBox.Text);                
            }
            catch(Exception izuzetak)
            {
                if (izuzetak.Message.Equals("Input string was not in a correct format.")) await (new MessageDialog("Morate popuniti sva polja")).ShowAsync();
                else await (new MessageDialog(izuzetak.Message)).ShowAsync();
            }
            try
            {
                await Pomocna.dodajKorisnika(korisnik);
                Application.Current.Exit();
            }
            catch(Exception izuzetak)
            {
                await (new MessageDialog(izuzetak.Message)).ShowAsync();
            }
        }
    }
}
