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
    public partial class OknoKomunikatu : Window
    {
        public MessageBoxResult result;

        public OknoKomunikatu()
        {
            InitializeComponent();
        }

        public OknoKomunikatu(string komunikat, MessageBoxButton przyciski)
        {
            InitializeComponent();
            this.komunikat.Text = komunikat;

            if (przyciski == MessageBoxButton.YesNo)
            {
                this.yesButton.Visibility = Visibility.Visible;
                this.noButton.Visibility = Visibility.Visible;
                this.okButton.Visibility = Visibility.Collapsed;

            }
            if (przyciski == MessageBoxButton.OK)
            {
                this.yesButton.Visibility = Visibility.Collapsed;
                this.noButton.Visibility = Visibility.Collapsed;
                this.okButton.Visibility = Visibility.Visible;
            }
            

        }

        public OknoKomunikatu(string komunikat)
        {
            InitializeComponent();
            this.komunikat.Text = komunikat;

           this.yesButton.Visibility = Visibility.Collapsed;
           this.noButton.Visibility = Visibility.Collapsed;
           this.okButton.Visibility = Visibility.Visible;
            

        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            result = MessageBoxResult.Yes;
            this.Hide();
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            result = MessageBoxResult.No;
            this.Hide();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            result = MessageBoxResult.OK;
            this.Hide();
        }

    }
}
