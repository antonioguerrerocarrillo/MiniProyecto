using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoForms {
    public partial class FormFacturas : Form {
        double total;
        int numeroPedido, cantidad;
        string[] nombre;
        char[] palabrasAdivinadas;
        string palabraSeleccionada;
        public FormFacturas () {
            InitializeComponent();
            Random ramdom = new Random();
            numeroPedido = ramdom.Next(1, 150);

        }
        public FormFacturas (double tot, int can, string nomb) {
            total = tot;
            Random ramdom = new Random();
            numeroPedido = ramdom.Next(1, 150);
            nombre = new string[] { "infante", "carrasco", "nieto", "mateo", "olivencia", "pablo" };
            int iniciarPalabraSeleccionada = ramdom.Next(0, nombre.Length);
            palabraSeleccionada = nombre[iniciarPalabraSeleccionada];
            InitializeComponent();

        }
        private void FormFacturas_Load (object sender, EventArgs e) {
            /*label1.Text = ClassFactura.Total.ToString();
            label2.Text = ClassFactura.Cantidad.ToString();
            label3.Text = ClassFactura.Nombre;*/
            //if (cantidad >= 1) {
                label1.Text = total.ToString();
                label3.Text = numeroPedido.ToString();
                label2.Text = palabraSeleccionada;
            //}
        }
    }
}
