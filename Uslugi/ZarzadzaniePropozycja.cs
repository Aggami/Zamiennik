using Dostep_Do_Danych;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uslugi
{
    class ZarzadzaniePropozycja
    {
        private static ZamiennikKontekst db = new ZamiennikKontekst();
        private static Repozytorium<Propozycja_zamiennika> propozycjeRep = new Repozytorium<Propozycja_zamiennika>(db);

        public static void zaakceptujPropozycje(Propozycja_zamiennika propozycja, string komentarz)
        {
            propozycja.Komentarz_Opiniodawcy = komentarz;
            propozycja.Status = Status_propozycji.Zweryfikowana;
            propozycjeRep.Edytuj(propozycja);
            db.SaveChanges();

        }

        public static void odrzucPropozycje(Propozycja_zamiennika propozycja, string komentarz)
        {
            propozycja.Komentarz_Opiniodawcy = komentarz;
            propozycja.Status = Status_propozycji.Odrzucona;
            propozycjeRep.Edytuj(propozycja);
            db.SaveChanges();
        }

        public static void znajdzDostepnePropozycje()
        {
            propozycjeRep.ZnajdzPoPredykacie(p => p.Status == Status_propozycji.Zgloszona);
        }

    }
}
