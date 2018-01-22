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

namespace Navigation
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }
        private void Site1(object sender, RoutedEventArgs e)=> site.Navigate("https://habrahabr.ru/");

        private void Site2(object sender, RoutedEventArgs e)=> site.Navigate("https://metanit.com/");

        private void Site3(object sender, RoutedEventArgs e)=> site.Navigate("https://keddr.com/");
     

      
       
    }
}
