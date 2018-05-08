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

using Windows.UI.Popups;
using DiabetesTracker.Model;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DiabetesTracker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {

        public BlankPage1()
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

        private void dalje_Click(object sender, RoutedEventArgs e)
        {
            Korisnik obj = new Korisnik();
            obj.Ime = ImeTextBox.Text;
            obj.Prezime = PrezimeTextBox.Text;

            obj.EMail = EmailTextBox.Text;
            if (muskiButton.IsChecked == true)
            {
                obj.Spol = Spol.Muski;
            }
            else if(zenskiButton.IsChecked == true)
            {
                obj.Spol = Spol.Muski;
            }

            this.Frame.Navigate(typeof(Registracija2));
        }

        public static void ucitajKorisnika(string username, string password)
        {
            IMobileServiceTable<Korisnik> tabelaKorisnik = App.MobileService.GetTable<Korisnik>();
            var polja = from a in tabelaKorisnik where a.Username == username select a;
            var lista = polja.ToListAsync();
        }
    }
}