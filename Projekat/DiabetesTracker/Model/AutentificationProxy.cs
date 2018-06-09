using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesTracker.Model
{
    public class AutentificationProxy
    {

        //1. ISubject interfejs-Zajednički interfejs za Proxy i RealSubject objekat
        public interface ISubject
        {
            string Request();
        }

        //2. Subject klasa-Implementira stvarni interfejs
        private class Subject
        {
            public string Request()
            {
                return "Operacija iz Subject klase " + " Koristiti paterne u dizajnu\n";
            }
        }


        //3. ProtectionProxy- Implementira kontrolu prava pristupa i pristup stvarnom objektu
        public class ProtectionProxy : ISubject
        {
            // Autentifikacijski proxy prije prosljeđivanja pristupa stvarnom objektom prvo pita za password
            Subject subject;
            String password;

            public String Password {set => password = value; }


            /*private async Task<List<string>> ucitajPassworde()
            {
                List<Korisnik> listaKorisnika = (await Pomocna.dajPassworde());
                foreach (Korisnik k in listaKorisnika)
                {
                    password.Add(k.Password);
                }
                return password;
            }*/
            // kontrola pristupa stvarnom objektu
            public string Authenticate(string klijentPassword)
            {
                
                                  
                    if (klijentPassword!="" && klijentPassword == password)

                    {
                        subject = new Subject(); // instancira se stvarni objekat
                        subject.Request();
                        throw new Exception("Autentikacija izvršena-Omogućen pristup");
                    }
                
                throw new Exception("Nije dobar password-Onemogućen pristup");
            }

            // pristup stvarnom objektu
            public string Request()
            {
                if (subject == null)
                    return "Za pristup stvarnom objektu potrebno je prvo izvršiti autentifikaciju ";
                else return "Pristup stvarnom objektu " + subject.Request();
            }
        }

    }
}