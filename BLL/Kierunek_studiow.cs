using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Kierunek_studiow {
	private string nazwa;
    private int kierunek_id;

	private Wydzial wydzial;

    public Kierunek_studiow()
    {
    }

    public Kierunek_studiow(string nazwa, Wydzial wydzial)
    {
        this.nazwa = nazwa;
        this.wydzial = wydzial;
    }

    [Key]
    public int Kierunek_id { get => kierunek_id; set => kierunek_id = value; }
    public string Nazwa { get => nazwa; set => nazwa = value; }
    public Wydzial Wydzial { get => wydzial; set => wydzial = value; }
    
}
