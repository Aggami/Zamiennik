using Dostep_Do_Danych;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uslugi
{
    /// <summary>
    /// Klasa dostarczająca metody do zarządzania propozycją zamiennika.
    /// </summary>
    public class ZarzadzaniePropozycja
    {
        /// <summary>
        /// Kontekst bazy danych.
        /// </summary>
        private static ZamiennikKontekst db = new ZamiennikKontekst();
        /// <summary>
        /// Repozytorium propozycji komunikujące się z kontekstem bazy danych.
        /// </summary>
        private static RepozytoriumPropozycja propozycjeRep = new RepozytoriumPropozycja(db);

        /// <summary>
        /// Metoda służąca do akceptowania propozycji przez opiniodawcę (zmiany statusu na 'zweryfikowana')
        /// </summary>
        /// <param name="propozycja">Propozycja do zaakceptowania</param>
        /// <param name="komentarz">Komentarz opiniodawcy do dodania do propozycji</param>
        public static void zaakceptujPropozycje(Propozycja_zamiennika propozycja, string komentarz)
        {
            propozycja.zaakceptujPropozycje(komentarz);
            db.SaveChanges();

        }

        /// <summary>
        /// Metoda służąca do odrzucenia propozycji przez opiniodawce (zmiany statusu na 'odrzucona')
        /// </summary>
        /// <param name="propozycja">Propozycja do odrzucenia</param>
        /// <param name="komentarz">Komentarz opiniodawcy do dodania do propozycji</param>
        public static void odrzucPropozycje(Propozycja_zamiennika propozycja, string komentarz)
        {
            propozycja.odrzucPropozycje(komentarz);
            db.SaveChanges();
        }

        /// <summary>
        /// Metoda wyszukująca propozycje do rozpatrzenia.
        /// </summary>
        /// <returns>Wszystkie propozycje z bazy danych o statusie Status_propozycji.Zgloszona</returns>
        public static List<Propozycja_zamiennika> znajdzDostepnePropozycje()
        {
            return propozycjeRep.ZnajdzPoPredykacie(p => p.Status == Status_propozycji.Zgloszona);
        }

        /// <summary>
        /// Metoda do testów ustawiająca wszystkie propozycje jako zgłoszone 
        /// 
        /// </summary>
       public static void ustawPropozycjeJakoZgloszone()
        {
            List<Propozycja_zamiennika> propozycje = propozycjeRep.ZnajdzWszystkie().ToList();
            foreach (Propozycja_zamiennika p in propozycje)
            {
                p.Status = Status_propozycji.Zgloszona;
                p.Komentarz_Opiniodawcy = "";
            }
            db.SaveChanges();
        }
        

    }
}
