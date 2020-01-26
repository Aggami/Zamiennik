using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Dostep_Do_Danych
{
    public class ZamiennikKontekst : DbContext
    {

        public ZamiennikKontekst() : base("ZamiennikKontekst")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ZamiennikKontekst, Dostep_Do_Danych.Migrations.Configuration>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<ZamiennikKontekst>());
        }


        public DbSet<Kurs> Kursy { get; set; }
        public DbSet<Zamiennik_kursu> Zamienniki { get; set; }
        public DbSet<Propozycja_zamiennika> Propozycje { get; set; }
        public DbSet<Efekt_ksztalcenia> Efekty { get; set; }
        public DbSet<Plan_studiow> Plany_studiow { get; set; }
        public DbSet<Rok_akademicki> Lata_akademickie { get; set; }
        public DbSet<Kierunek_studiow> Kierunki{ get; set; }
        public DbSet<Wydzial> Wydzialy { get; set; }
        public DbSet<Grupa_kursow> Grupy_kursow { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Plan_studiow>()
                   .HasMany(p => p.Lata)
                   .WithMany()
                   .Map(cs =>
                   {
                       cs.MapLeftKey("IdPlanu");
                       cs.MapRightKey("IdRoku");
                       cs.ToTable("LataPlanowStudiow");
                   });

            modelBuilder.Entity<Kurs>()
                   .HasMany(k => k.Efekty)
                   .WithMany()
                   .Map(cs =>
                   {
                       cs.MapLeftKey("KodKursu");
                       cs.MapRightKey("SymbolEfektu");
                       cs.ToTable("EfektyKsztalceniaKursow");
                   });

            modelBuilder.Entity<Zamiennik_kursu>()
                   .HasMany(z => z.Kursy_skladowe)
                   .WithMany()
                   .Map(cs =>
                   {
                       cs.MapLeftKey("IdZamiennika");
                       cs.MapRightKey("KodKursuSkladowego");
                       cs.ToTable("KursySkladoweZamiennika");
                   }
                   );
        }


    }
}
