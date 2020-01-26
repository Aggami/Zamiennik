using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Zamiennik
{
    /// <summary>
    /// Logika interakcji dla klasy PodgladZamiennika.xaml
    /// </summary>
    public partial class PodgladZamiennika : Window
    {
        Zamiennik_kursu zamiennik;

        public PodgladZamiennika(Zamiennik_kursu zamiennik)
        {
            InitializeComponent();
            this.zamiennik = zamiennik;
            nazwa.Content = zamiennik.Nazwa_kursu;
            kod.Content = zamiennik.Kod_kursu;
            typ.Content = zamiennik.Forma_kursu;
            ects.Content = zamiennik.Punkty_ECTS;
            czyegzamin.Content = zamiennik.Czy_egzamin;


        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
