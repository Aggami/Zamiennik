using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Wydzial {
	private string numer_wydzialu;
	private string nazwa;

    [Key]
    [MaxLength(3)]
    public string Numer_wydzialu { get => numer_wydzialu; set => numer_wydzialu = value; }
    public string Nazwa { get => nazwa; set => nazwa = value; }

    public Wydzial(string numer_wydzialu, string nazwa)
    {
        this.numer_wydzialu = numer_wydzialu;
        this.nazwa = nazwa;
    }

    public Wydzial()
    {
    }


    //private Dziekan kieruje2;

}
