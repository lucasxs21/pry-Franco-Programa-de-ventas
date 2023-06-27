namespace pry_Franco_Programa_de_ventas
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btnCargarventa = new System.Windows.Forms.Button();
            this.txtKilos = new System.Windows.Forms.TextBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblKilos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbVendedor.Location = new System.Drawing.Point(71, 42);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(100, 21);
            this.cmbVendedor.TabIndex = 2;
            this.cmbVendedor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(92, 135);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(56, 18);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "VENTA";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(6, 50);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(59, 13);
            this.lblVendedor.TabIndex = 5;
            this.lblVendedor.Text = "Vendedor :";
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(71, 92);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(100, 20);
            this.dtp.TabIndex = 7;
            this.dtp.Value = new System.DateTime(2023, 6, 23, 0, 0, 0, 0);
            // 
            // btnCargarventa
            // 
            this.btnCargarventa.Enabled = false;
            this.btnCargarventa.Location = new System.Drawing.Point(71, 278);
            this.btnCargarventa.Name = "btnCargarventa";
            this.btnCargarventa.Size = new System.Drawing.Size(100, 23);
            this.btnCargarventa.TabIndex = 8;
            this.btnCargarventa.Text = "Cargar venta ";
            this.btnCargarventa.UseVisualStyleBackColor = true;
            this.btnCargarventa.Click += new System.EventHandler(this.btnCargarventa_Click);
            // 
            // txtKilos
            // 
            this.txtKilos.Location = new System.Drawing.Point(71, 228);
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.Size = new System.Drawing.Size(100, 20);
            this.txtKilos.TabIndex = 10;
            this.txtKilos.TextChanged += new System.EventHandler(this.txtKilos_TextChanged);
            this.txtKilos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKilos_KeyPress);
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbProducto.Location = new System.Drawing.Point(71, 172);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(100, 21);
            this.cmbProducto.TabIndex = 12;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(6, 98);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(6, 180);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 14;
            this.lblProducto.Text = "Producto:";
            // 
            // lblKilos
            // 
            this.lblKilos.AutoSize = true;
            this.lblKilos.Location = new System.Drawing.Point(6, 235);
            this.lblKilos.Name = "lblKilos";
            this.lblKilos.Size = new System.Drawing.Size(32, 13);
            this.lblKilos.TabIndex = 15;
            this.lblKilos.Text = "Kilos:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(232, 323);
            this.Controls.Add(this.lblKilos);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.txtKilos);
            this.Controls.Add(this.btnCargarventa);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.cmbVendedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button btnCargarventa;
        private System.Windows.Forms.TextBox txtKilos;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblKilos;
    }
}

