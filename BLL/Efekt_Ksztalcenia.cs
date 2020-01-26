using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class Efekt_ksztalcenia {





    private string symbol_efektu_ksztalcenia;
    private Plan_studiow plan_studiow;
    private string nazwa;
    private Typ_efektu_ksztalcenia typ;
    private int efektKsztalceniaId;

    public Efekt_ksztalcenia()
    {
    }

    public Efekt_ksztalcenia(string symbol_efektu_ksztalcenia, Plan_studiow plan_studiow, string nazwa, Typ_efektu_ksztalcenia typ)
    {
        this.symbol_efektu_ksztalcenia = symbol_efektu_ksztalcenia;
        this.plan_studiow = plan_studiow;
        this.nazwa = nazwa;
        this.typ = typ;
    }


    public string Symbol_efektu_ksztalcenia { get => symbol_efektu_ksztalcenia; set => symbol_efektu_ksztalcenia = value; }

    public Plan_studiow Plan_studiow { get => plan_studiow; set => plan_studiow = value; }

    public string Nazwa { get => nazwa; set => nazwa = value; }
    public Typ_efektu_ksztalcenia Typ { get => typ; set => typ = value; }

    [Key]
    public int EfektKsztalceniaId { get => efektKsztalceniaId; set => efektKsztalceniaId = value; }
}
