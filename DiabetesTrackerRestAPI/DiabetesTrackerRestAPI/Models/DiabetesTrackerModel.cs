namespace DiabetesTrackerRestAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DiabetesTrackerModel : DbContext
    {
        public DiabetesTrackerModel()
            : base("name=DiabetesTrackerModel")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Dnevni_unos> Dnevni_unos { get; set; }
        public virtual DbSet<Doktor> Doktor { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<Nalaz> Nalaz { get; set; }
        public virtual DbSet<Namirnica> Namirnica { get; set; }
        public virtual DbSet<NamirnicaHranaPoveznica> NamirnicaHranaPoveznica { get; set; }
        public virtual DbSet<Podsjetnik> Podsjetnik { get; set; }
        public virtual DbSet<Terapija> Terapija { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Dnevni_unos>()
                .HasMany(e => e.Namirnica)
                .WithOptional(e => e.Dnevni_unos)
                .HasForeignKey(e => e.Hrana_Id);

            modelBuilder.Entity<Dnevni_unos>()
                .HasMany(e => e.Namirnica1)
                .WithOptional(e => e.Dnevni_unos1)
                .HasForeignKey(e => e.Hrana_Id1);

            modelBuilder.Entity<Dnevni_unos>()
                .HasMany(e => e.Namirnica2)
                .WithRequired(e => e.Dnevni_unos2)
                .HasForeignKey(e => e.HranaId);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Dnevni_unos)
                .WithOptional(e => e.Korisnik)
                .HasForeignKey(e => e.Korisnik_Id);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Dnevni_unos1)
                .WithOptional(e => e.Korisnik1)
                .HasForeignKey(e => e.Korisnik_Id1);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Dnevni_unos2)
                .WithOptional(e => e.Korisnik2)
                .HasForeignKey(e => e.KorisnikId1)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Nalaz)
                .WithOptional(e => e.Korisnik)
                .HasForeignKey(e => e.Korisnik_Id);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Nalaz1)
                .WithOptional(e => e.Korisnik1)
                .HasForeignKey(e => e.Korisnik_Id1);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Nalaz2)
                .WithRequired(e => e.Korisnik2)
                .HasForeignKey(e => e.KorisnikId);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Podsjetnik)
                .WithOptional(e => e.Korisnik)
                .HasForeignKey(e => e.Korisnik_Id);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Podsjetnik1)
                .WithOptional(e => e.Korisnik1)
                .HasForeignKey(e => e.Korisnik_Id1);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Podsjetnik2)
                .WithRequired(e => e.Korisnik2)
                .HasForeignKey(e => e.KorisnikId);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Terapija1)
                .WithOptional(e => e.Korisnik1)
                .HasForeignKey(e => e.Korisnik_Id);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Terapija2)
                .WithRequired(e => e.Korisnik2)
                .HasForeignKey(e => e.KorisnikId);

            modelBuilder.Entity<Terapija>()
                .HasMany(e => e.Korisnik)
                .WithOptional(e => e.Terapija)
                .HasForeignKey(e => e.Terapija1_Id);
        }
    }
}
