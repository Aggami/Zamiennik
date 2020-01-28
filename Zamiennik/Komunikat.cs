using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Zamiennik
{
    /// <summary>
    /// Klasa wyświetlająca komunikaty w OknieKomunikatu
    /// </summary>
    static class Komunikat
    {
        /// <summary>
        /// Metoda wyświetlająca okno komunikatu z różnymi opcjami przycisków.
        /// </summary>
        /// <param name="tekst">Treść komunikatu</param>
        /// <param name="przyciski">Rodzaj przycisków</param>
        /// <returns>rezultat - opcja wybrana przez użytkownika</returns>
        public static MessageBoxResult ShowWithResult(string tekst, MessageBoxButton przyciski)
        {
            OknoKomunikatu oknoKomunikatu = new OknoKomunikatu(tekst, przyciski);
            oknoKomunikatu.ShowDialog();
            return oknoKomunikatu.result;
        }

        /// <summary>
        /// Metoda wyświetlająca okno komunikatu z przyciskiem Ok.
        /// </summary>
        /// <param name="tekst">Treść komunikatu</param>
        public static void Show(string tekst)
        {
            OknoKomunikatu oknoKomunikatu = new OknoKomunikatu(tekst);
            oknoKomunikatu.ShowDialog();

        }
    }

}
