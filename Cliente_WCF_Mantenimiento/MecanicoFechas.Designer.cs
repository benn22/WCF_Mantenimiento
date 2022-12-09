namespace Cliente_WCF_Mantenimiento
{
    partial class MecanicoFechas
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
            this.label9 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.dtgMecanico = new System.Windows.Forms.DataGridView();
            this.idMantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_Mant_Inic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_Mant_Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_mec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMecanico)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(611, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 75;
            this.label9.Text = "Estado:";
            // 
            // lblEstado
            // 
            this.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstado.Location = new System.Drawing.Point(670, 70);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(112, 25);
            this.lblEstado.TabIndex = 74;
            // 
            // dtgMecanico
            // 
            this.dtgMecanico.AllowUserToAddRows = false;
            this.dtgMecanico.AllowUserToDeleteRows = false;
            this.dtgMecanico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMecanico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMecanico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMantenimiento,
            this.Fec_Mant_Inic,
            this.Fec_Mant_Fin,
            this.idVehiculo,
            this.TipoUnidad,
            this.Nom_mec});
            this.dtgMecanico.Location = new System.Drawing.Point(40, 123);
            this.dtgMecanico.Name = "dtgMecanico";
            this.dtgMecanico.ReadOnly = true;
            this.dtgMecanico.RowHeadersVisible = false;
            this.dtgMecanico.RowTemplate.Height = 25;
            this.dtgMecanico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMecanico.Size = new System.Drawing.Size(916, 301);
            this.dtgMecanico.TabIndex = 71;
            // 
            // idMantenimiento
            // 
            this.idMantenimiento.DataPropertyName = "idMantenimiento";
            this.idMantenimiento.HeaderText = "Mantenimiento";
            this.idMantenimiento.Name = "idMantenimiento";
            this.idMantenimiento.ReadOnly = true;
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
            // idVehiculo
            // 
            this.idVehiculo.DataPropertyName = "idVehiculo";
            this.idVehiculo.HeaderText = "Vehiculo";
            this.idVehiculo.Name = "idVehiculo";
            this.idVehiculo.ReadOnly = true;
            // 
            // TipoUnidad
            // 
            this.TipoUnidad.DataPropertyName = "TipoUnidad";
            this.TipoUnidad.HeaderText = "Tipo Unidad";
            this.TipoUnidad.Name = "TipoUnidad";
            this.TipoUnidad.ReadOnly = true;
            // 
            // Nom_mec
            // 
            this.Nom_mec.DataPropertyName = "Nom_mec";
            this.Nom_mec.HeaderText = "Cliente";
            this.Nom_mec.Name = "Nom_mec";
            this.Nom_mec.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(780, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 70;
            this.label8.Text = "Registros:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(844, 464);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(112, 25);
            this.lblRegistros.TabIndex = 66;
            // 
            // lblNombres
            // 
            this.lblNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombres.Location = new System.Drawing.Point(166, 70);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(199, 25);
            this.lblNombres.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 63;
            this.label4.Text = "Nombres y Apellidos:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(881, 32);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 62;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(682, 30);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(100, 23);
            this.dtpFecFin.TabIndex = 61;
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIni.Location = new System.Drawing.Point(367, 30);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(100, 23);
            this.dtpFecIni.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(638, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 59;
            this.label3.Text = "F. Fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 58;
            this.label2.Text = "F. Inicio:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(126, 26);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 23);
            this.txtCod.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 56;
            this.label1.Text = "Mecanico:";
            // 
            // MecanicoFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 524);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.dtgMecanico);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtpFecFin);
            this.Controls.Add(this.dtpFecIni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label1);
            this.Name = "MecanicoFechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MecanicoFechas";
            this.Load += new System.EventHandler(this.MecanicoFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMecanico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DataGridView dtgMecanico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMantenimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_Mant_Inic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_Mant_Fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_mec;
    }
}