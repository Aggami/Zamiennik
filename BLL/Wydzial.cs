using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Wydzial {
	private int numer_wydzialu;
	private string nazwa;

    [Key]
    public int Numer_wydzialu { get => numer_wydzialu; set => numer_wydzialu = value; }
    public string Nazwa { get => nazwa; set => nazwa = value; }


    //private Dziekan kieruje2;

}
