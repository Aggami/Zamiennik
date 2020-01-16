using System;
using System.Collections.Generic;

public class Propozycja_zamiennika {
	private Status_propozycji status;
	private string komentarz_Opiniodawcy;

	private Kurs kurs_zastepowany;

	//private Student proponuj¹cy;
	private System.Collections.Generic.List<Kurs> kurs_zastepujacy;

    public Propozycja_zamiennika(Kurs kurs_zastepowany, List<Kurs> kurs_zastepujacy)
    {
        Kurs_zastepowany = kurs_zastepowany;
        Kurs_zastepujacy = kurs_zastepujacy;
    }

    public Status_propozycji Status { get => status; set => status = value; }
    public string Komentarz_Opiniodawcy { get => komentarz_Opiniodawcy; set => komentarz_Opiniodawcy = value; }
    public Kurs Kurs_zastepowany { get => kurs_zastepowany; set => kurs_zastepowany = value; }
    public List<Kurs> Kurs_zastepujacy { get => kurs_zastepujacy; set => kurs_zastepujacy = value; }
    //private Opiniodawca rozpatruje2;

}
