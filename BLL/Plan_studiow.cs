using System;
using System.Collections.Generic;

public class Plan_studiow {
	private Poziom_Ksztalcenia poziom_ksztalcenia;
	private Boolean czy_studia_stacjonarne;
	private int czas_trwania;

    private System.Collections.Generic.List<Rok_akademicki> lata;
    private Kierunek_studiow kierunek;

    public Poziom_Ksztalcenia Poziom_ksztalcenia { get => poziom_ksztalcenia; set => poziom_ksztalcenia = value; }
    public bool Czy_studia_stacjonarne { get => czy_studia_stacjonarne; set => czy_studia_stacjonarne = value; }
    public int Czas_trwania { get => czas_trwania; set => czas_trwania = value; }
    public List<Rok_akademicki> Lata { get => lata; set => lata = value; }
    public Kierunek_studiow Kierunek { get => kierunek; set => kierunek = value; }
    //private Student student;

}
