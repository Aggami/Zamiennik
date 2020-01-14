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
        Propozycja propozycja = new Propozycja(new Kurs()
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
        }, new Kurs[]{new Kurs()
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
            }
        }
        );

        public RozpatrzPropozycje()
        {
            InitializeComponent();
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
