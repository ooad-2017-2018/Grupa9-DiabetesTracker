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
using Windows.UI.ViewManagement;
using Windows.UI;

using Windows.UI.Popups;
using DiabetesTracker.Model;
using Microsoft.WindowsAzure.MobileServices;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DiabetesTracker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        IMobileServiceTable<Korisnik> tabelaKorisnik = App.MobileService.GetTable<Korisnik>();

        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            setTitleBarBackground();
        }

        private void setTitleBarBackground()
        {
            //Instanca Title Bar-a
            var titleBar = ApplicationView.GetForCurrentView().TitleBar;

            //postavi boju
            titleBar.BackgroundColor = Color.FromArgb(0, 97, 137, 197);

            //postavi boju dugmadi
            titleBar.ButtonBackgroundColor = Color.FromArgb(0,97,137,197);

            //promjena naziva prozora (TitleBar)
            ApplicationView appView = ApplicationView.GetForCurrentView();
            appView.Title = "Prijava";
        }

        //iako se nakon pritska na dugme prijava ne prelazi na forme za registraciju, ovu funkcionalnost smo implementirali samo kako bi se sve forme mogle prelistati nakon pokretanja UWP-a
        private void Prijava_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Korisnik obj = new Korisnik();
            }
            catch (Exception ex)
            {
                MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                msgDialogError.ShowAsync();
            }
        }

        private void registerButtonHyperlink_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage1));
        }
    }
}
