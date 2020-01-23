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


    //uwaga: dodaæ panowanie nad derived
    public Zamiennik_kursu(int id_zamiennika, List<Kurs> kursy_skladowe)
    {
        this.id_zamiennika = id_zamiennika;
        this.kursy_skladowe = kursy_skladowe;
        foreach (Kurs k in kursy_skladowe){
            if (k.Czy_egzamin) this.czy_Egzamin = true;
            this.punkty_ECTS += k.Punkty_ECTS;
            this.typ_semestru = k.Typ_semestru;
            if (!k.Czy_aktywny) this.czy_aktywny = false;
        }
    }

    public int Punkty_ECTS { get => punkty_ECTS; set => punkty_ECTS = value; }
    public bool Czy_Egzamin { get => czy_Egzamin; set => czy_Egzamin = value; }
    public Poziom_ksztalcenia Poziom_ksztalcenia { get => poziom_ksztalcenia; set => poziom_ksztalcenia = value; }
    public bool Czy_studia_stacjonarne { get => czy_studia_stacjonarne; set => czy_studia_stacjonarne = value; }
    public bool Czy_aktywny { get => czy_aktywny; set => czy_aktywny = value; }
    public Typ_semestru Typ_semestru { get => typ_semestru; set => typ_semestru = value; }
    public List<Kurs> Kursy_skladowe { get => kursy_skladowe; set => kursy_skladowe = value; }
    [Key]
    public int Id_zamiennika { get => id_zamiennika; set => id_zamiennika = value; }
}
