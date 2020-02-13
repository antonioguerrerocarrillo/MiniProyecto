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
    public partial class UserControlPollo : UserControl {
        public static double subtotal;
        static int cantidad;
        public UserControlPollo () {
            InitializeComponent();
            subtotal = 0.0;
    }
        public UserControlPollo (double sun) {
            subtotal = sun;
            InitializeComponent();
        }
        public void setSubtotal(double sub) {
            subtotal = sub;
        }
        public static double getsubtotal () {
            return subtotal;
        }
       public void setcantidad (int can) {
            cantidad = can;
        }
        public static int getcantidad () {
            return cantidad;
        }
        private void button3_Click (object sender, EventArgs e) {
            subtotal += 13.0;
            cantidad++;
            //cs.settotal(subtotal);
        }

        private void button1_Click (object sender, EventArgs e) {
            subtotal += 19;
            cantidad++;
        }

        private void button2_Click (object sender, EventArgs e) {
            subtotal += 7;
            cantidad++;
        }

        private void button6_Click (object sender, EventArgs e) {
            subtotal += 10;
            cantidad++;
        }

        private void button4_Click (object sender, EventArgs e) {
            subtotal += 9;
            cantidad++;
        }

        private void button5_Click (object sender, EventArgs e) {
            subtotal += 17;
            cantidad++;
        }

        private void UserControlPollo_Load (object sender, EventArgs e) {

        }
    }
}
