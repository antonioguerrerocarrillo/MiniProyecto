namespace VideoForms {
    partial class UserControlFacturaBuena {
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.Productos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(849, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 26);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Factura";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Productos,
            this.Precio,
            this.Cantidad});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(68, 117);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(679, 317);
            this.listView2.TabIndex = 17;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
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
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(764, 339);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(237, 95);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // UserControlFacturaBuena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "UserControlFacturaBuena";
            this.Size = new System.Drawing.Size(1078, 437);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader Productos;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ListView listView1;
    }
}
