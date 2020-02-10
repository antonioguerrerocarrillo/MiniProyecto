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
    public partial class UserControl2 : UserControl {
        static double subtotal;
        static int cantidad;
         public UserControl2 () {
            InitializeComponent();
        }
        public UserControl2 (double sub) {
            subtotal = sub;
            InitializeComponent();
        }
        public void setsubtotal (double sub) {
            subtotal = sub;
        }
        public static double getsubtotal () {
            return subtotal;
        }
        public static int getcantidad () {
            return cantidad;
        }
        private void pictureBox6_Click (object sender, EventArgs e) {

        }

        private void button4_Click (object sender, EventArgs e) {
            subtotal += 2;
            cantidad++;
        }

        private void UserControl2_Load (object sender, EventArgs e) {

        }

        private void button6_Click (object sender, EventArgs e) {
            subtotal += 2;
            cantidad++;
        }

        private void button5_Click (object sender, EventArgs e) {
            subtotal += 2;
            cantidad++;
        }

        private void button1_Click (object sender, EventArgs e) {
            subtotal += 2;
            cantidad++;
        }

        private void button2_Click (object sender, EventArgs e) {
            subtotal += 2;
        }

        private void button3_Click (object sender, EventArgs e) {
            subtotal += 2;
        }
    }
}
