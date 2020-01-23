using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Kurs {
	private int punkty_ECTS;
	private bool czy_egzamin;
	private bool czy_aktywny;
	private Forma_kursu forma_kursu;
	private byte[] karta_przedmiotu;
	private string nazwa_kursu;
	private string kod_kursu;
	private int zZU;
	private Typ_semestru typ_semestru;
	private int semestr;

	private System.Collections.Generic.List<Efekt_ksztalcenia> efekty;
	private System.Collections.Generic.List<Zamiennik_kursu> zamienniki;
	private Plan_studiow plan_studiow;

    public int Punkty_ECTS { get => punkty_ECTS; set => punkty_ECTS = value; }
    public bool Czy_egzamin { get => czy_egzamin; set => czy_egzamin = value; }
    public bool Czy_aktywny { get => czy_aktywny; set => czy_aktywny = value; }
    public Forma_kursu Forma_kursu { get => forma_kursu; set => forma_kursu = value; }
    public byte[] Karta_przedmiotu { get => karta_przedmiotu; set => karta_przedmiotu = value; }

    [Required]
    public string Nazwa_kursu { get => nazwa_kursu; set => nazwa_kursu = value; }

    [Key]
    public string Kod_kursu { get => kod_kursu; set => kod_kursu = value; }
    public int ZZU { get => zZU; set => zZU = value; }
    public Typ_semestru Typ_semestru { get => typ_semestru; set => typ_semestru = value; }
    public int Semestr { get => semestr; set => semestr = value; }
    public List<Efekt_ksztalcenia> Efekty { get => efekty; set => efekty = value; }
    public List<Zamiennik_kursu> Zamienniki { get => zamienniki; set => zamienniki = value; }
    public Plan_studiow Plan_studiow { get => plan_studiow; set => plan_studiow = value; }

    //private Opiniodawca opiekun;

}
