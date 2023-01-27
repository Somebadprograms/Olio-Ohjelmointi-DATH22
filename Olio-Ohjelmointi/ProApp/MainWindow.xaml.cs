using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
using static System.Net.Mime.MediaTypeNames;



namespace ProApp
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow: Window 
    {

        
            public MainWindow()
        {
            InitializeComponent();
            InitializeComponent();
            //Display your image in Image Control
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


           Input.Text = Luokka.Kyl();
            

           
                andrew.Visibility = Visibility.Collapsed;
          
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            andrew.Visibility = Visibility.Visible;
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string tumma = Input2.Text;

            Tetboxen.Text = tumma;
            

            
            

            
          


   
        }

    }
}
