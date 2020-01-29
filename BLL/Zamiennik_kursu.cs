using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Zamiennik_kursu {
	private int punkty_ECTS;
	private bool czy_Egzamin;
	private Poziom_ksztalcenia poziom_ksztalcenia;
	private Boolean czy_studia_stacjonarne;
	private Boolean czy_aktywny;
	private Typ_semestru typ_semestru;
    private int id_zamiennika;

	private System.Collections.Generic.List<Kurs> kursy_skladowe;
    private Kurs kurs_zastepowany;

    public Zamiennik_kursu()
    {
    }


    public Zamiennik_kursu(Kurs kurs, List<Kurs> kursy_skladowe)
    {
        this.kurs_zastepowany = kurs;
        this.kursy_skladowe = kursy_skladowe;
        foreach (Kurs k in kursy_skladowe){
            if (k.Czy_egzamin) this.czy_Egzamin = true;
            this.punkty_ECTS += k.Punkty_ECTS;
            this.typ_semestru = k.Typ_semestru;
            if (!k.Czy_aktywny) this.czy_aktywny = false;
            this.poziom_ksztalcenia = k.Plan_studiow.Poziom_ksztalcenia;
            this.czy_studia_stacjonarne = k.Plan_studiow.Czy_studia_stacjonarne;
        }
    }


    [Key]
    public int Id_zamiennika { get => id_zamiennika; set => id_zamiennika = value; }
    public Kurs Kurs_zastepowany { get => kurs_zastepowany; set => kurs_zastepowany = value; }
    public List<Kurs> Kursy_skladowe { get => kursy_skladowe; set => kursy_skladowe = value; }

    //public int Punkty_ECTS { get => punkty_ECTS; }
    //public bool Czy_Egzamin { get => czy_Egzamin; }
    public Poziom_ksztalcenia Poziom_ksztalcenia { get => poziom_ksztalcenia; }
    public bool Czy_studia_stacjonarne { get => czy_studia_stacjonarne; }
    public bool Czy_aktywny { get => czy_aktywny; }
    public Typ_semestru Typ_semestru { get => typ_semestru;  }

    [NotMapped]
    public string Kod_kursu
    {
        get
        {
            string s="";
            foreach (Kurs k in Kursy_skladowe)
            {
                s+=k.Kod_kursu+",  ";
            }
            s = s.Trim();
            return s;
        }
    }

    [NotMapped]
    public string Nazwa_kursu
    {
        get
        {
            string s = "";
            foreach (Kurs k in Kursy_skladowe)
            {
                if (s.Contains(k.Nazwa_kursu)) continue;
                s += k.Nazwa_kursu + "+ ";
            }
            s = s.Trim();
            return s;
        }
    }

    public string Forma_kursu
    {
        get
        {
            string s = "";
            foreach (Kurs k in Kursy_skladowe)
            {
                s += k.Forma_kursu + "\n";
            }
            s = s.Trim();
            return s;
        }
    }

    public string Wydzial
    {
        get
        {
            string s = "";
            foreach (Kurs k in Kursy_skladowe)
            {
                s +="W"+ k.Plan_studiow.Kierunek.Wydzial.Numer_wydzialu+ ", ";
            }
            return s;

        }
    }

    public string Czy_egzamin
    {
        get
        {
            string s = "Kurs zakoñczony zaliczeniem.";
            foreach (Kurs k in Kursy_skladowe)
            {
                if (k.Czy_egzamin) s = "Kurs zakoñczony egzaminem. ";
            }
            s = s.Trim();
            return s;
        }
    }

    

    public string Kierunek
    {
        get
        {
            string s = "";
            foreach (Kurs k in Kursy_skladowe)
            {
                s += k.Plan_studiow.Kierunek.Nazwa + "\n";
            }
            s = s.Trim();
            return s;
        }
    }

    [NotMapped]
    public string Punkty_ECTS
    {
        get
        {
            string s = "";
            int suma = 0;
            foreach (Kurs k in Kursy_skladowe)
            {
                s += k.Punkty_ECTS + " +";
                suma += k.Punkty_ECTS;
            }
            s = s.Remove(s.Length - 2);
            s += " = " + suma;
            return s;
        }
    }

    [NotMapped]
    public string ZZU
    {
        get
        {
            string s = "";
            int suma = 0;
            foreach (Kurs k in Kursy_skladowe)
            {
                s += k.ZZU + " +";
                suma += k.ZZU;
            }
            s = s.Remove(s.Length - 2);
            s += " = " + suma;
            return s;
        }
    }


}
