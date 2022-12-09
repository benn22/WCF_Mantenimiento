namespace Cliente_WCF_Mantenimiento
{
    partial class VehiculoFechas
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
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Fec_Mant_Inic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_Mant_Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMecanico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_mec = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Fec_Mant_Inic,
            this.Fec_Mant_Fin,
            this.TipoMantenimiento,
            this.idMecanico,
            this.Nom_mec});
            this.dtgVendedor.Location = new System.Drawing.Point(34, 108);
            this.dtgVendedor.Name = "dtgVendedor";
            this.dtgVendedor.ReadOnly = true;
            this.dtgVendedor.RowHeadersVisible = false;
            this.dtgVendedor.RowTemplate.Height = 25;
            this.dtgVendedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVendedor.Size = new System.Drawing.Size(916, 301);
            this.dtgVendedor.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(774, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Registros:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(596, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Tipo Unidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Marca:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSueldo.Location = new System.Drawing.Point(676, 56);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(112, 25);
            this.lblSueldo.TabIndex = 26;
            // 
            // lblRegistros
            // 
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(838, 428);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(112, 25);
            this.lblRegistros.TabIndex = 25;
            // 
            // lblDni
            // 
            this.lblDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDni.Location = new System.Drawing.Point(461, 56);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(112, 25);
            this.lblDni.TabIndex = 24;
            // 
            // lblNombres
            // 
            this.lblNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombres.Location = new System.Drawing.Point(120, 56);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(250, 25);
            this.lblNombres.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Datos Cliente:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(875, 18);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 19;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(676, 16);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(100, 23);
            this.dtpFecFin.TabIndex = 18;
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIni.Location = new System.Drawing.Point(361, 16);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(100, 23);
            this.dtpFecIni.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "F. Fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "F. Inicio:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(120, 12);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 23);
            this.txtCod.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Vehiculo:";
            // 
            // Fec_Mant_Inic
            // 
            this.Fec_Mant_Inic.DataPropertyName = "Fec_Mant_Inic";
            this.Fec_Mant_Inic.HeaderText = "Inicio Mant";
            this.Fec_Mant_Inic.Name = "Fec_Mant_Inic";
            this.Fec_Mant_Inic.ReadOnly = true;
            // 
            // Fec_Mant_Fin
            // 
            this.Fec_Mant_Fin.DataPropertyName = "Fec_Mant_Fin";
            this.Fec_Mant_Fin.HeaderText = "Fin Mant.";
            this.Fec_Mant_Fin.Name = "Fec_Mant_Fin";
            this.Fec_Mant_Fin.ReadOnly = true;
            // 
            // TipoMantenimiento
            // 
            this.TipoMantenimiento.DataPropertyName = "TipoMantenimiento";
            this.TipoMantenimiento.HeaderText = "Tipo Mant.";
            this.TipoMantenimiento.Name = "TipoMantenimiento";
            this.TipoMantenimiento.ReadOnly = true;
            // 
            // idMecanico
            // 
            this.idMecanico.DataPropertyName = "idMecanico";
            this.idMecanico.HeaderText = "IdMecanico Mant.";
            this.idMecanico.Name = "idMecanico";
            this.idMecanico.ReadOnly = true;
            // 
            // Nom_mec
            // 
            this.Nom_mec.DataPropertyName = "Nom_mec";
            this.Nom_mec.HeaderText = "Datos Mecanico";
            this.Nom_mec.Name = "Nom_mec";
            this.Nom_mec.ReadOnly = true;
            // 
            // VehiculoFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 479);
            this.Controls.Add(this.dtgVendedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtpFecFin);
            this.Controls.Add(this.dtpFecIni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label1);
            this.Name = "VehiculoFechas";
            this.Text = "VehiculoFechas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVendedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_Mant_Inic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_Mant_Fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMantenimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMecanico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_mec;
    }
}