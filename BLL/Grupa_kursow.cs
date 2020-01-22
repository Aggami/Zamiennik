using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Grupa_kursow : Kurs  {
    private int grupa_kursow_id;
	private System.Collections.Generic.List<Kurs> kursy_skladowe;

    [Key]
    public int Grupa_kursow_id { get => grupa_kursow_id; set => grupa_kursow_id = value; }
    public List<Kurs> Kursy_skladowe { get => kursy_skladowe; set => kursy_skladowe = value; }
}
