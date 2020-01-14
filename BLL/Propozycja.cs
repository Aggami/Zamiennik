using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Propozycja
    {
        private Kurs kurs_zastepowany;
        private Kurs[] kurs_zastepujacy;
        private string status;
        private string komentarz;

        public Kurs Kurs_zastepowany { get => kurs_zastepowany; set => kurs_zastepowany = value; }
        public Kurs[] Kurs_zastepujacy { get => kurs_zastepujacy; set => kurs_zastepujacy = value; }
        public string Status { get => status; set => status = value; }
        public string Komentarz { get => komentarz; set => komentarz = value; }

        public Propozycja(Kurs k1, Kurs[] k2)
        {
            kurs_zastepowany = k1;
            kurs_zastepujacy = k2;

        }
    }
}
