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
            nazwa.Text = zamiennik.Kursy_skladowe[0].Nazwa_kursu;
            kod.Content = "Kod(y) kursu(ów): "+ zamiennik.Kursy_skladowe[0].Kod_kursu;
            typ.Content = "Forma zajęć: "+ zamiennik.Kursy_skladowe[0].Forma_kursu;
            ects.Content = "Punkty ECTS: "+ zamiennik.Kursy_skladowe[0].Punkty_ECTS;
            czyegzamin.Content = zamiennik.Kursy_skladowe[0].Czy_egzamin;
            plan.Content = "Plan studiow: \n"+ zamiennik.Kursy_skladowe[0].Plan_studiow;

            if (zamiennik.Kursy_skladowe.Count > 1)
            {
                
                nazwa2.Text = zamiennik.Kursy_skladowe[1].Nazwa_kursu;
                kod2.Content = "Kod(y) kursu(ów): " + zamiennik.Kursy_skladowe[1].Kod_kursu;
                typ2.Content = "Forma zajęć: " + zamiennik.Kursy_skladowe[1].Forma_kursu;
                ects2.Content = "Punkty ECTS: " + zamiennik.Kursy_skladowe[1].Punkty_ECTS;
                czyegzamin2.Content = zamiennik.Kursy_skladowe[1].Czy_egzamin;
                plan2.Content = "Plan studiow: \n" + zamiennik.Kursy_skladowe[1].Plan_studiow;
                nazwa2.Visibility = Visibility.Visible;
                kod2.Visibility = Visibility.Visible;
                typ2.Visibility = Visibility.Visible;
                ects2.Visibility = Visibility.Visible;
                czyegzamin2.Visibility = Visibility.Visible;
                plan2.Visibility = Visibility.Visible;
            }

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
