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
using Uslugi;

namespace Zamiennik
{
    /// <summary>
    /// Logika interakcji dla klasy RozpatrzPropozycje.xaml
    /// </summary>
    public partial class RozpatrzPropozycje : Window
    {
        Propozycja_zamiennika propozycja;

        public RozpatrzPropozycje(Propozycja_zamiennika propozycja)
        {
            InitializeComponent();
            this.propozycja = propozycja;
            k1Nazwa.Content = propozycja.Kurs_zastepowany.Nazwa_kursu;
            k1Typ.Content = "Typ semestru: " + Slownik.Forma_Kursu(propozycja.Kurs_zastepowany.Forma_kursu);

            k1Ects.Content = "Punkty ECTS: " + propozycja.Kurs_zastepowany.Punkty_ECTS.ToString();
            k1ZZU.Content = "Liczba godzin w semestrze: "+ propozycja.Kurs_zastepowany.ZZU.ToString();
            k1Plan.Text = propozycja.Kurs_zastepowany.Plan_studiow.ToString();
            k1Efekty.Text = propozycja.Kurs_zastepowany.EfektyToString();


            k2Nazwa.Content = propozycja.Kurs_zastepujacy.Nazwa_kursu;
            k2Typ.Content = "Typ semestru: " + Slownik.Forma_Kursu(propozycja.Kurs_zastepujacy.Forma_kursu);

            k2Ects.Content = "Punkty ECTS: " + propozycja.Kurs_zastepujacy.Punkty_ECTS.ToString();
            k2ZZU.Content = "Liczba godzin w semestrze: " + propozycja.Kurs_zastepujacy.ZZU.ToString();
            k2Plan.Text = propozycja.Kurs_zastepujacy.Plan_studiow.ToString();
            k2Efekty.Text = propozycja.Kurs_zastepujacy.EfektyToString();
        }

        private void Accept_Button_Click(object sender, RoutedEventArgs e)
        {
            if (check_if_comment() == false)
            {
                Komunikat.Show("Należy dodać komentarz! ");
                return;
            }

            MessageBoxResult result = Komunikat.ShowWithResult("Czy zaakceptować propozycję? \n Decyzja jest nieodwracalna", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                ZarzadzaniePropozycja.zaakceptujPropozycje(propozycja, komentarz.Text);
                Komunikat.Show("Propozycja zaakceptowana");
                DialogResult = false;
                komentarz.Clear();
                this.Hide();


            }

        }

        private void Pokaz_karty_Przedmiotow_Button_Click(object sender, RoutedEventArgs e)
        {
            string sciezka1=null;
            string sciezka2=null;
            if (!(propozycja.Kurs_zastepowany.Karta_przedmiotu == null))
            {
                sciezka1 = ObslugaPDF.zapisPdfDoSciezki(propozycja.Kurs_zastepowany);
            }
            else Komunikat.Show("Brak karty przedmiotu kursu zastępowanego.");
            if (!(propozycja.Kurs_zastepujacy.Karta_przedmiotu == null))
            {
                sciezka2 = ObslugaPDF.zapisPdfDoSciezki(propozycja.Kurs_zastepujacy);
            }
            else Komunikat.Show("Brak karty przedmiotu kursu zastępującego.");
            if ((sciezka1 != null) && (sciezka2 != null))
            {
                PodgladPDF podglad = new PodgladPDF(sciezka1, sciezka2);
                podglad.ShowDialog();
                return;
            }
            if ((sciezka1 != null) )
            {
                PodgladPDF podglad = new PodgladPDF(sciezka1);
                podglad.ShowDialog();
            }
            if ((sciezka2 != null))
            {
                PodgladPDF podglad = new PodgladPDF(sciezka2);
                podglad.ShowDialog();
            }
        }

        private void Reject_Button_Click(object sender, RoutedEventArgs e)
        {
            if (check_if_comment() == false)
            {
                Komunikat.Show("Należy dodać komentarz! ");
                return;
            }

            MessageBoxResult result = Komunikat.ShowWithResult("Czy odrzucić propozycję? \n Decyzja jest nieodwracalna", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                ZarzadzaniePropozycja.odrzucPropozycje(propozycja, komentarz.Text);
                Komunikat.Show("Propozycja odrzucona");
                DialogResult = false;
                komentarz.Clear();
                this.Hide();


            }

        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
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
            if (komentarz.Text==null||komentarz.Text=="") {
                MessageBoxResult result = Komunikat.ShowWithResult("Czy anulować rozważanie propozycji? \n Treść komentarza nie zostanie zapisana", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    //odrzucPropozycje
                    Komunikat.Show("Anulowano");
                    DialogResult = false;
                    this.Hide();


                }
                e.Cancel = true;
            }
        }
    }
}


