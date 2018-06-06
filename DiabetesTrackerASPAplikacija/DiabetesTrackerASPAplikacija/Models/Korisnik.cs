using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesTrackerASPAplikacija.Models
{
    public class Korisnik:Osoba
    {
        String tipDijabetesa;
        Double visina;
        Double tezina;
        String fizickaAktivnost;
        Double vrijednostHiperglikemije;
        Double vrijednostHipoglikemije;
        Double ciljaniNivoGlukoze;
        Double donjaGranicaGlukoze;
        Double gornjaGranicaGlukoze;
        List<Dnevni_unos> dnevniUnosi;
        List<Nalaz> nalazi;
        List<Podsjetnik> podsjetnici;
        //Terapija terapija;
        TipTerapije tip;
        String lijekovi;
        String dozaLijeka;

        /*
        public String Lijekovi
        {
            get => lijekovi;
            set
            {
                if (String.IsNullOrEmpty(value)) throw new Exception("Morate unijeti barem jedan lijek");
                lijekovi = value;
            }
        }
        public String DozaLijeka
        {
            get => dozaLijeka;
            set
            {                
                if (String.IsNullOrEmpty(value)) throw new Exception("Morate unijeti barem jednu dozu lijeka");
                else dozaLijeka = value;
            }
        }

        public TipTerapije Tip { get => tip; set => tip = value; }

        public string TipDijabetesa
        {
            get => tipDijabetesa;
            set
            {
                if (value.Length == 0)
                    throw new Exception("Polje ne smije biti prazno");
                tipDijabetesa = value;
            }
        }
        public double Visina
        {
            get => visina;
            set
            {
                if (value > 0 && value < 300)
                    visina = value;
                else throw new Exception("Neispravna visina");
            }
        }
        public double Tezina
        {
            get => tezina;
            set
            {
                if (value > 0)
                    tezina = value;
                else if (Convert.ToString(value).Length == 0)
                    throw new Exception("Polje Težina mora biti popunjeno");

                else throw new Exception("Neispravna težina");
            }
        }
        public string FizickaAktivnost
        {
            get => fizickaAktivnost;
            set
            {
                if (value.Length == 0)
                    throw new Exception("Polje ne smije biti prazno");
                fizickaAktivnost = value;
            }
        }
        public double VrijednostHiperglikemije
        {
            get => vrijednostHiperglikemije;
            set
            {
                if (value > 0)
                    vrijednostHiperglikemije = value;
                else throw new Exception("Vrijednost mora biti veca od 0");
            }
            
        }
        public double VrijednostHipoglikemije
        {
            get => vrijednostHipoglikemije;
            set
            {
                if (value > 0)
                    vrijednostHipoglikemije = value;
                else throw new Exception("Vrijednost mora biti veca od 0");
            }
            
        }
        public double CiljaniNivoGlukoze
        {
            get => ciljaniNivoGlukoze;
            
            set
            {
                if (value == 0) throw new Exception("Vrijednost mora biti veca od ");
                else ciljaniNivoGlukoze = value;
            }
        }
        public double DonjaGranicaGlukoze
        {
            get => donjaGranicaGlukoze;
            
            set
            {
                if (value == 0) throw new Exception("Vrijednost mora biti veca od 0");
                else donjaGranicaGlukoze = value;
            }
        }
        public double GornjaGranicaGlukoze
        {
            get => gornjaGranicaGlukoze;
           
            set
            {
                if (value == 0) throw new Exception("Vrijednost mora biti veca od 0");
                else gornjaGranicaGlukoze = value;
            }
        }
               */


        
        public List<Dnevni_unos> DnevniUnosi { get => dnevniUnosi; set => dnevniUnosi = value; }
        public List<Nalaz> Nalazi { get => nalazi; set => nalazi = value; }
        //public Terapija Terapija1 { get => terapija; set => terapija = value; }

        public List<Podsjetnik> Podsjetnici { get => podsjetnici; set => podsjetnici = value; }

        [Required]
        [DisplayName("Tip dijabetesa")]
        public string TipDijabetesa { get => tipDijabetesa; set => tipDijabetesa = value; }
        [Required]
        public double Visina { get => visina; set => visina = value; }
        [Required]
        public double Tezina { get => tezina; set => tezina = value; }
        [Required]
        [DisplayName("Fizicka aktivnost")]
        public string FizickaAktivnost { get => fizickaAktivnost; set => fizickaAktivnost = value; }
        [Required]
        [DisplayName("Vrijednost hiperglikemije")]
        [Range(11,50,ErrorMessage ="Vrijednost hiperglikemije mora biti veca ili jednaka 11 mmol/L")]
        public double VrijednostHiperglikemije { get => vrijednostHiperglikemije; set => vrijednostHiperglikemije = value; }
        [Required]
        [DisplayName("Vrijednost hipoglikemije")]
        [Range(0, 4, ErrorMessage = "Vrijednost hipoglikemije mora biti u granicama izmedju 0.1 i 4 mmol/L")]
        public double VrijednostHipoglikemije { get => vrijednostHipoglikemije; set => vrijednostHipoglikemije = value; }
        [Required]
        [DisplayName("Ciljani nivo glukoze")]
        [Range(0,50, ErrorMessage = "Vrijednost ciljanog nivoa glukoze mora biti veca od 0")]
        public double CiljaniNivoGlukoze { get => ciljaniNivoGlukoze; set => ciljaniNivoGlukoze = value; }
        [Required]
        [DisplayName("Donja granica glukoze")]
        [Range(0, 50, ErrorMessage = "Vrijednost donje granice glukoze mora biti veca od 0")]
        public double DonjaGranicaGlukoze { get => donjaGranicaGlukoze; set => donjaGranicaGlukoze = value; }
        [Required]
        [DisplayName("Gornja granica glukoze")]
        [Range(0, 50, ErrorMessage = "Vrijednost gornje granice glukoze mora biti veca od 0")]
        public double GornjaGranicaGlukoze { get => gornjaGranicaGlukoze; set => gornjaGranicaGlukoze = value; }
        [Required]
        public TipTerapije Tip { get => tip; set => tip = value; }
        public string Lijekovi { get => lijekovi; set => lijekovi = value; }
        public string DozaLijeka { get => dozaLijeka; set => dozaLijeka = value; }


        public virtual ICollection<Dnevni_unos> Dnevni_Unos { get; set; }
        public virtual ICollection<Nalaz> Nalaz { get; set; }
        public virtual ICollection<Podsjetnik> Podjestnik { get; set; }
        public virtual ICollection<Terapija> Terapija { get; set; }
        public virtual ICollection<UnosHrane> UnosHrane { get; set; }
        public virtual ICollection<UnosNijeHrana> UnosNijeHrana { get; set; }
        

        public void dodajDnevniUnos(Dnevni_unos dnevniUnos)
        {
            dnevniUnosi.Add(dnevniUnos);
        }

        public void dodajNalaz(Nalaz nalaz)
        {
            nalazi.Add(nalaz);
        }








        public void dodajPodsjetnik(Podsjetnik podsjetnik)
        {
            podsjetnici.Add(podsjetnik);
        }
    }
}
