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
    /// Lógica de interacción para sorianaPage.xaml
    /// </summary>
    public partial class sorianaPage : Page
    {
        string[] Productos = { "Pan Bimbo", "Coca-Cola 3L", "Aceite", "Pañales", "Barra de jabón", "Pasta de Dientes", "Cereal", "Leche", "Docena de Huevos", "Jamón", "Mayonesa", "Catsup", "Mostaza", "Galletas" };
        double[] precioSoriana = {27.87, 40.86, 38.34, 220.87, 15.12, 24.87, 45.54, 23.12, 24.91, 31.23, 39.96, 20.12, 36.78, 62.32 };
        public sorianaPage()
        {
            InitializeComponent();
        }
    }
}
