using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Zamiennik_kursu {
	private int punkty_ECTS;
	private bool czy_Egzamin;
	private Poziom_Ksztalcenia poziom_ksztalcenia;
	private Boolean czy_studia_stacjonarne;
	private Boolean czy_aktywny;
	private Typ_Semestru typ_semestru;

	private System.Collections.Generic.List<Kurs> kursy_skladowe;

    public int Punkty_ECTS { get => punkty_ECTS; set => punkty_ECTS = value; }
    public bool Czy_Egzamin { get => czy_Egzamin; set => czy_Egzamin = value; }
    public Poziom_Ksztalcenia Poziom_ksztalcenia { get => poziom_ksztalcenia; set => poziom_ksztalcenia = value; }
    public bool Czy_studia_stacjonarne { get => czy_studia_stacjonarne; set => czy_studia_stacjonarne = value; }
    public bool Czy_aktywny { get => czy_aktywny; set => czy_aktywny = value; }
    public Typ_Semestru Typ_semestru { get => typ_semestru; set => typ_semestru = value; }
    public List<Kurs> Kursy_skladowe { get => kursy_skladowe; set => kursy_skladowe = value; }
}
