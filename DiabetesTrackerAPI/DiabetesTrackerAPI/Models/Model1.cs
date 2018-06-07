namespace DiabetesTrackerAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Dnevni_unos> Dnevni_unos { get; set; }
        public virtual DbSet<Doktor> Doktors { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<Nalaz> Nalazs { get; set; }
        public virtual DbSet<Namirnica> Namirnicas { get; set; }
        public virtual DbSet<NamirnicaDodatno> NamirnicaDodatnoes { get; set; }
        public virtual DbSet<NamirnicaHranaPoveznica> NamirnicaHranaPoveznicas { get; set; }
        public virtual DbSet<Podsjetnik> Podsjetniks { get; set; }
        public virtual DbSet<Terapija> Terapijas { get; set; }
        public virtual DbSet<UnosHrane> UnosHranes { get; set; }
        public virtual DbSet<UnosNijeHrana> UnosNijeHranas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Dnevni_unos>()
                .HasMany(e => e.Namirnicas)
                .WithOptional(e => e.Dnevni_unos)
                .HasForeignKey(e => e.Hrana_Id1);

            modelBuilder.Entity<Dnevni_unos>()
                .HasMany(e => e.Namirnicas1)
                .WithOptional(e => e.Dnevni_unos1)
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
                .HasForeignKey(e => e.KorisnikId);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Dnevni_unos3)
                .WithOptional(e => e.Korisnik3)
                .HasForeignKey(e => e.KorisnikId1);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Nalazs)
                .WithOptional(e => e.Korisnik)
                .HasForeignKey(e => e.Korisnik_Id);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Nalazs1)
                .WithOptional(e => e.Korisnik1)
                .HasForeignKey(e => e.Korisnik_Id1);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Nalazs2)
                .WithRequired(e => e.Korisnik2)
                .HasForeignKey(e => e.KorisnikId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Podsjetniks)
                .WithOptional(e => e.Korisnik)
                .HasForeignKey(e => e.Korisnik_Id);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Podsjetniks1)
                .WithOptional(e => e.Korisnik1)
                .HasForeignKey(e => e.Korisnik_Id1);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Podsjetniks2)
                .WithRequired(e => e.Korisnik2)
                .HasForeignKey(e => e.KorisnikId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Terapijas)
                .WithOptional(e => e.Korisnik)
                .HasForeignKey(e => e.Korisnik_Id);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Terapijas1)
                .WithRequired(e => e.Korisnik1)
                .HasForeignKey(e => e.KorisnikId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.UnosHranes)
                .WithRequired(e => e.Korisnik)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.UnosNijeHranas)
                .WithRequired(e => e.Korisnik)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UnosHrane>()
                .HasMany(e => e.Namirnicas)
                .WithRequired(e => e.UnosHrane)
                .WillCascadeOnDelete(false);
        }
    }
}
