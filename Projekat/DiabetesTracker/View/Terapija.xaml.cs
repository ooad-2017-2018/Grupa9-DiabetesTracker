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
    public sealed partial class Terapija : Page
    {

        Korisnik korisnik;
        public Terapija()
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

        private async void Dalje1_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (IIRadioButton.IsChecked == true)
                {
                    korisnik.Tip = TipTerapije.InzulinskeInjekcije;
                    {
                        string s = TerapijaKontrola.Naziv;                        
                        korisnik.Lijekovi =TerapijaKontrola.Naziv;
                        korisnik.DozaLijeka = DozaLijeka.Text;
                    }
                    /*{
                        string s = DozaLijeka.Text;
                        List<Double> s1 = new List<Double>();
                        string s2 = "";
                        for (int i = 0; i < s.Length; i++)
                        {
                            while (i < s.Length && s[i] != ',')
                            {
                                s2 += s[i];
                                i++;
                            }

                            if (i < s.Length && s[i] == ',')
                            {
                                s1.Add(Convert.ToDouble(s2));
                                s2 = "";
                            }
                        }
                        korisnik.DozaLijeka = s1;
                    }*/
                    this.Frame.Navigate(typeof(NivoGlukoze), korisnik);
                }
                else if (NITRadioButton.IsChecked == true)
                {
                    korisnik.Tip = TipTerapije.Neinzulinska;
                    korisnik.Lijekovi = TerapijaKontrola.Naziv;
                    korisnik.DozaLijeka = DozaLijeka.Text;
                    /*{
                        string s = TerapijaKontrola.Naziv;
                        List<String> s1 = new List<String>();
                        string s2 = "";
                        for (int i = 0; i < s.Length; i++)
                        {
                            while (i < s.Length && s[i] != ',')
                            {
                                s2 += s[i];
                                i++;
                            }

                            if (i < s.Length && s[i] == ',')
                            {
                                s1.Add(s2);
                                s2 = "";
                            }
                        }
                        korisnik.Lijekovi = s1;
                    }
                    {
                        string s = DozaLijeka.Text;
                        List<Double> s1 = new List<Double>();
                        string s2 = "";
                        for (int i = 0; i < s.Length; i++)
                        {
                            while (i < s.Length && s[i] != ',')
                            {
                                s2 += s[i];
                                i++;
                            }

                            if (i < s.Length && s[i] == ',')
                            {
                                s1.Add(Convert.ToDouble(s2));
                                s2 = "";
                            }
                        }
                        korisnik.DozaLijeka = s1;
                    }*/
                    this.Frame.Navigate(typeof(NivoGlukoze), korisnik);
                }
                else if (IPRadioButton.IsChecked == true)
                {
                    korisnik.Tip = TipTerapije.InzulinskaPumpa;
                    korisnik.Lijekovi = TerapijaKontrola.Naziv;
                    korisnik.DozaLijeka = DozaLijeka.Text;
                    /*{
                        string s = TerapijaKontrola.Naziv;
                        List<String> s1 = new List<String>();
                        string s2 = "";
                        for (int i = 0; i < s.Length; i++)
                        {
                            while (i<s.Length && s[i] != ',')
                            {
                                s2 += s[i];
                                i++;
                            }

                            if (i < s.Length && s[i] == ',')
                            {
                                s1.Add(s2);
                                s2 = "";
                            }
                        }
                        korisnik.Lijekovi = s1;
                    }
                    {
                        string s = DozaLijeka.Text;
                        List<Double> s1 = new List<Double>();
                        string s2 = "";
                        for (int i = 0; i < s.Length; i++)
                        {
                            while (i < s.Length && s[i] != ',')
                            {
                                s2 += s[i];
                                i++;
                            }

                            if (i < s.Length && s[i] == ',')
                            {
                                s1.Add(Convert.ToDouble(s2));
                                s2 = "";
                            }
                        }
                        korisnik.DozaLijeka = s1;
                    }*/
                    this.Frame.Navigate(typeof(NivoGlukoze), korisnik);
                }
            }
            catch(Exception izuzetak)
            {

                if(DozaLijeka.Text.Length == 0) await (new MessageDialog("Morate popuniti sva polja")).ShowAsync();
                else if (izuzetak.Message.Equals("Input string was not in a correct format.")) await (new MessageDialog("Morate popuniti sva polja")).ShowAsync();
                else await (new MessageDialog(izuzetak.Message)).ShowAsync();
            }
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void TerapijaKontrola_Loaded(object sender, RoutedEventArgs e)
        {

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            korisnik = e.Parameter as Korisnik;
        }
    }
}
