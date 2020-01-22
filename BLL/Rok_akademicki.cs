using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Rok_akademicki {
	private string nazwa;
	private DateTime data_rozpoczecia;
	private DateTime data_zakonczenia;
    private int rok_akademicki_id;

    public string Nazwa { get => nazwa; set => nazwa = value; }
    public DateTime Data_rozpoczecia { get => data_rozpoczecia; set => data_rozpoczecia = value; }
    public DateTime Data_zakonczenia { get => data_zakonczenia; set => data_zakonczenia = value; }
    [Key]
    public int Rok_akademicki_id { get => rok_akademicki_id; set => rok_akademicki_id = value; }
}

