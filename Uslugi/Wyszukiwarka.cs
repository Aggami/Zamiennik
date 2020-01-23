using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dostep_Do_Danych;
using System.Data.Entity;

namespace Uslugi
{
    public class Wyszukiwarka
    {
        private static ZamiennikKontekst db = new ZamiennikKontekst();

        public static List<Kurs> ZnajdzKurs(string fraza)
        {
            fraza = fraza.ToLower();
            Repozytorium<Kurs> kursy = new Repozytorium <Kurs>(db);
            return kursy.ZnajdzPoPredykacie(k => k.Nazwa_kursu.ToLower().Contains(fraza) || k.Kod_kursu.ToLower().Contains(fraza));
        }
        /*
        public static List<Zamiennik_kursu> ZnajdzZamienniki(Kurs k)
        {
                       
        }
        */
    }
}
