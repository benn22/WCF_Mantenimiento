namespace Cliente_WCF_Mantenimiento
{
    partial class MecanicoMan01
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
            this.Insertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgMecanico = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni_Cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ape_mec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doc_Iden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dir_mecanico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fech_Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMecanico)).BeginInit();
            this.SuspendLayout();
            // 
            // Insertar
            // 
            this.Insertar.Location = new System.Drawing.Point(635, 476);
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(75, 23);
            this.Insertar.TabIndex = 21;
            this.Insertar.Text = "Insertar";
            this.Insertar.UseVisualStyleBackColor = true;
            this.Insertar.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(716, 476);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 20;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(797, 476);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(809, 437);
            this.lblRegistros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(63, 26);
            this.lblRegistros.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(744, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Registros:";
            // 
            // dtgMecanico
            // 
            this.dtgMecanico.AllowUserToAddRows = false;
            this.dtgMecanico.AllowUserToDeleteRows = false;
            this.dtgMecanico.AllowUserToResizeColumns = false;
            this.dtgMecanico.AllowUserToResizeRows = false;
            this.dtgMecanico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMecanico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMecanico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMecanico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.Dni_Cli,
            this.Ape_mec,
            this.Doc_Iden,
            this.dir_mecanico,
            this.Fech_Ingreso,
            this.EstadoCliente});
            this.dtgMecanico.Location = new System.Drawing.Point(12, 12);
            this.dtgMecanico.Name = "dtgMecanico";
            this.dtgMecanico.ReadOnly = true;
            this.dtgMecanico.RowHeadersVisible = false;
            this.dtgMecanico.RowTemplate.Height = 25;
            this.dtgMecanico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMecanico.Size = new System.Drawing.Size(860, 422);
            this.dtgMecanico.TabIndex = 16;
            this.dtgMecanico.DoubleClick += new System.EventHandler(this.dtgMecanico_DoubleClick);
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "idMecanico";
            this.idCliente.HeaderText = "Codigo";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            // 
            // Dni_Cli
            // 
            this.Dni_Cli.DataPropertyName = "Nom_mec";
            this.Dni_Cli.HeaderText = "Nombre Mec.";
            this.Dni_Cli.Name = "Dni_Cli";
            this.Dni_Cli.ReadOnly = true;
            // 
            // Ape_mec
            // 
            this.Ape_mec.DataPropertyName = "Ape_mec";
            this.Ape_mec.HeaderText = "Apellidos Mec.";
            this.Ape_mec.Name = "Ape_mec";
            this.Ape_mec.ReadOnly = true;
            // 
            // Doc_Iden
            // 
            this.Doc_Iden.DataPropertyName = "Doc_Iden";
            this.Doc_Iden.HeaderText = "DNI";
            this.Doc_Iden.Name = "Doc_Iden";
            this.Doc_Iden.ReadOnly = true;
            // 
            // dir_mecanico
            // 
            this.dir_mecanico.DataPropertyName = "dir_mecanico";
            this.dir_mecanico.HeaderText = "Dirección";
            this.dir_mecanico.Name = "dir_mecanico";
            this.dir_mecanico.ReadOnly = true;
            // 
            // Fech_Ingreso
            // 
            this.Fech_Ingreso.DataPropertyName = "Fech_Ingreso";
            this.Fech_Ingreso.HeaderText = "Fecha Ingreso";
            this.Fech_Ingreso.Name = "Fech_Ingreso";
            this.Fech_Ingreso.ReadOnly = true;
            // 
            // EstadoCliente
            // 
            this.EstadoCliente.DataPropertyName = "Telf_Mec";
            this.EstadoCliente.HeaderText = "Telefono";
            this.EstadoCliente.Name = "EstadoCliente";
            this.EstadoCliente.ReadOnly = true;
            // 
            // MecanicoMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.Insertar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgMecanico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MecanicoMan01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Mecanicos";
            this.Load += new System.EventHandler(this.MecanicoMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMecanico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insertar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgMecanico;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni_Cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ape_mec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doc_Iden;
        private System.Windows.Forms.DataGridViewTextBoxColumn dir_mecanico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fech_Ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCliente;
    }
}