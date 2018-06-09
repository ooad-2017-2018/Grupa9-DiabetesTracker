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

        //refactoring:remove setting method
        public string NazivFajla { get => nazivFajla; }
        public BitmapImage Slika { get => slika; }
    }
}
