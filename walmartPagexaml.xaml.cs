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
    /// Lógica de interacción para walmartPagexaml.xaml
    /// </summary>
    public partial class walmartPagexaml : Page
    {
        string[] Productos = { "Pan Bimbo", "Coca-Cola 3L", "Aceite", "Pañales", "Barra de jabón", "Pasta de Dientes", "Cereal", "Leche", "Docena de Huevos", "Jamón", "Mayonesa", "Catsup", "Mostaza", "Galletas" };
        double[] precioWalmart = { 27.30, 40.56, 40.89, 200.99, 15.01, 25.65, 45.12, 23.54, 25.34, 30.87, 40.45, 20.32, 35.11, 60.01 };
        public walmartPagexaml()
        {
            InitializeComponent();
        }
    }
}
