using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

public class Grupa_kursow : Kurs  {
    private int grupa_kursow_id;
	private System.Collections.Generic.List<Kurs> kursy_skladowe;

    public Grupa_kursow()
    {
    }

    public Grupa_kursow( List<Kurs> kursy_skladowe, Forma_kursu forma):base(kursy_skladowe[0].Kod_kursu + "GK", kursy_skladowe[0].Nazwa_kursu)
    {
        this.Efekty = new List<Efekt_ksztalcenia>();
        this.kursy_skladowe = kursy_skladowe;
        this.Forma_kursu = forma;
        foreach (Kurs k in kursy_skladowe)
        {
            this.Punkty_ECTS += k.Punkty_ECTS;
            if (k.Czy_egzamin) this.Czy_egzamin = true;
            this.Typ_semestru = k.Typ_semestru;
            this.Semestr = k.Semestr;
            this.Plan_studiow = k.Plan_studiow;
            if (k.Efekty!=null) this.Efekty.AddRange(k.Efekty);
        }
        //usuniêcie powtarzaj¹cych siê elementów:
        this.Efekty = this.Efekty.Distinct().ToList();
    }

    [Key]
    public int Grupa_kursow_id { get => grupa_kursow_id; set => grupa_kursow_id = value; }
    public List<Kurs> Kursy_skladowe { get => kursy_skladowe; set => kursy_skladowe = value; }

}
