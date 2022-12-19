namespace Cliente_WCF_Mantenimiento
{
    partial class ResumenAtencionesYear
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
            this.dtgMant = new System.Windows.Forms.DataGridView();
            this.idMecanico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Man = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo_Man = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMant)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMant
            // 
            this.dtgMant.AllowUserToAddRows = false;
            this.dtgMant.AllowUserToDeleteRows = false;
            this.dtgMant.AllowUserToOrderColumns = true;
            this.dtgMant.AllowUserToResizeRows = false;
            this.dtgMant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMecanico,
            this.NombreCompleto,
            this.idVehiculo,
            this.Mantenimiento,
            this.Nombre_Man,
            this.Estado,
            this.Costo_Man,
            this.Fecha});
            this.dtgMant.Location = new System.Drawing.Point(12, 67);
            this.dtgMant.Name = "dtgMant";
            this.dtgMant.ReadOnly = true;
            this.dtgMant.RowHeadersVisible = false;
            this.dtgMant.RowTemplate.Height = 25;
            this.dtgMant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMant.Size = new System.Drawing.Size(960, 301);
            this.dtgMant.TabIndex = 79;
            // 
            // idMecanico
            // 
            this.idMecanico.DataPropertyName = "idMecanico";
            this.idMecanico.HeaderText = "Cod. Mecanico";
            this.idMecanico.Name = "idMecanico";
            this.idMecanico.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.HeaderText = "Nombre Mecanico";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            // 
            // idVehiculo
            // 
            this.idVehiculo.DataPropertyName = "idVehiculo";
            this.idVehiculo.HeaderText = "Placa";
            this.idVehiculo.Name = "idVehiculo";
            this.idVehiculo.ReadOnly = true;
            // 
            // Mantenimiento
            // 
            this.Mantenimiento.DataPropertyName = "Mantenimiento";
            this.Mantenimiento.HeaderText = "Tipo Mant.";
            this.Mantenimiento.Name = "Mantenimiento";
            this.Mantenimiento.ReadOnly = true;
            // 
            // Nombre_Man
            // 
            this.Nombre_Man.DataPropertyName = "Nombre_Man";
            this.Nombre_Man.HeaderText = "Descripcion";
            this.Nombre_Man.Name = "Nombre_Man";
            this.Nombre_Man.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Costo_Man
            // 
            this.Costo_Man.DataPropertyName = "Costo_Man";
            this.Costo_Man.HeaderText = "Costo";
            this.Costo_Man.Name = "Costo_Man";
            this.Costo_Man.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha Mant.";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(796, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 78;
            this.label8.Text = "Atenciones:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(871, 382);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(101, 25);
            this.lblRegistros.TabIndex = 77;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(258, 21);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 76;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 72;
            this.label2.Text = "Año:";
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cboYear.Location = new System.Drawing.Point(50, 21);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(121, 23);
            this.cboYear.TabIndex = 80;
            // 
            // ResumenAtencionesYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 426);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.dtgMant);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResumenAtencionesYear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumen de atenciones por año";
            this.Load += new System.EventHandler(this.ResumenAtencionesYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMecanico;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mantenimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Man;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo_Man;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}