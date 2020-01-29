using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Klasa przechowujaca propozycje zamiennika
/// </summary>
public class Propozycja_zamiennika {
    private int propozycja_zamiennika_id;
	private Status_propozycji status;
	private string komentarz_Opiniodawcy;

	private Kurs kurs_zastepowany;

	//private Student proponuj¹cy;
	private Kurs kurs_zastepujacy;
    /// <summary>
    /// Konstruktor bezparametrowy wykorzystywany przez Entity Framework do tworzenia obiektu pobranego z bazy danych
    /// Niezalecany przy tworzeniu propozycji.
    /// </summary>
    public Propozycja_zamiennika()
    {
       
    }

    /// <summary>
    /// Konstruktor z dwoma parametrami
    /// </summary>
    /// <param name="kurs_zastepowany">Kurs zastepowany</param>
    /// <param name="kurs_zastepujacy">Kurrs zastepujacy</param>
    public Propozycja_zamiennika(Kurs kurs_zastepowany, Kurs kurs_zastepujacy)
    {
        Kurs_zastepowany = kurs_zastepowany;
        Kurs_zastepujacy = kurs_zastepujacy;
        Status = Status_propozycji.Zgloszona;
    }
    /// <summary>
    /// Klucz glowny propozycji, nadawany automatycznie przez baze danych
    /// </summary>
    [Key]
    public int Propozycja_zamiennika_id { get => propozycja_zamiennika_id; set => propozycja_zamiennika_id = value; }

    /// <summary>
    /// Kurs zastepowany w propozycji
    /// </summary>
    public Kurs Kurs_zastepowany { get => kurs_zastepowany; set => kurs_zastepowany = value; }

    /// <summary>
    /// Kurs zastepujacy w propozycji
    /// </summary>
    public Kurs Kurs_zastepujacy { get => kurs_zastepujacy; set => kurs_zastepujacy = value; }

    /// <summary>
    /// Status propozycji
    /// </summary>
    public Status_propozycji Status { get => status; set => status = value; }

    /// <summary>
    /// Komentarz zapisany po zweryfikowaniu/odrzuceniu przez opiniodawce
    /// </summary>
    public string Komentarz_Opiniodawcy { get => komentarz_Opiniodawcy; set => komentarz_Opiniodawcy = value; }
    
    
    //private Opiniodawca rozpatruje2;

    /// <summary>
    /// Metoda akceptujaca propozycje.
    /// </summary>
    /// <param name="komentarz">Komentarz opiniodawcy</param>
    public void zaakceptujPropozycje(string komentarz)
    {
        this.Status = Status_propozycji.Zweryfikowana;
        this.komentarz_Opiniodawcy = komentarz;
    }

    /// <summary>
    /// Metoda odrzucaj¹ca propozycje.
    /// </summary>
    /// <param name="komentarz">Komentarz opiniodawcy</param>
    public void odrzucPropozycje(string komentarz)
    {
        this.Status = Status_propozycji.Odrzucona;
        this.komentarz_Opiniodawcy = komentarz;
    }

}
