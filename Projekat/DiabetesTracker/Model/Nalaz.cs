using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace DiabetesTracker.Model
{
    public class Nalaz
    {
        String nazivFajla;
        BitmapImage slika;

        public string NazivFajla { get => nazivFajla; set => nazivFajla = value; }
        public BitmapImage Slika { get => slika; set => slika = value; }
    }
}
