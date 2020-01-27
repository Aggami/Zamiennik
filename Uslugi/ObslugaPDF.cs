
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Dostep_Do_Danych;

namespace Uslugi
{
    public class ObslugaPDF
    {
        static ZamiennikKontekst db = new ZamiennikKontekst();
        static RepozytoriumKurs kursyRep = new RepozytoriumKurs(db);

        public static byte[] konwersjaNaByte(string sciezka)
        {
            byte[] plik;
            using (var stream = new FileStream(sciezka, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    plik = reader.ReadBytes((int)stream.Length);
                }
                
            }
            return plik;

        }

        public static void zapisDoBD(string sciezka, Kurs kurs)
        {
            byte[] plik = konwersjaNaByte(sciezka);
            kurs.Karta_przedmiotu = plik;
            kursyRep.Edytuj(kurs);
            db.SaveChanges();
        }

        public static string zapisPdfDoSciezki(Kurs kurs)
        {
            
            string nowaSciezka = System.IO.Directory.GetCurrentDirectory() + @"\temp.pdf";
            System.IO.File.WriteAllBytes(nowaSciezka, kurs.Karta_przedmiotu);
            return nowaSciezka;
        }


    }
}