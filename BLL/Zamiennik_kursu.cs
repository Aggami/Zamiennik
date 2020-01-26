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

    //uwaga: dodaæ panowanie nad derived
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
        }
    }


    [Key]
    public int Id_zamiennika { get => id_zamiennika; set => id_zamiennika = value; }
    public Kurs Kurs_zastepowany { get => kurs_zastepowany; set => kurs_zastepowany = value; }
    public List<Kurs> Kursy_skladowe { get => kursy_skladowe; set => kursy_skladowe = value; }

    public int Punkty_ECTS { get => punkty_ECTS; }
    public bool Czy_Egzamin { get => czy_Egzamin; }
    public Poziom_ksztalcenia Poziom_ksztalcenia { get => poziom_ksztalcenia; }
    public bool Czy_studia_stacjonarne { get => czy_studia_stacjonarne; }
    public bool Czy_aktywny { get => czy_aktywny; }
    public Typ_semestru Typ_semestru { get => typ_semestru;  }
}
