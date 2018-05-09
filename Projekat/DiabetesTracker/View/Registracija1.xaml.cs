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

        private async void dalje_Click(object sender, RoutedEventArgs e)
        {
            /*Korisnik obj = new Korisnik();
            obj.Ime = ImeTextBox.Text;
            obj.Prezime = PrezimeTextBox.Text;
            
            obj.EMail = EmailTextBox.Text;
            */

            var date = this.DatumRodjenja.Date.ToString();


            try
            {
                await Pomocna.provjeriUsername(UserNameIPasswordTextBox.Username);


                Korisnik k;
                if (muskiButton.IsChecked == true)
                {
                    string a = "";
                if (date[1] == '/')
                {
                    a += date[0]; //0
                }
                else
                {
                    a += date[0] + date[1];
                    int pom = Convert.ToInt32(a);
                    pom = pom - 87;
                    a = Convert.ToString(pom);
                }

                    string b = "";
                if (date[3] == '/')
                {
                    b += date[2]; //0
                }
                else if (date[4] == '/' && date[2] == '/')
                {
                    b += date[3]; //0
                }
                else if (date[4] == '/')
                {
                    b += date[2] + date[3];
                    int pom = Convert.ToInt32(b);
                    pom = pom - 87;
                    b = Convert.ToString(pom);


                }
                else
                {
                    b += date[3] + date[4];
                    int pom = Convert.ToInt32(b);
                    pom = pom - 87;
                    b = Convert.ToString(pom);
                }

                    string c = "";
                    int br = 0;
                    for (int i = 0; i < date.Length; i++)
                    {
                        if (date[i] == '/') br++;
                        if (br == 2)
                        {
                            for (int j = i + 1; j < i + 5; j++)
                            {
                                c += date[j];
                            }
                            break;
                        }
                    }

                    DateTime d = new DateTime(Convert.ToInt32(c), Convert.ToInt32(a), Convert.ToInt32(b));
                    k = new Korisnik
                    {
                        Ime = ImeTextBox.Text,
                        Prezime = PrezimeTextBox.Text,
                        Username = UserNameIPasswordTextBox.Username,
                        Password = UserNameIPasswordTextBox.Password,
                        PotvrdaPassworda = PotvrdaPasswordaTextBox.Password,
                        EMail = EmailTextBox.Text,
                        Spol = Spol.Muski,
                        DatumRodjenja = d
                    };
                    k.JMBG1 = JMBGTextBox.Text;
                    this.Frame.Navigate(typeof(Registracija2), k);
                }
                else if (zenskiButton.IsChecked == true)
                {

                string a = "";
                if (date[1] == '/')
                {
                    a += date[0]; //0
                }
                else
                {
                    a += date[0] + date[1];
                    int pom = Convert.ToInt32(a);
                    pom = pom - 87;
                    a = Convert.ToString(pom);
                }

                string b = "";
                if (date[3] == '/')
                {
                    b += date[2]; //0
                }
                else if (date[4] == '/' && date[2] == '/')
                {
                    b += date[3]; //0
                }
                else if (date[4] == '/')
                {
                    b += date[2] + date[3];
                    int pom = Convert.ToInt32(b);
                    pom = pom - 87;
                    b = Convert.ToString(pom);


                }
                else
                {
                    b += date[3] + date[4];
                    int pom = Convert.ToInt32(b);
                    pom = pom - 87;
                    b = Convert.ToString(pom);
                }

                string c = "";
                int br = 0;
                for (int i = 0; i < date.Length; i++)
                {
                    if (date[i] == '/') br++;
                    if (br == 2)
                    {
                        for (int j = i + 1; j < i + 5; j++)
                        {
                            c += date[j];
                        }
                        break;
                    }
                }

                DateTime d = new DateTime(Convert.ToInt32(c), Convert.ToInt32(a), Convert.ToInt32(b));
                    
                    k = new Korisnik
                    {
                        Ime = ImeTextBox.Text,
                        Prezime = PrezimeTextBox.Text,
                        Username = UserNameIPasswordTextBox.Username,
                        Password = UserNameIPasswordTextBox.Password,
                        PotvrdaPassworda = PotvrdaPasswordaTextBox.Password,
                        EMail = EmailTextBox.Text,
                        Spol = Spol.Zenski,                        
                        DatumRodjenja = d
                    };
                    k.JMBG1 = JMBGTextBox.Text;
                    this.Frame.Navigate(typeof(Registracija2), k);
                }
           }
            catch(Exception izuzetak)
            {
                await(new MessageDialog(izuzetak.Message)).ShowAsync();
            }
        }
    }
}