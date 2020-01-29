using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Uslugi
{
    /// <summary>
    /// Klasa wspomagająca wyświetlanie wartości ENUM w warstwie prezentacji
    /// </summary>
    public class Slownik
    {
        /// <summary>
        /// Metoda tlumaczaca enum Forma_kursu na string do wyswietlenia w warstwie prezentacji. 
        /// </summary>
        /// <param name="forma">Forma kursu do wyswietlenia</param>
        /// <returns>Ciag znakow reprezentujacy dana forme kursu.</returns>
        public static string Forma_Kursu (Forma_kursu forma)
        {
            switch (forma){
                case Forma_kursu.CwiczeniaLaboratorium:
                    return "Ćwiczenia i Laboratorium (GK)";
                case Forma_kursu.WykladCwiczenia:
                    return "Wykład i ćwiczenia (GK)";
                case Forma_kursu.WykladCwiczeniaLaboratorium:
                    return "Wykład, ćwiczenia i laboratorium (GK)";
                case Forma_kursu.WykladProjekt:
                    return "Wykład i projekt (GK)";
                case Forma_kursu.WykladLaboratorium:
                    return "Wykład i laboratorium (GK)";
                case Forma_kursu.Wyklad:
                    return "Wykład";
                case Forma_kursu.Cwiczenia:
                    return "Ćwiczenia";
                default:
                    return forma.ToString();
            }
        }

        /// <summary>
        /// Metoda tlumaczaca enum Typ_semestru na string do wyswietlenia w warstwie prezentacji.
        /// </summary>
        /// <param name="typ">Typ semestru do wyswietlenia</param>
        /// <returns>Ciag znakow reprezentujacy typ semestru</returns>
        public static string Typ_semestru(Typ_semestru typ)
        {
            if (typ == global::Typ_semestru.Semestr_letni) return "Semestr letni";
            else return "Semestr zimowy";
        }


    }
}