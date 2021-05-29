using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkList
{
    class Carrito
    {
        private string[] Productos = { "Pan Bimbo", "Coca-Cola 3L", "Aceite", "Pañales", "Barra de jabón", "Pasta de Dientes", "Cereal", "Leche", "Docena de Huevos", "Jamón", "Mayonesa", "Catsup", "Mostaza", "Galletas", "Cafe", "Atún", "Sardinas", "Avena", "Yogurt", "Jabon para lavabajillas"};
        private double[] precioWalmart = { 27.30, 40.56, 40.89, 200.99, 15.01, 25.65, 45.12, 23.54, 25.34, 30.87, 40.45, 20.32, 35.11, 60.01, 96.50,14.90,14,18.90,29.50,31.90};
        private double[] precioSoriana = { 27.87, 40.86, 38.34, 220.87, 15.12, 24.87, 45.54, 23.12, 24.91, 31.23, 39.96, 20.12, 36.78, 62.32, 97,15.90,16,17.90,28.90,30.90};
        private double[] precioChedraui = { 29.12, 41.45, 39.54, 240.87, 12.89, 26.54, 42.28, 25.97, 28.03, 28.09, 36.44, 18.29, 32.06, 61.71,98.90,16,15.90,18,30,30.90};
        private string nombre;
        public string[] Products
        {
            set { value = Productos; }
            get { return (Productos); }
        }
        public double[] priceW
        {
            set { value = precioWalmart; }
            get { return (precioWalmart); }
        }

        public double[] priceS
        {
            set { value = precioSoriana; }
            get { return (precioSoriana); }
        }

        public double[] priceC
        {
            set { value = precioChedraui; }
            get { return (precioChedraui); }
        }

        public string nom
        {
            set { value = nombre; }
            get { return (nombre); }
        }
        public void obtener(string nombreP)
        {
            nombre = nombreP;
        }
    }
}
