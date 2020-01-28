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
    /// Logika interakcji dla klasy PodgladPDF.xaml
    /// </summary>
    public partial class PodgladPDF : Window
    {
        public PodgladPDF(string sciezka1, string sciezka2)
        {
            InitializeComponent();
            PrzegladarkaPdf1.PdfPath = sciezka1;
            PrzegladarkaPdf2.PdfPath = sciezka2;
        }

        public PodgladPDF(string sciezka1)
        {
            InitializeComponent();
            PrzegladarkaPdf1.PdfPath = sciezka1;
            PrzegladarkaPdf2.Visibility = Visibility.Collapsed;
            this.Width = this.Width / 2;
        }
    }
}
