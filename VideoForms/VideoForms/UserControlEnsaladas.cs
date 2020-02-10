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
    public partial class UserControlEnsaladas : UserControl {
        static public double subtotal;
        static int cantidad;
        public UserControlEnsaladas () {
            InitializeComponent();
            subtotal = 0.0;
        }
        public void setSubtotal (double sub) {
            subtotal += sub;
        }
        public static double getsubtotal () {
            return subtotal;
        }
        public static int getcantidad () {
            return cantidad;
        }
        private void UserControlEnsaladas_Load (object sender, EventArgs e) {

        }

        private void button1_Click (object sender, EventArgs e) {
            subtotal += 7;
            cantidad++;
        }

        private void button2_Click (object sender, EventArgs e) {
            subtotal += 7.5;
            cantidad++;
        }

        private void button3_Click (object sender, EventArgs e) {
            subtotal += 7;
            cantidad++;
        }
    }
}
