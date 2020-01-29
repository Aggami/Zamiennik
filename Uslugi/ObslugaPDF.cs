
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Dostep_Do_Danych;

namespace Uslugi
{
    /// <summary>
    /// Klasa wspomagajaca obsluge pdf dla bazy danych Zamiennik
    /// </summary>
    public class ObslugaPDF
    {
        /// <summary>
        /// Kontekst bazy danych
        /// </summary>
        static ZamiennikKontekst db = new ZamiennikKontekst();
        /// <summary>
        /// Repozytorium kursow
        /// </summary>
        static RepozytoriumKurs kursyRep = new RepozytoriumKurs(db);
        /// <summary>
        /// Zmienna wykorzystywana do tworzenia roznych sciezek do pliku
        /// </summary>
        static int temp = 1;

        /// <summary>
        /// Metoda konwertujaca plik pdf ze sciezki na tablice byte
        /// </summary>
        /// <param name="sciezka">Sciezka do pliku pdf</param>
        /// <returns>Tablica byte - przekonwertowany plik</returns>
        public static byte[] konwersjaNaByte(string sciezka)
        {
            byte[] plik;
            try
            {
                using (var stream = new FileStream(sciezka, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        plik = reader.ReadBytes((int)stream.Length);
                    }

                }
                return plik;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        /// <summary>
        /// Metoda zapisujaca karte przedmiotu w formacie pdf ze sciezki do kursu w bazie danych
        /// </summary>
        /// <param name="sciezka">sciezka do pliku pdf - karty przedmiotu</param>
        /// <param name="kurs">Kurs, dla ktorego ma byc zapisana karta przedmiotu</param>
        public static void zapisDoKursu(string sciezka, Kurs kurs)
        {
            byte[] plik = konwersjaNaByte(sciezka);
            kurs.Karta_przedmiotu = plik;

        }

        /// <summary>
        /// Metoda pobierajaca karte przedmiotu kursu w formie tablicy byte, konwertujaca ja na pdf i zapisujaca pod okreslona sciezka.
        /// </summary>
        /// <param name="kurs">Kurs, dla ktorego pobieramy karte przedmiotu</param>
        /// <returns>Sciezka do ktorej zapisano plik pdf</returns>
        public static string zapisPdfDoSciezki(Kurs kurs)
        {
            
            string nowaSciezka = System.IO.Directory.GetCurrentDirectory() + @"\temp"+temp%4+".pdf";
            temp++; //gwarantuje, że można zapisać przynajmniej 4 różne karty przedmiotu w danym momencie 
            System.IO.File.WriteAllBytes(nowaSciezka, kurs.Karta_przedmiotu);
            return nowaSciezka;
        }


    }
}