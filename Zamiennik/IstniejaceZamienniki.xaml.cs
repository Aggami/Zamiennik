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
        ObservableCollection<Kurs> aktualneKursy= new ObservableCollection<Kurs>();

        public IstniejaceZamienniki()
        {
            InitializeComponent();
            kursy.Add(new Kurs()
            {
                Punkty_ECTS = 4,
                Czy_egzamin = true,
                Czy_aktywny = false,
                Forma_kursu = Forma_Kursu.Laboratorium,
                //Karta_przedmiotu,
                Nazwa_kursu = "Projektowanie Oprogramowania",
                Kod_kursu = "KX327",
                ZZU = 180,
                Typ_semestru = Typ_Semestru.Semestr_zimowy,
                Semestr = 5
    });
            kursy.Add(new Kurs()
            {
                Punkty_ECTS = 2,
                Czy_egzamin = true,
                Czy_aktywny = false,
                Forma_kursu = Forma_Kursu.Wyklad,
                //Karta_przedmiotu,
                Nazwa_kursu = "Programowanie Aplikacji Multimedialnych",
                Kod_kursu = "ZP435",
                ZZU = 180,
                Typ_semestru = Typ_Semestru.Semestr_letni,
                Semestr = 6
            });
            kursy.Add(new Kurs()
            {
                Punkty_ECTS = 2,
                Czy_egzamin = true,
                Czy_aktywny = false,
                Forma_kursu = Forma_Kursu.Wyklad,
                //Karta_przedmiotu,
                Nazwa_kursu = "Bazy danych Oracle",
                Kod_kursu = "IZ200",
                ZZU = 180,
                Typ_semestru = Typ_Semestru.Semestr_zimowy,
                Semestr = 3
            });
            kursy.Add(new Kurs()
            {
                Punkty_ECTS = 1,
                Czy_egzamin = true,
                Czy_aktywny = false,
                Forma_kursu = Forma_Kursu.Cwiczenia,
                //Karta_przedmiotu,
                Nazwa_kursu = "Podstawy Programowania",
                Kod_kursu = "RZ227",
                ZZU = 180,
                Typ_semestru = Typ_Semestru.Semestr_zimowy,
                Semestr = 2
            });
            courses.ItemsSource = kursy;
        }

        private void on_search_button_Click(object sender, RoutedEventArgs e)
        {
            string toFind = searchBox.Text;
            searchBox.Clear();
            if (toFind == "")
            {
                MessageBox.Show("Wpisz frazę do wyszukania");
                return;
            }

            if (toFind.Length < 3)
            {
                MessageBox.Show("Wpisz dłuższy tekst");
                return;
            }

            // wyszukanie i przygotowanie danych do datagrid

            aktualneKursy = new ObservableCollection<Kurs>(from kurs in kursy where (kurs.Nazwa_kursu.Contains(toFind) || kurs.Kod_kursu.Contains(toFind)) select kurs);
            courses.ItemsSource = aktualneKursy;

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
            Zamienniki.ItemsSource = kursy;
            detailsGrid.Visibility = Visibility.Visible;
            //plans

            details.Visibility =Visibility.Visible ;
        }

        private void Zamienniki_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
