using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dostep_Do_Danych
{
    class Wyszukiwarka
    {
        private static ZamiennikKontekst db;

        public static List<Kurs> znajdzKurs(string fraza)
        {
            var kursy = (db.Kursy.Where(k => k.Nazwa_kursu.Contains(fraza) || k.Kod_kursu.Contains(fraza)));

            return kursy.ToList<Kurs>();
          //return db.Kursy.Select(k => k.Czy_egzamin);

        }
        
    }
}
