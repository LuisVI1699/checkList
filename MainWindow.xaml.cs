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

namespace checkList
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public auxWindow vtn1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void walmartButton_Click(object sender, RoutedEventArgs e)
        {
            vtn1 = new auxWindow();
            vtn1.frame1.NavigationService.Navigate(new walmartPagexaml());
            vtn1.Show();
            Close();

        }

        private void chedrauiButton_Click(object sender, RoutedEventArgs e)
        {
            vtn1 = new auxWindow();
            vtn1.frame1.NavigationService.Navigate(new chedrauiPage());
            vtn1.Show();
            Close();
        }

        private void sorianaButton_Click(object sender, RoutedEventArgs e)
        {
            vtn1 = new auxWindow();
            vtn1.frame1.NavigationService.Navigate(new sorianaPage());
            vtn1.Show();
            Close();
        }
    }
}
