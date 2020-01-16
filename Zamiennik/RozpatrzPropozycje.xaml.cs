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

namespace Zamiennik
{
    /// <summary>
    /// Logika interakcji dla klasy RozpatrzPropozycje.xaml
    /// </summary>
    public partial class RozpatrzPropozycje : Window
    {
        Propozycja_zamiennika propozycja = new Propozycja_zamiennika(new Kurs()
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
        }, new List<Kurs>()
        );

        public RozpatrzPropozycje()
        {
            InitializeComponent();
            propozycja.Kurs_zastepujacy.Add(
                new Kurs()
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
            k1Nazwa.Content = propozycja.Kurs_zastepowany.Nazwa_kursu;
            k1Typ.Content = "Typ semestru: "+propozycja.Kurs_zastepowany.Typ_semestru;

            k1Ects.Content = "Punkty ECTS: "+propozycja.Kurs_zastepowany.Punkty_ECTS.ToString();
            k1Plan.Text = "W8, Informatyka 2017/2018";
            k1Efekty.Text = "XYZ";


            k2Nazwa.Content = propozycja.Kurs_zastepujacy[0].Nazwa_kursu;
            k2Typ.Content = "Typ semestru: " + propozycja.Kurs_zastepujacy[0].Typ_semestru;

            k2Ects.Content = "Punkty ECTS: "+ propozycja.Kurs_zastepujacy[0].Punkty_ECTS.ToString();
            k2Plan.Text = "W8, Informatyka 2017/2018";
            k2Efekty.Text = "XYZ";
        }

        private void Accept_Button_Click(object sender, RoutedEventArgs e)
        {
            if (check_if_comment() == false)
            {
                MessageBox.Show("Należy dodać komentarz! ");
                return;
            }
            MessageBoxResult result = MessageBox.Show("Czy zaakceptować propozycję? \n Decyzja jest nieodwracalna", "Potwierdzenie", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                //zaakceptujPropozycje
                MessageBox.Show("Propozycja zaakceptowana");
                DialogResult = false;
                this.Hide();


            }
            else if (result == MessageBoxResult.No)
            {
                
            }

        }

        private void Reject_Button_Click(object sender, RoutedEventArgs e)
        {
            if (check_if_comment() == false)
            {
                MessageBox.Show("Należy dodać komentarz! ");
                return;
            }
            MessageBoxResult result = MessageBox.Show("Czy odrzucić propozycję? \n Decyzja jest nieodwracalna", "Potwierdzenie", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                //odrzucPropozycje
                MessageBox.Show("Propozycja odrzucona");
                DialogResult = false;
                this.Hide();


            }
            else if (result == MessageBoxResult.No)
            {

            }

        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBoxResult result = MessageBox.Show("Czy anulować rozważanie propozycji? \n Treść komentarza nie zostanie zapisana", "Potwierdzenie", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                //odrzucPropozycje
                MessageBox.Show("Anulowano");
                DialogResult = false;
                this.Hide();


            }
            else if (result == MessageBoxResult.No)
            {

            }

        }

        private bool check_if_comment()
        {
            string comment = komentarz.Text;
            if (comment == null||comment=="")
                return false;
            else
                return true;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Cancel_Button_Click(sender, null);
            e.Cancel = true;
        }
    }
}
