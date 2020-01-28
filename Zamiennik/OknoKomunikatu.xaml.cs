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
    /// Logika interakcji dla klasy OknoKomunikatu
    /// </summary>
    public partial class OknoKomunikatu : Window
    {
        public MessageBoxResult result;

        /// <summary>
        /// Konstruktor zwracający okno komunikatu z różnymi opcjami przycisków
        /// </summary>
        /// <param name="komunikat">Treść komunikatu</param>
        /// <param name="przyciski">Rodzaj przycisków</param>
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

        /// <summary>
        /// Konstruktor zwracający okno komunikatu z przyciskiem Ok
        /// </summary>
        /// <param name="komunikat">treść komunikatu</param>
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
