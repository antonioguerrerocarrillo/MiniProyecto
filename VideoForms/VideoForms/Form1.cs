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
    public partial class Form1 : Form {
        static double total, subtotal;
        static int sumatoria;
        public Form1 () {
            Console.WriteLine("hola constructor");
            InitializeComponent();
            sumatoria = 0;
            SidePanel.Height = button1.Height;
            firstCustomControl1.BringToFront();
            //sumar();
        }
       public void setSubtotal (double sub) {
            subtotal = sub;
        }
        public static double getsubtotal () {
            return subtotal;
        }
        private void panel3_Paint (object sender, PaintEventArgs e) {

        }

        private void label3_Click (object sender, EventArgs e) {

        }

        private void panel1_Paint (object sender, PaintEventArgs e) {

        }
        private void sumar () {
            subtotal = UserControlPollo.subtotal + UserControl2.getsubtotal() + UserControl1.getsubtotal() + UserControlEnsaladas.getsubtotal();
            textBox1.Text = subtotal.ToString();
        }
        private void button1_Click (object sender, EventArgs e) {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            userControl21.BringToFront();
            sumar();

        }

        private void SidePanel_Paint (object sender, PaintEventArgs e) {
        }

        private void button4_Click (object sender, EventArgs e) {
            userControl21.Visible = true;
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            userControl21.BringToFront();
            sumar();
        }

        private void firstCustomControl1_Load (object sender, EventArgs e) {

        }

        private void button11_Click (object sender, EventArgs e) {
            this.Close();
        }

        private void button11_Click_1 (object sender, EventArgs e) {
            this.Close();
        }

        private void button15_Click (object sender, EventArgs e) {
            userControlCesta3.Visible = true;
            SidePanel.Height = button15.Height;
            //Console.WriteLine("hola el subtotal es " + subtotal + "total " + total);
            userControlCesta3.settotal(subtotal);
            SidePanel.Top = button15.Top;            
            userControlCesta3.BringToFront();

        }
        public void cerrarApp () {
            this.Close();
        }
        private void button2_Click (object sender, EventArgs e) {
            userControl12.Visible = true;
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            sumar();
            userControl12.BringToFront();

        }

        private void userControl21_Load (object sender, EventArgs e) {

        }

        private void button3_Click (object sender, EventArgs e) {
            userControlPollo1.Visible = true;
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            sumar();
            userControlPollo1.BringToFront();
            
        }

        private void userControlPollo1_Load (object sender, EventArgs e) {

        }

        private void Form1_Load (object sender, EventArgs e) {

        }

        private void userControlPollo1_Load_1 (object sender, EventArgs e) {

        }

        private void userControlCesta3_Load (object sender, EventArgs e) {

        }

        private void button5_Click (object sender, EventArgs e) {
            userControlEnsaladas1.Visible = true;
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            sumar();
            userControlEnsaladas1.BringToFront();
        }
        public static int getTotalEnsalada () {
            return sumatoria;
        
        }
        private void userControlEnsaladas1_Load (object sender, EventArgs e) {
            sumatoria += 1;
        }

        private void userControlPollo1_Load_2 (object sender, EventArgs e) {
           
        }
    }
}
