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
        List<Listacarrito> listali = new List<Listacarrito>();
        public class Listacarrito
        {
            public string Unidades { get; set; }
            public string Productos { get; set; }
            public string Precio { get; set; }
        }
        public chedrauiPage()
        {
            InitializeComponent();
            Generar();
            tbbienvenida.Text = "Hola " + A.nom + "selecciona tus productos";
        }
       
        public void Generar()
        {
            listali.Add(new Listacarrito() { Unidades = "Unidades", Productos = "Producto", Precio = "Total" });
            Box = new ComboBox();
            for (int i = 0; i < 20; i++)
            {
                Box.Items.Add(A.Products[i]);
            }
            Box.Margin = new Thickness(30, 83, 0, 0);
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
            listali.Add(new Listacarrito() { Unidades = "------------------------------------------------------------", Productos = "----------------------------------------------------", Precio = "------------------------------------------------" });
            listali.Add(new Listacarrito() { Unidades = "El precio total de sus prod", Productos = "uctos es: ----------------------------------------", Precio = " " + Convert.ToString(total) + "$" });
            lblista.Items.Refresh();
        }

        public void Checked(object sender, SelectionChangedEventArgs e)
        {
            tbproduct.Text = Box.SelectedItem.ToString();

        }

        private void btagregar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                precio = A.priceC[Convert.ToInt32(Box.SelectedIndex)];

                listali.Add(new Listacarrito() { Unidades = tbunidades.Text, Productos = tbproduct.Text, Precio = Convert.ToString(precio * double.Parse(tbunidades.Text)) });

                lblista.ItemsSource = listali;
                lblista.Items.Refresh();

                total += precio * double.Parse(tbunidades.Text);

            }
            catch
            {
                MessageBox.Show("Ingresa una cantidad del producto");
            }
        }
    }
}
