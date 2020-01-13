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
using BLL;
using System.Collections;
using System.Collections.ObjectModel;


namespace Zamiennik
{
    /// <summary>
    /// Logika interakcji dla klasy IstniejaceZamienniki.xaml
    /// </summary>
    public partial class IstniejaceZamienniki : Window
    {
        Kurs kurs = null;
        ObservableCollection<Kurs> kursy = new ObservableCollection<Kurs>();

        public IstniejaceZamienniki()
        {
            InitializeComponent();
            kursy.Add(new Kurs()
            {
                Punkty_ECTS = 4,
                Czy_egzamin = true,
                Czy_aktywny = false,
                Forma_kursu = "laboratorium",
                //Karta_przedmiotu,
                Nazwa_kursu = "Projektowanie Oprogramowania",
                Kod_kursu = "KX327",
                ZZU = 180,
                Typ_semestru = "zimowy",
                Semestr = 5
    });
            kursy.Add(new Kurs()
            {
                Punkty_ECTS = 2,
                Czy_egzamin = true,
                Czy_aktywny = false,
                Forma_kursu = "wykład",
                //Karta_przedmiotu,
                Nazwa_kursu = "Programowanie Aplikacji Multimedialnych",
                Kod_kursu = "ZP435",
                ZZU = 180,
                Typ_semestru = "letni",
                Semestr = 6
            });
            kursy.Add(new Kurs()
            {
                Punkty_ECTS = 2,
                Czy_egzamin = true,
                Czy_aktywny = false,
                Forma_kursu = "laboratorium",
                //Karta_przedmiotu,
                Nazwa_kursu = "Bazy danych Oracle",
                Kod_kursu = "IZ200",
                ZZU = 180,
                Typ_semestru = "zimowy",
                Semestr = 3
            });
            kursy.Add(new Kurs()
            {
                Punkty_ECTS = 1,
                Czy_egzamin = true,
                Czy_aktywny = false,
                Forma_kursu = "ćwiczenia",
                //Karta_przedmiotu,
                Nazwa_kursu = "Podstawy Programowania",
                Kod_kursu = "RZ227",
                ZZU = 180,
                Typ_semestru = "letni",
                Semestr = 2
            });
            courses.ItemsSource = kursy;
        }

        private void on_search_button_Click(object sender, RoutedEventArgs e)
        {
            string toFind = searchBox.Text;
            if (toFind == "")
                MessageBox.Show("Wpisz frazę do wyszukania");
            if (toFind.Length < 3 )
                MessageBox.Show("Wpisz dłuższy tekst");

            // wyszukanie i przygotowanie danych do datagrid


        }

        private void row_clicked(object sender, RoutedEventArgs e)
        {
            kurs = courses.SelectedItem as Kurs;
            name.Text = kurs.Nazwa_kursu;
            code.Content = "Kod kursu: "+kurs.Kod_kursu;
            type.Content = "Typ zajęć: "+kurs.Forma_kursu;
            ects.Content = "Liczba punktów ECTS: "+kurs.Punkty_ECTS;
            if (kurs.Czy_egzamin) exam.Content = "Zakończony egzaminem. ";
            else exam.Content = "Kończy się zaliczeniem. ";
            hours.Content ="ZZU (całkowity nakład pracy):" + kurs.ZZU.ToString();
            //plans

            details.Visibility =Visibility.Visible ;
        }
    }
}
