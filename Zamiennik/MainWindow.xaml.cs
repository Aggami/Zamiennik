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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Dostep_Do_Danych;

namespace Zamiennik
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var db = new ZamiennikKontekst();
            MessageBox.Show(db.Database.Connection.ConnectionString);
            /*
            Kurs k =new Kurs()
            {
                Punkty_ECTS = 4,
                Czy_egzamin = true,
                Czy_aktywny = false,
                Forma_kursu = Forma_kursu.Laboratorium,
                //Karta_przedmiotu,
                Nazwa_kursu = "Projektowanie Oprogramowania",
                Kod_kursu = "KX327",
                ZZU = 180,
                Typ_semestru = Typ_semestru.Semestr_zimowy,
                Semestr = 5
            };
            
            db.Kursy.Add(k);*/
            db.SaveChanges();

            /*
            var query = from k in db.Kursy
                        orderby k.Nazwa_kursu
                        select k;
            string s = "";
            foreach (var q in query){
                s += q.Kod_kursu + " ";
            }
            MessageBox.Show(s);
            */
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IstniejaceZamienniki istniejace = new IstniejaceZamienniki();
            istniejace.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RozpatrzPropozycje rozpatrz = new RozpatrzPropozycje();
            rozpatrz.ShowDialog();
        }
    }
}
