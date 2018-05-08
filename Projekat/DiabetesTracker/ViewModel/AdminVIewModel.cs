using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiabetesTracker.Model;
namespace DiabetesTracker.ViewModel
{
    class AdminVIewModel
    {
        Admin admin { get; set; }
        public AdminVIewModel(Admin admin)
        {
            this.admin = admin;
        }
        public void getAdmin() { }
        public void dodajNamirnicu() { }
        public void dodajKorisnika() { }
    }
}
