using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Plan_studiow {
    private int plan_studiow_id;
    private Poziom_ksztalcenia poziom_ksztalcenia;
	private Boolean czy_studia_stacjonarne;
	private int czas_trwania;

    private System.Collections.Generic.List<Rok_akademicki> lata;
    private Kierunek_studiow kierunek;

    public Plan_studiow(int plan_studiow_id, Poziom_ksztalcenia poziom_ksztalcenia, bool czy_studia_stacjonarne, int czas_trwania, List<Rok_akademicki> lata, Kierunek_studiow kierunek)
    {
        this.plan_studiow_id = plan_studiow_id;
        this.poziom_ksztalcenia = poziom_ksztalcenia;
        this.czy_studia_stacjonarne = czy_studia_stacjonarne;
        this.czas_trwania = czas_trwania;
        this.lata = lata;
        this.kierunek = kierunek;
    }

    public Poziom_ksztalcenia Poziom_ksztalcenia { get => poziom_ksztalcenia; set => poziom_ksztalcenia = value; }
    public bool Czy_studia_stacjonarne { get => czy_studia_stacjonarne; set => czy_studia_stacjonarne = value; }
    public int Czas_trwania { get => czas_trwania; set => czas_trwania = value; }
    public List<Rok_akademicki> Lata { get => lata; set => lata = value; }
    public Kierunek_studiow Kierunek { get => kierunek; set => kierunek = value; }
    [Key]
    public int Plan_studiow_id { get => plan_studiow_id; set => plan_studiow_id = value; }
    //private Student student;

}
