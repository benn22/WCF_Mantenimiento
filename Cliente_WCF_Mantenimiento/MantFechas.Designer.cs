namespace Cliente_WCF_Mantenimiento
{
    partial class MantFechas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgVendedor = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idMantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fec_fac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVendedor
            // 
            this.dtgVendedor.AllowUserToAddRows = false;
            this.dtgVendedor.AllowUserToDeleteRows = false;
            this.dtgVendedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVendedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMantenimiento,
            this.idVehiculo,
            this.Num_Factura,
            this.EstadoFactura,
            this.fec_fac});
            this.dtgVendedor.Location = new System.Drawing.Point(34, 87);
            this.dtgVendedor.Name = "dtgVendedor";
            this.dtgVendedor.ReadOnly = true;
            this.dtgVendedor.RowHeadersVisible = false;
            this.dtgVendedor.RowTemplate.Height = 25;
            this.dtgVendedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVendedor.Size = new System.Drawing.Size(916, 301);
            this.dtgVendedor.TabIndex = 71;
            this.dtgVendedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVendedor_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(774, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 70;
            this.label8.Text = "Registros:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(838, 416);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(112, 25);
            this.lblRegistros.TabIndex = 66;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(838, 36);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 62;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(408, 32);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(100, 23);
            this.dtpFecFin.TabIndex = 61;
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIni.Location = new System.Drawing.Point(93, 32);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(100, 23);
            this.dtpFecIni.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 59;
            this.label3.Text = "F. Fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 58;
            this.label2.Text = "F. Inicio:";
            // 
            // idMantenimiento
            // 
            this.idMantenimiento.DataPropertyName = "idMantenimiento";
            this.idMantenimiento.HeaderText = "Mantenimiento";
            this.idMantenimiento.Name = "idMantenimiento";
            this.idMantenimiento.ReadOnly = true;
            // 
            // idVehiculo
            // 
            this.idVehiculo.DataPropertyName = "idVehiculo";
            this.idVehiculo.HeaderText = "Vehiculo";
            this.idVehiculo.Name = "idVehiculo";
            this.idVehiculo.ReadOnly = true;
            // 
            // Num_Factura
            // 
            this.Num_Factura.DataPropertyName = "Num_Factura";
            this.Num_Factura.HeaderText = "N° Factura";
            this.Num_Factura.Name = "Num_Factura";
            this.Num_Factura.ReadOnly = true;
            // 
            // EstadoFactura
            // 
            this.EstadoFactura.DataPropertyName = "EstadoFactura";
            this.EstadoFactura.HeaderText = "Estado Factura";
            this.EstadoFactura.Name = "EstadoFactura";
            this.EstadoFactura.ReadOnly = true;
            // 
            // fec_fac
            // 
            this.fec_fac.DataPropertyName = "fec_fac";
            this.fec_fac.HeaderText = "Fecha Fact.";
            this.fec_fac.Name = "fec_fac";
            this.fec_fac.ReadOnly = true;
            // 
            // MantFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 510);
            this.Controls.Add(this.dtgVendedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtpFecFin);
            this.Controls.Add(this.dtpFecIni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "MantFechas";
            this.Text = "MantFechas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgVendedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMantenimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn fec_fac;
    }
}