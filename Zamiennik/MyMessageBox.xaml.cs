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
    /// Logika interakcji dla klasy MyMessageBox.xaml
    /// </summary>
    public partial class MyMessageBox : Window
    {
        public MyMessageBox()
        {
            InitializeComponent();
        }

        public MyMessageBox(string komunikat, string przycisk1, string przycisk2)
        {
            InitializeComponent();
            this.komunikat.Text = komunikat;
            this.przycisk1.Content  = przycisk1;
            this.przycisk2.Content = przycisk1;

        }

        public MyMessageBox(string komunikat, string przycisk)
        {
            InitializeComponent();
            this.komunikat.Text = komunikat;
            this.przycisk1.Content = przycisk1;
            this.przycisk2.Visibility = Visibility.Collapsed;
        }

        public MyMessageBox(string komunikat)
        {
            InitializeComponent();
            this.komunikat.Text = komunikat;
            this.przycisk1.Content = "Ok";
            this.przycisk2.Visibility = Visibility.Collapsed;
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
