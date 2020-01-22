using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Kierunek_studiow {
	private string nazwa;
    private int kierunek_id;

	private Wydzial wydzial;
    
    public string Nazwa { get => nazwa; set => nazwa = value; }
    public Wydzial Wydzial { get => wydzial; set => wydzial = value; }
    [Key]
    public int Kierunek_id { get => kierunek_id; set => kierunek_id = value; }
}
