namespace DiabetesTrackerRestAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Korisnik")]
    public partial class Korisnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Korisnik()
        {
            Dnevni_unos = new HashSet<Dnevni_unos>();
            Dnevni_unos1 = new HashSet<Dnevni_unos>();
            Dnevni_unos2 = new HashSet<Dnevni_unos>();
            Nalaz = new HashSet<Nalaz>();
            Nalaz1 = new HashSet<Nalaz>();
            Nalaz2 = new HashSet<Nalaz>();
            Podsjetnik = new HashSet<Podsjetnik>();
            Podsjetnik1 = new HashSet<Podsjetnik>();
            Podsjetnik2 = new HashSet<Podsjetnik>();
            Terapija1 = new HashSet<Terapija>();
            Terapija2 = new HashSet<Terapija>();
        }

        public int Id { get; set; }

        [Required]
        public string TipDijabetesa { get; set; }

        public double Visina { get; set; }

        public double Tezina { get; set; }

        [Required]
        public string FizickaAktivnost { get; set; }

        public double VrijednostHiperglikemije { get; set; }

        public double VrijednostHipoglikemije { get; set; }

        public double CiljaniNivoGlukoze { get; set; }

        public double DonjaGranicaGlukoze { get; set; }

        public double GornjaGranicaGlukoze { get; set; }

        public int Tip { get; set; }

        public string Lijekovi { get; set; }

        public string DozaLijeka { get; set; }

        public int Spol { get; set; }

        [Required]
        public string Ime { get; set; }

        [Required]
        public string Prezime { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string PotvrdaPassworda { get; set; }

        [Required]
        public string EMail { get; set; }

        [Required]
        [StringLength(13)]
        public string JMBG1 { get; set; }

        public int Spol1 { get; set; }

        public DateTime DatumRodjenja { get; set; }

        public int? Terapija1_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dnevni_unos> Dnevni_unos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dnevni_unos> Dnevni_unos1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dnevni_unos> Dnevni_unos2 { get; set; }

        public virtual Terapija Terapija { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nalaz> Nalaz { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nalaz> Nalaz1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nalaz> Nalaz2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Podsjetnik> Podsjetnik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Podsjetnik> Podsjetnik1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Podsjetnik> Podsjetnik2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Terapija> Terapija1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Terapija> Terapija2 { get; set; }
    }
}
