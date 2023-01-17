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

namespace mail
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void but_km_Click(object sender, RoutedEventArgs e)
        {
            float miles = float.Parse(input_text.Text);

            float km = miles * 1.609f;
            input_text.Text = km.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            float km = float.Parse(input_text.Text);

            float miles = km * 0.62137119f;
            input_text.Text = miles.ToString();
        }



        /*private void but_km_Click(object sender, RoutedEventArgs e)
        {
            float miles = float.Parse(textbox.Text);

            float km = miles * 1.609f;
            textbox.Text = km.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            float km = float.Parse(textbox.Text);

            float miles = km * 0.62137119f;
            textbox.Text = miles.ToString();
        } */
    }
}