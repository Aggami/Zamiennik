using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Dostep_Do_Danych;

namespace Uslugi
{
    //klasa wykorzystywana do wprowadzenia testowych danych do bazy 
    public class GeneratorDanych
    {
        static DbContext db = new ZamiennikKontekst();

        public static void DodajKursy()
        {
            List<Kurs> kursy = new List<Kurs>();
            kursy.Add(new Kurs()
            {
                Punkty_ECTS = 4,
                Czy_egzamin = true,
                Czy_aktywny = false,
                Forma_kursu = Forma_kursu.Laboratorium,
                //Karta_przedmiotu,
                Nazwa_kursu = "Projektowanie Oprogramowania",
                Kod_kursu = "KX327",
                ZZU = 180,
                Typ_semestru = Typ_semestru.Semestr_zimowy,
                Semestr = 5
            });
            kursy.Add(new Kurs()
            {
                Punkty_ECTS = 2,
                Czy_egzamin = true,
                Czy_aktywny = false,
                Forma_kursu = Forma_kursu.Wyklad,
                //Karta_przedmiotu,
                Nazwa_kursu = "Programowanie Aplikacji Multimedialnych",
                Kod_kursu = "ZP435",
                ZZU = 180,
                Typ_semestru = Typ_semestru.Semestr_letni,
                Semestr = 6
            });
            kursy.Add(new Kurs()
            {
                Punkty_ECTS = 2,
                Czy_egzamin = true,
                Czy_aktywny = false,
                Forma_kursu = Forma_kursu.Wyklad,
                //Karta_przedmiotu,
                Nazwa_kursu = "Bazy danych Oracle",
                Kod_kursu = "IZ200",
                ZZU = 180,
                Typ_semestru = Typ_semestru.Semestr_zimowy,
                Semestr = 3
            });
            kursy.Add(new Kurs()
            {
                Punkty_ECTS = 1,
                Czy_egzamin = true,
                Czy_aktywny = false,
                Forma_kursu = Forma_kursu.Cwiczenia,
                //Karta_przedmiotu,
                Nazwa_kursu = "Podstawy Programowania",
                Kod_kursu = "RZ227",
                ZZU = 180,
                Typ_semestru = Typ_semestru.Semestr_zimowy,
                Semestr = 2
            });
            Repozytorium<Kurs> kursyRep = new Repozytorium<Kurs>(db);
            kursyRep.WstawKolekcje(kursy);
            db.SaveChanges();
        }

        public static void DodajZamienniki(Kurs kurs)
        {
            Repozytorium<Kurs> kursy = new Repozytorium<Kurs>(db);
            List<Kurs> kursySkladowe = kursy.ZnajdzPoPredykacie(k => k.Kod_kursu == "RZ227" || k.Kod_kursu == "IZ200");
            List<Zamiennik_kursu> zamienniki = new List<Zamiennik_kursu>();
            zamienniki.Add(new Zamiennik_kursu(1, kursySkladowe));
            kurs.Zamienniki.AddRange(zamienniki);
            db.SaveChanges();
        }

        public static void DodajWydziały()
        {
            Wydzial w1 = new Wydzial(1, "Wydział Architektury");
            Wydzial w2 = new Wydzial(2, "Wydział Budownictwa");
            Wydzial w3 = new Wydzial(3, "Wydział Chemiczny");
            Wydzial w4 = new Wydzial(4, "Wydział Elektroniki");
            Wydzial w5 = new Wydzial(6, "Wydział Geoinżynierii, Górnictwa i Geologii");
            Wydzial w6 = new Wydzial(7, "Wydział Inżynierii Środowiska");
            Wydzial w7 = new Wydzial(5, "Wydział Elektryki ");
            Wydzial w8 = new Wydzial(8, "Wydział Informatyki i Zarządzania");
            Wydzial w9 = new Wydzial(9, "Wydział Mechaniczno-elektryczny");
            Wydzial w10 = new Wydzial(10, "Wydział Mechaniczny");
            Wydzial w11 = new Wydzial(11, "Wydział Podstawowych Problemów Techniki");
            Wydzial w12 = new Wydzial(12, "Wydział Elektroniki Mikrosystemów i Fotoniki");
            Wydzial w13 = new Wydzial(13, "Wydział Matematyki");
            List<Wydzial> wydzialy = new List<Wydzial>{ w1, w2,w3,w4,w5,w6,w7,w8,w9,w10,w11,w12,w13 };
            Repozytorium<Wydzial> wydzialyRep = new Repozytorium<Wydzial>(db);
            wydzialyRep.WstawKolekcje(wydzialy);
            db.SaveChanges();
        }



    }
}
