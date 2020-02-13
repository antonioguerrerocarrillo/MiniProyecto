using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoForms {

    class ClassFactura {
        static double total;
        static int cantidad;
        static string nombre;

        public static string Nombre { get => nombre; set => nombre = value; }
        public static int Cantidad { get => cantidad; set => cantidad = value; }
        public static double Total { get => total; set => total = value; }
    }
}
