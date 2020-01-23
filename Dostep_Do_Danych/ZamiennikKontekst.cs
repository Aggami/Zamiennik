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
            Database.SetInitializer<ZamiennikKontekst>(new DropCreateDatabaseIfModelChanges<ZamiennikKontekst>());
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
        
    }
}
