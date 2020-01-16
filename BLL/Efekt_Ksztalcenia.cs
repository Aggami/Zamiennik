using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class Efekt_Ksztalcenia {
	private Typ_efektu_ksztalcenia typ;

    
	private string symbol_efektu_ksztalcenia;
	private string nazwa;

	private Plan_studiow plan_studiow;

    public Typ_efektu_ksztalcenia Typ { get => typ; set => typ = value; }
    [Key]
    public string Symbol_efektu_ksztalcenia { get => symbol_efektu_ksztalcenia; set => symbol_efektu_ksztalcenia = value; }
    public string Nazwa { get => nazwa; set => nazwa = value; }
    public Plan_studiow Plan_studiow { get => plan_studiow; set => plan_studiow = value; }
}
