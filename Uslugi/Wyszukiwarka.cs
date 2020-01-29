using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dostep_Do_Danych;
using System.Data.Entity;

namespace Uslugi
{
    /// <summary>
    /// Klasa wyszukujaca kursy z bazy danych
    /// </summary>
    public class Wyszukiwarka
    {
        /// <summary>
        /// Kontekst bazy danych, wykorzystywany do tworzenia repozytoriow
        /// </summary>
        private static ZamiennikKontekst db = new ZamiennikKontekst();

        /// <summary>
        /// Repozytorium kursow 
        /// </summary>
        private static RepozytoriumKurs kursy = new RepozytoriumKurs(db);

        /// <summary>
        /// Repozytorium zamiennikow kursow
        /// </summary>
        private static Repozytorium<Zamiennik_kursu> zamiennikiRep = new Repozytorium<Zamiennik_kursu>(db);

        /// <summary>
        /// Metoda wyszukujaca kursy zawierajace szukana fraze w swoim kodzie kursu/nazwie.
        /// </summary>
        /// <param name="fraza">Szukana fraza</param>
        /// <returns>Lista kursow zawierajacych fraze</returns>
        public static List<Kurs> ZnajdzKurs(string fraza)
        {
            fraza = fraza.ToLower();
            return kursy.ZnajdzPoPredykacie(k => k.Nazwa_kursu.ToLower().Contains(fraza) || k.Kod_kursu.ToLower().Contains(fraza));
        }
        
        /// <summary>
        /// Metoda zwracajaca Zamienniki Kursow dla danego kursu
        /// </summary>
        /// <param name="kurs">Kurs, dla ktorego szukamy zamiennikow</param>
        /// <returns>Lista zamiennikow kursu</returns>
        public static List<Zamiennik_kursu> ZnajdzZamienniki(Kurs kurs)
        {
            return zamiennikiRep.ZnajdzPoPredykacie(z => z.Kurs_zastepowany == kurs);
        }
        

    }
}
