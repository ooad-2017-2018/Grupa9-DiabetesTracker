namespace DiabetesTrackerAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Dnevni_unos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dnevni_unos()
        {
            Namirnicas = new HashSet<Namirnica>();
            Namirnicas1 = new HashSet<Namirnica>();
        }

        public int Id { get; set; }

        public DateTime Datum { get; set; }

        public int TipKategorije { get; set; }

        public int? KorisnikId { get; set; }

        public int? Tip { get; set; }

        public double? Vrijednost { get; set; }

        [Required]
        [StringLength(128)]
        public string Kolicina { get; set; }

        public int? Korisnik_Id { get; set; }

        public int? Korisnik_Id1 { get; set; }

        public int? KorisnikId1 { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }

        public virtual Korisnik Korisnik2 { get; set; }

        public virtual Korisnik Korisnik3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Namirnica> Namirnicas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Namirnica> Namirnicas1 { get; set; }
    }
}
