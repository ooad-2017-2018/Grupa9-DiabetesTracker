namespace DiabetesTrackerRestAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Terapija")]
    public partial class Terapija
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Terapija()
        {
            Korisnik = new HashSet<Korisnik>();
        }

        public int Id { get; set; }

        public int Tip { get; set; }

        public int KorisnikId { get; set; }

        public int? Korisnik_Id { get; set; }

        [Required]
        [StringLength(1000)]
        public string Lijekovi { get; set; }

        [Required]
        [StringLength(1000)]
        public string DozaLijeka { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Korisnik> Korisnik { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }

        public virtual Korisnik Korisnik2 { get; set; }
    }
}
