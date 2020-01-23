using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Wydzial {
	private int numer_wydzialu;
	private string nazwa;

    [Key]
    public int Numer_wydzialu { get => numer_wydzialu; set => numer_wydzialu = value; }
    public string Nazwa { get => nazwa; set => nazwa = value; }

    public Wydzial(int numer_wydzialu, string nazwa)
    {
        this.numer_wydzialu = numer_wydzialu;
        this.nazwa = nazwa;
    }


    //private Dziekan kieruje2;

}
