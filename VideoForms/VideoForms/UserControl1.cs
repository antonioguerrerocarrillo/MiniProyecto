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
    public partial class UserControl1 : UserControl {
        static double subtotal;
        static int cantidad;
        public UserControl1 () {
            InitializeComponent();
        }
        public void setsubtotal (double sub) {
            subtotal = sub;
        }
        static public double getsubtotal () {
            return subtotal;
        }
        static public int getcantidad () {
            return cantidad;
        }
        private void UserControl1_Load (object sender, EventArgs e) {

        }

        private void button1_Click (object sender, EventArgs e) {
            subtotal += 7;
            cantidad++;
        }

        private void button2_Click (object sender, EventArgs e) {
            subtotal += 15;
            cantidad++;
        }

        private void button3_Click (object sender, EventArgs e) {
            subtotal += 5;
            cantidad++;
        }
    }
}
