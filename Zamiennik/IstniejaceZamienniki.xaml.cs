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
//using BLL;
using System.Collections;
using System.Collections.ObjectModel;
using Uslugi;


namespace Zamiennik
{
    /// <summary>
    /// Logika interakcji dla klasy IstniejaceZamienniki.xaml
    /// </summary>
    public partial class IstniejaceZamienniki : Window
    {
        Kurs kurs = null;
        ObservableCollection<Kurs> aktualneKursy= new ObservableCollection<Kurs>();
        ObservableCollection<Zamiennik_kursu> aktualneZamienniki = new ObservableCollection<Zamiennik_kursu>();
        

        public IstniejaceZamienniki()
        {
            InitializeComponent();
        }

        private void on_search_button_Click(object sender, RoutedEventArgs e)
        {
            string toFind = searchBox.Text;
            searchBox.Clear();
            if (toFind == "")
            {
                Komunikat.Show("Wpisz frazę do wyszukania");
                return;
            }

            if (toFind.Length < 3)
            {
                Komunikat.Show("Wpisz dłuższy tekst");
                return;
            }

            // wyszukanie i przygotowanie danych do datagrid
            
            aktualneKursy = new ObservableCollection<Kurs>(Wyszukiwarka.ZnajdzKurs(toFind));
            courses.ItemsSource = aktualneKursy;
            if (aktualneKursy.Count == 0) Komunikat.Show("Nie znaleziono kursu.");
            else courses.Visibility = Visibility.Visible;

        }

        private void row_clicked(object sender, RoutedEventArgs e)
        {
            kurs = courses.SelectedItem as Kurs;
            //GeneratorDanych.DodajZamienniki(kurs);
            name.Text = kurs.Nazwa_kursu;
            code.Content = "Kod kursu: "+kurs.Kod_kursu;
            type.Content = "Typ zajęć: "+kurs.Forma_kursu;
            ects.Content = "Liczba punktów ECTS: "+kurs.Punkty_ECTS;
            if (kurs.Czy_egzamin) exam.Content = "Zakończony egzaminem. ";
            else exam.Content = "Kończy się zaliczeniem. ";
            hours.Content ="ZZU (całkowity nakład pracy):" + kurs.ZZU.ToString();

            Zamienniki.ItemsSource = kurs.Zamienniki;
            detailsGrid.Visibility = Visibility.Visible;
            //plans

            details.Visibility =Visibility.Visible ;
        }

        private void Zamienniki_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var zamiennik = Zamienniki.SelectedItem as Zamiennik_kursu;
            PodgladZamiennika podglad = new PodgladZamiennika(zamiennik);
            podglad.ShowDialog();
        }
    }
}
