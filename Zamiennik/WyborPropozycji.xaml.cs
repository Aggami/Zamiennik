using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Logika interakcji dla klasy WyborPropozycji.xaml
    /// </summary>
    public partial class WyborPropozycji : Window
    {
        ObservableCollection<Propozycja_zamiennika> propozycje;

        public WyborPropozycji()
        {
            InitializeComponent();
            propozycje = new ObservableCollection<Propozycja_zamiennika>(ZarzadzaniePropozycja.znajdzDostepnePropozycje());
            Propozycje.ItemsSource = propozycje;
        }

        private void Propozycje_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var propozycja = Propozycje.SelectedItem as Propozycja_zamiennika;
            RozpatrzPropozycje podglad = new RozpatrzPropozycje(propozycja);
            podglad.ShowDialog();
            Propozycje.ItemsSource= new ObservableCollection<Propozycja_zamiennika>(ZarzadzaniePropozycja.znajdzDostepnePropozycje());
            
        }
    }
}
