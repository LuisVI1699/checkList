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
    /// Lógica de interacción para chedrauiPage.xaml
    /// </summary>
    public partial class chedrauiPage : Page
    {
        Carrito A = new Carrito();
        ComboBox Box;
        double precio, total;
        String aux, aux1;
        MainWindow B = new MainWindow();
        public chedrauiPage()
        {
            InitializeComponent();
            Generar();
            tbbienvenida.Text = "Hola " + B.nombre + "selecciona tus productos";
        }
       
        public void Generar()
        {
            lblista.Items.Add("  Unidades                                  Producto                                      Total  ");
            Box = new ComboBox();
            for (int i = 0; i < 20; i++)
            {
                Box.Items.Add(A.Products[i]);
            }
            Box.Margin = new Thickness(73, 82, 0, 0);
            Box.HorizontalAlignment = HorizontalAlignment.Left;
            Box.VerticalAlignment = VerticalAlignment.Top;
            Box.Width = 200;
            Box.Height = 33;
            Box.FontFamily = new FontFamily("Microsoft YaHei");
            Box.FontSize = 16;
            Box.Text = "Seleccionar";
            Box.SelectionChanged += Checked;
            grid1.Children.Add(Box);

        }

        private void bttotal_Click(object sender, RoutedEventArgs e)
        {
            lblista.Items.Add("El total de su lista es: " + total);
        }

        public void Checked(object sender, SelectionChangedEventArgs e)
        {
            tbproduct.Text = Box.SelectedItem.ToString();

        }

        private void btagregar_Click(object sender, RoutedEventArgs e)
        {
            try { 
            aux1 = tbproduct.Text;

            for (int i = 0; i < (50 - aux1.Length); i++)
            {
                aux += " ";
            }
            precio = A.priceC[Convert.ToInt32(Box.SelectedIndex)];
            lblista.Items.Add("        " + tbunidades.Text + "                                         " + tbproduct.Text + aux + precio * double.Parse(tbunidades.Text));
            total += precio * double.Parse(tbunidades.Text);
            
            }
            catch
            {
                MessageBox.Show("Ingresa una cantidad del producto");
            }
            aux = "";
        }
    }
}
