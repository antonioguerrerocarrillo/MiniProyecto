namespace VideoForms {
    partial class UserControlFactura {
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(402, 200);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pagar con tarjeta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(673, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(402, 198);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pagar en efectivo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(43, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(562, 359);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // UserControlFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "UserControlFactura";
            this.Size = new System.Drawing.Size(1078, 437);
            this.Load += new System.EventHandler(this.UserControlFactura_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
    }
}
