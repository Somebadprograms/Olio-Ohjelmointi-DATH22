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

namespace wpfapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int autoja;
        int  kuormaautoja;
        string autoja1;

        string kuormaautoja1;

        string käyttäjännimi;
        public MainWindow()
        {
            InitializeComponent();
            
            
        }

        private void btn_EkaNappi_Click(object sender, RoutedEventArgs e)
        {
            autoja++;

            //tallennet<an muuttujaan
            TXT_EkaTeksti.Text = "Autoja on " + autoja;
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            kuormaautoja++;

            TXT_TokaTeksti.Text = "Kuormaautoja on: " + kuormaautoja;
        }
    }
}
