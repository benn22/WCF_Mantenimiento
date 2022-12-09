namespace Cliente_WCF_Mantenimiento
{
    partial class ClienteFechas
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
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRaz = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.lblRuc = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.idVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_Mant_Inic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_Mant_Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMecanico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoMecanico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCliente
            // 
            this.dtgCliente.AllowUserToAddRows = false;
            this.dtgCliente.AllowUserToDeleteRows = false;
            this.dtgCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVehiculo,
            this.Fec_Mant_Inic,
            this.Fec_Mant_Fin,
            this.idMecanico,
            this.EstadoMecanico});
            this.dtgCliente.Location = new System.Drawing.Point(52, 188);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.ReadOnly = true;
            this.dtgCliente.RowHeadersVisible = false;
            this.dtgCliente.RowTemplate.Height = 25;
            this.dtgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCliente.Size = new System.Drawing.Size(916, 301);
            this.dtgCliente.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(792, 529);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 49;
            this.label8.Text = "Registros:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(658, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 48;
            this.label7.Text = "Razon Social:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 47;
            this.label5.Text = "RUC:";
            // 
            // lblRaz
            // 
            this.lblRaz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRaz.Location = new System.Drawing.Point(738, 68);
            this.lblRaz.Name = "lblRaz";
            this.lblRaz.Size = new System.Drawing.Size(230, 25);
            this.lblRaz.TabIndex = 46;
            // 
            // lblRegistros
            // 
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(856, 524);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(112, 25);
            this.lblRegistros.TabIndex = 45;
            // 
            // lblRuc
            // 
            this.lblRuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRuc.Location = new System.Drawing.Point(479, 68);
            this.lblRuc.Name = "lblRuc";
            this.lblRuc.Size = new System.Drawing.Size(112, 25);
            this.lblRuc.TabIndex = 44;
            // 
            // lblNombres
            // 
            this.lblNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombres.Location = new System.Drawing.Point(178, 68);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(199, 25);
            this.lblNombres.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "Nombres y Apellidos:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(893, 30);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 41;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(694, 28);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(100, 23);
            this.dtpFecFin.TabIndex = 40;
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIni.Location = new System.Drawing.Point(379, 28);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(100, 23);
            this.dtpFecIni.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "F. Fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "F. Inicio:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(138, 24);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 23);
            this.txtCod.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Cliente:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(263, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 55;
            this.label9.Text = "Estado:";
            // 
            // lblEstado
            // 
            this.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstado.Location = new System.Drawing.Point(322, 124);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(112, 25);
            this.lblEstado.TabIndex = 53;
            // 
            // lblDni
            // 
            this.lblDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDni.Location = new System.Drawing.Point(88, 124);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(150, 25);
            this.lblDni.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 15);
            this.label13.TabIndex = 51;
            this.label13.Text = "DNI:";
            // 
            // idVehiculo
            // 
            this.idVehiculo.DataPropertyName = "idVehiculo";
            this.idVehiculo.HeaderText = "Vehiculo";
            this.idVehiculo.Name = "idVehiculo";
            this.idVehiculo.ReadOnly = true;
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
            // idMecanico
            // 
            this.idMecanico.DataPropertyName = "idMecanico";
            this.idMecanico.HeaderText = "IdMecanico Mant.";
            this.idMecanico.Name = "idMecanico";
            this.idMecanico.ReadOnly = true;
            // 
            // EstadoMecanico
            // 
            this.EstadoMecanico.DataPropertyName = "EstadoMecanico";
            this.EstadoMecanico.HeaderText = "Estado Mecanico";
            this.EstadoMecanico.Name = "EstadoMecanico";
            this.EstadoMecanico.ReadOnly = true;
            // 
            // ClienteFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 581);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtgCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRaz);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.lblRuc);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtpFecFin);
            this.Controls.Add(this.dtpFecIni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label1);
            this.Name = "ClienteFechas";
            this.Text = "ClienteFechas";
            this.Load += new System.EventHandler(this.ClienteFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRaz;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label lblRuc;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_Mant_Inic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_Mant_Fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMecanico;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoMecanico;
    }
}