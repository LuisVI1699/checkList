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
        string[] Productos = { "Pan Bimbo", "Coca-Cola 3L", "Aceite", "Pañales", "Barra de jabón", "Pasta de Dientes", "Cereal", "Leche", "Docena de Huevos", "Jamón", "Mayonesa", "Catsup", "Mostaza", "Galletas" };
        double[] precioChedraui = { 29.12, 41.45, 39.54, 240.87, 12.89, 26.54, 42.28, 25.97, 28.03, 28.09, 36.44, 18.29, 32.06, 61.71 };
        public chedrauiPage()
        {
            InitializeComponent();
        }
    }
}
