namespace DiabetesTrackerAPI.Models
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
            Dnevni_unos3 = new HashSet<Dnevni_unos>();
            Nalazs = new HashSet<Nalaz>();
            Nalazs1 = new HashSet<Nalaz>();
            Nalazs2 = new HashSet<Nalaz>();
            Podsjetniks = new HashSet<Podsjetnik>();
            Podsjetniks1 = new HashSet<Podsjetnik>();
            Podsjetniks2 = new HashSet<Podsjetnik>();
            Terapijas = new HashSet<Terapija>();
            Terapijas1 = new HashSet<Terapija>();
            UnosHranes = new HashSet<UnosHrane>();
            UnosNijeHranas = new HashSet<UnosNijeHrana>();
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dnevni_unos> Dnevni_unos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dnevni_unos> Dnevni_unos1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dnevni_unos> Dnevni_unos2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dnevni_unos> Dnevni_unos3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nalaz> Nalazs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nalaz> Nalazs1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nalaz> Nalazs2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Podsjetnik> Podsjetniks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Podsjetnik> Podsjetniks1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Podsjetnik> Podsjetniks2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Terapija> Terapijas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Terapija> Terapijas1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnosHrane> UnosHranes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnosNijeHrana> UnosNijeHranas { get; set; }
    }
}
