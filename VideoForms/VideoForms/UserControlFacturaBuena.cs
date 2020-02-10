using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoForms {
    public partial class UserControlFacturaBuena : UserControl {
        static double total;
        public UserControlFacturaBuena () {
            InitializeComponent();
            this.Visible = true;
        }
        void funcionSumarHamburgesa () {
            if (UserControl1.getcantidad() >= 1) {
                string[] elemnto = new string[3];
                ListViewItem elemnto1;
                elemnto[0] = "Hamburguesa";
                elemnto[1] = UserControl1.getsubtotal().ToString();
                elemnto[2] = UserControl1.getcantidad().ToString();
                elemnto1 = new ListViewItem(elemnto);
                listView1.Items.Add(elemnto1);
            }
        }
        void funcionSumarPollo () {
            if (UserControlPollo.getcantidad() >= 1) {
                string[] elemnto = new string[3];
                ListViewItem elemnto1;
                elemnto[0] = "Pollo";
                elemnto[1] = UserControlPollo.getsubtotal().ToString();
                elemnto[2] = UserControlPollo.getcantidad().ToString();
                elemnto1 = new ListViewItem(elemnto);
                listView1.Items.Add(elemnto1);
            }
        }
        void funcionSumarEnsalada () {
            if (UserControlEnsaladas.getcantidad() >= 1) {
                string[] elemnto = new string[3];
                ListViewItem elemnto1;
                elemnto[0] = "Ensalada";
                elemnto[1] = UserControlEnsaladas.getsubtotal().ToString();
                elemnto[2] = UserControlEnsaladas.getcantidad().ToString();
                elemnto1 = new ListViewItem(elemnto);
                listView1.Items.Add(elemnto1);
            }
        }
        void funcionSumarBebida () {
            if (UserControl2.getsubtotal() > 1) {
                string[] elemnto = new string[3];
                ListViewItem elemnto1;
                elemnto[0] = "Bebida";
                elemnto[1] = UserControl2.getsubtotal().ToString();
                elemnto[2] = UserControl2.getcantidad().ToString();
                elemnto1 = new ListViewItem(elemnto);
                listView1.Items.Add(elemnto1);
            }
        }
        private void listView2_SelectedIndexChanged (object sender, EventArgs e) {

        }
        public void ponerVisible () {
            this.Visible = true;
        }
        public void settotal (double sub) {
            total = sub;
            //textBox1.Text = total.ToString();
            funcionSumarHamburgesa();
            funcionSumarPollo();
            funcionSumarEnsalada();
            funcionSumarBebida();
            Console.WriteLine("estoy en el set " + total);
        }
    }
}
