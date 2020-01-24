using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Zamiennik
{
    static class Komunikat
    {
        public static MessageBoxResult ShowWithResult(string tekst, MessageBoxButton przyciski)
        {
            OknoKomunikatu oknoKomunikatu = new OknoKomunikatu(tekst, przyciski);
            oknoKomunikatu.ShowDialog();
            return oknoKomunikatu.result;
        }

        public static void Show(string tekst)
        {
            OknoKomunikatu oknoKomunikatu = new OknoKomunikatu(tekst);
            oknoKomunikatu.ShowDialog();

        }
    }

}
