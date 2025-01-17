using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Rok_akademicki {
	private string nazwa;
	private DateTime data_rozpoczecia;
	private DateTime data_zakonczenia;
    private int rok_akademicki_id;

    public Rok_akademicki()
    {
    }

    public Rok_akademicki(string nazwa, DateTime data_rozpoczecia, DateTime data_zakonczenia)
    {
        this.nazwa = nazwa;
        this.data_rozpoczecia = data_rozpoczecia;
        this.data_zakonczenia = data_zakonczenia;
    }

    [Key]
    public int Rok_akademicki_id { get => rok_akademicki_id; set => rok_akademicki_id = value; }

    public DateTime Data_rozpoczecia { get => data_rozpoczecia; set => data_rozpoczecia = value; }
    public DateTime Data_zakonczenia { get => data_zakonczenia; set => data_zakonczenia = value; }
   

    public string Nazwa
    {
        get
        {
            return this.Data_rozpoczecia.Year + "/" + this.Data_zakonczenia.Year;
        }

    }
}

