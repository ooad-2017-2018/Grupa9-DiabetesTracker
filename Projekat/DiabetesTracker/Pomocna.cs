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
                Username = x.Username,
                Spol = x.Spol,
                JMBG2 = x.JMBG1,
                DatumRodjenja = x.DatumRodjenja,
                TipDijabetesa = x.TipDijabetesa,
                Visina = x.Visina,
                Tezina = x.Tezina,
                FizickaAktivnost = x.FizickaAktivnost,
                VrijednostHiperglikemije = x.VrijednostHiperglikemije,
                VrijednostHipoglikemije = x.VrijednostHipoglikemije,
                CiljaniNivoGlukoze = x.CiljaniNivoGlukoze,
                GornjaGranicaGlukoze = x.GornjaGranicaGlukoze,
                DonjaGranicaGlukoze = x.DonjaGranicaGlukoze
            };            
            throw new Exception("Korisnik postoji");
            return korisnik;
        }

        public static async Task dodajKorisnika(Korisnik korisnik)
        {            
            Korisnik korisnik1 = new Korisnik
            {
                Ime = korisnik.Ime,
                Prezime = korisnik.Prezime,
                Username = korisnik.Username,
                Password = korisnik.Password,
                EMail = korisnik.EMail,
                Spol = korisnik.Spol,
                JMBG2 = korisnik.JMBG1,
                DatumRodjenja = korisnik.DatumRodjenja,
                TipDijabetesa = korisnik.TipDijabetesa,
                Visina = korisnik.Visina,
                Tezina = korisnik.Tezina,
                FizickaAktivnost = korisnik.FizickaAktivnost,
                VrijednostHiperglikemije = korisnik.VrijednostHiperglikemije,
                VrijednostHipoglikemije = korisnik.VrijednostHipoglikemije,
                CiljaniNivoGlukoze = korisnik.CiljaniNivoGlukoze,
                GornjaGranicaGlukoze = korisnik.GornjaGranicaGlukoze,
                DonjaGranicaGlukoze = korisnik.DonjaGranicaGlukoze,
                Tip = korisnik.Tip,
                Lijekovi = korisnik.Lijekovi,
                DozaLijeka=korisnik.DozaLijeka
            };
            IMobileServiceTable<Korisnik> tabelaKorisnika = App.MobileService.GetTable<Korisnik>();
            /*var polja = from a in tabelaKorisnika where a.Username == korisnik.Username select a;
            var lista = await polja.ToListAsync();
            if (lista.Count != 0) throw new Exception("Dati username nije slobodan");*/
            await tabelaKorisnika.InsertAsync(korisnik);
        }

        /*public static async Task<Korisnik> UcitajKorisnikaID(string id)
        {
            IMobileServiceTable<Korisnik> tabelaKorisnika = App.MobileService.GetTable<Korisnik>();
            var polja = from x in tabelaKorisnika
                        where x.Id == id
                        select x;
            var lista = await polja.ToListAsync();
            if (lista.Count != 1)
                throw new Exception("Ne postoji korisnik sa datim id-em");
            var k = lista[0];

            Korisnik korisnik = null;

            korisnik = new Korisnik
            {
                Id = k.Id,
                EMail = k.EMail,
                Ime = k.Ime,
                Prezime = k.Prezime,
                Password = k.Password,
                Username = k.Username
            };
            return korisnik;
        }*/

        public static async Task provjeriUsername(String username)
        {
            IMobileServiceTable<Korisnik> tabelaKorisnika = App.MobileService.GetTable<Korisnik>();
            var polja = from a in tabelaKorisnika where a.Username == username select a;
            var lista = await polja.ToListAsync();
            if (lista.Count != 0) throw new Exception("Dati username nije slobodan");
        }
    }
}