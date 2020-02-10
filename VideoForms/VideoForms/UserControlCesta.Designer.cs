namespace VideoForms {
    partial class UserControlCesta {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent () {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Pagar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Productos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(224, 361);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 42);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Pagar
            // 
            this.Pagar.Location = new System.Drawing.Point(632, 3);
            this.Pagar.Name = "Pagar";
            this.Pagar.Size = new System.Drawing.Size(443, 218);
            this.Pagar.TabIndex = 1;
            this.Pagar.Text = "Pagar con tarjeta";
            this.Pagar.UseVisualStyleBackColor = true;
            this.Pagar.Click += new System.EventHandler(this.Pagar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Productos,
            this.Precio,
            this.Cantidad});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(623, 222);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Productos
            // 
            this.Productos.Tag = "";
            this.Productos.Text = "Nombre del Producto";
            this.Productos.Width = 153;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            this.Precio.Width = 91;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Width = 163;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(443, 216);
            this.button1.TabIndex = 17;
            this.button1.Text = "Pagar efectivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControlCesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pagar);
            this.Controls.Add(this.textBox1);
            this.Name = "UserControlCesta";
            this.Size = new System.Drawing.Size(1078, 437);
            this.Load += new System.EventHandler(this.UserControlCesta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Pagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Productos;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.Button button1;
    }
}
