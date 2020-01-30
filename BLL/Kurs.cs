using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Kurs {
    protected string kod_kursu;
    protected string nazwa_kursu;
    private int punkty_ECTS;
	private bool czy_egzamin;

	private Forma_kursu forma_kursu;
	private byte[] karta_przedmiotu;


	private int zZU;
	private Typ_semestru typ_semestru;
	private int semestr;

	private System.Collections.Generic.List<Efekt_ksztalcenia> efekty;
	private System.Collections.Generic.List<Zamiennik_kursu> zamienniki;
	private Plan_studiow plan_studiow;
    private bool czy_aktywny;

    public Kurs()
    {
    }

    public Kurs(string kod_kursu, string nazwa_kursu)
    {
        this.kod_kursu = kod_kursu;
        this.nazwa_kursu = nazwa_kursu;
    }

    public Kurs(string kod_kursu, string nazwa_kursu, int punkty_ECTS, bool czy_egzamin, Forma_kursu forma_kursu, byte[] karta_przedmiotu, int zZU, Typ_semestru typ_semestru, int semestr, List<Efekt_ksztalcenia> efekty, List<Zamiennik_kursu> zamienniki, Plan_studiow plan_studiow, bool czy_aktywny)
    {
        this.kod_kursu = kod_kursu;
        this.nazwa_kursu = nazwa_kursu;
        this.punkty_ECTS = punkty_ECTS;
        this.czy_egzamin = czy_egzamin;
        this.forma_kursu = forma_kursu;
        this.karta_przedmiotu = karta_przedmiotu;
        this.zZU = zZU;
        this.typ_semestru = typ_semestru;
        this.semestr = semestr;
        this.efekty = efekty;
        this.zamienniki = zamienniki;
        this.plan_studiow = plan_studiow;
        this.czy_aktywny = czy_aktywny;
    }

    [Key]
    public string Kod_kursu { get => kod_kursu; set => kod_kursu = value; }
    [Required]
    public string Nazwa_kursu { get => nazwa_kursu; set => nazwa_kursu = value; }
    public int Punkty_ECTS { get => punkty_ECTS; set => punkty_ECTS = value; }
    public Forma_kursu Forma_kursu { get => forma_kursu; set => forma_kursu = value; }
    public int ZZU { get => zZU; set => zZU = value; }
    public bool Czy_egzamin { get => czy_egzamin; set => czy_egzamin = value; }
    public bool Czy_aktywny { get => czy_aktywny; set => czy_aktywny = value; }
    
    public byte[] Karta_przedmiotu { get => karta_przedmiotu; set => karta_przedmiotu = value; }   

   
    public Typ_semestru Typ_semestru { get => typ_semestru; set => typ_semestru = value; }
    public int Semestr { get => semestr; set => semestr = value; }


    public List<Efekt_ksztalcenia> Efekty { get => efekty; set => efekty = value; }
    public List<Zamiennik_kursu> Zamienniki { get => zamienniki; set => zamienniki = value; }
    virtual public Plan_studiow Plan_studiow { get => plan_studiow; set => plan_studiow = value; }

    //private Opiniodawca opiekun;

    public string EfektyToString()
    {
        string s = "";
        foreach (Efekt_ksztalcenia efekt in Efekty)
        {
            s += efekt.Symbol_efektu_ksztalcenia + " " + efekt.Nazwa + "\n";
        }
        return s;
    }

    public string Wydzial
    {
        get
        {
            return "W" + Plan_studiow.Kierunek.Wydzial.Numer_wydzialu;
        }
    }

}
