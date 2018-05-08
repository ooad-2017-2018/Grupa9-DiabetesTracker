using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Windows.UI.Popups;
using DiabetesTracker.Model;
using Microsoft.WindowsAzure.MobileServices;

namespace DiabetesTracker
{
    public class Pomocna
    {
        public static async Task<Korisnik> ucitajKorisnika(string username, string password = "")
        {
            IMobileServiceTable<Korisnik> tabelaKorisnik = App.MobileService.GetTable<Korisnik>();
            var polja = from a in tabelaKorisnik where a.Username == username select a;
            var lista = await polja.ToListAsync();
            if (lista.Count != 1)
                throw new Exception("Korisnik ne postoji");
            var x = lista[0];
            if (x.Password != password && password != "")
                throw new Exception("Pogresan password");
            Korisnik korisnik = null;

            korisnik = new Korisnik
            {
                Id = x.Id,
                EMail = x.EMail,
                Ime = x.Ime,
                Prezime = x.Prezime,
                Password = x.Password,
                Username = x.Username
            };
            return korisnik;
        }

        public static async Task dodajKorisnika(Korisnik korisnik)
        {
            Korisnik korisnik1 = new Korisnik
            {
                Ime = korisnik.Ime,
                Prezime = korisnik.Prezime,
                Password = korisnik.Password,
                Username = korisnik.Username,
                EMail = korisnik.EMail
            };
            IMobileServiceTable<Korisnik> tabelaKorisnika = App.MobileService.GetTable<Korisnik>();
            var polja = from a in tabelaKorisnika where a.Username == korisnik.Username select a;
            var lista = await polja.ToListAsync();
            if (lista.Count != 0) throw new Exception("Dati username nije slobodan");
            await tabelaKorisnika.InsertAsync(korisnik1);
        }
    }
}