using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//to jest klasa robocz, używana do testowania interfejsu


namespace BLL
{
    public class Kurs
    {
        private int punkty_ECTS;
        private bool czy_egzamin;
        private bool czy_aktywny;
        private string forma_kursu;
        private string karta_przedmiotu;
        private string nazwa_kursu;
        private string kod_kursu;
        private int zZU;
        private string typ_semestru;
        private int semestr;

        public int Punkty_ECTS { get => punkty_ECTS; set => punkty_ECTS = value; }
        public bool Czy_egzamin { get => czy_egzamin; set => czy_egzamin = value; }
        public bool Czy_aktywny { get => czy_aktywny; set => czy_aktywny = value; }
        public string Forma_kursu { get => forma_kursu; set => forma_kursu = value; }
        public string Karta_przedmiotu { get => karta_przedmiotu; set => karta_przedmiotu = value; }
        public string Nazwa_kursu { get => nazwa_kursu; set => nazwa_kursu = value; }
        public string Kod_kursu { get => kod_kursu; set => kod_kursu = value; }
        public int ZZU { get => zZU; set => zZU = value; }
        public string Typ_semestru { get => typ_semestru; set => typ_semestru = value; }
        public int Semestr { get => semestr; set => semestr = value; }

        //private Efekt_Kształcenia[] realizuje;
        //private Propozycja_zamiennika[] jest_proponowanym_zamiennikiem;
        //private Zamiennik_kursu[] kursy_zastępujące;
        //private Zawiera zawiera2;

        //private Propozycja_zamiennika[] dotyczy;
        //private Zamiennik_kursu[] zamiennik;
        //private Opiniodawca opiekun;


    }
}
