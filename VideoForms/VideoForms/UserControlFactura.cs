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
    public partial class UserControlFactura : UserControl {
        public UserControlFactura () {
            InitializeComponent();
        }

        private void button1_Click (object sender, EventArgs e) {
            //FormFactura factura = new FormFactura();
            UserControlFacturaBuena bb = null;
            bb.Visible = true;
        }

        private void button2_Click (object sender, EventArgs e) {
            UserControlFacturaBuena bb = null;
            bb.Visible = true;
        }

        private void UserControlFactura_Load (object sender, EventArgs e) {

        }
    }
}
