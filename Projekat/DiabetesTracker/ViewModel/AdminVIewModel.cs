using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesTracker.ViewModel
{
    class AdminVIewModel
    {
        Admin admin { get; set; }
        public AdminViewModel(Admin admin)
        {
            this.admin = admin;
        }
        public void getAdmin() { }
        public void dodajNamirnicu() { }
        public void dodajKorisnika() { }
    }
}
