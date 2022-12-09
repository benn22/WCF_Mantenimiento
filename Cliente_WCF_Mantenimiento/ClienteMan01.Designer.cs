namespace Cliente_WCF_Mantenimiento
{
    partial class ClienteMan01
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.Insertar = new System.Windows.Forms.Button();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni_Cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ape_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruc_Cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raz_soc_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCliente
            // 
            this.dtgCliente.AllowUserToAddRows = false;
            this.dtgCliente.AllowUserToDeleteRows = false;
            this.dtgCliente.AllowUserToResizeColumns = false;
            this.dtgCliente.AllowUserToResizeRows = false;
            this.dtgCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.Dni_Cli,
            this.Nom_cli,
            this.Ape_cli,
            this.Ruc_Cli,
            this.Raz_soc_cli,
            this.EstadoCliente});
            this.dtgCliente.Location = new System.Drawing.Point(12, 12);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.ReadOnly = true;
            this.dtgCliente.RowHeadersVisible = false;
            this.dtgCliente.RowTemplate.Height = 25;
            this.dtgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCliente.Size = new System.Drawing.Size(860, 424);
            this.dtgCliente.TabIndex = 0;
            this.dtgCliente.DoubleClick += new System.EventHandler(this.dtgCliente_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(744, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registros:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(809, 443);
            this.lblRegistros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(63, 26);
            this.lblRegistros.TabIndex = 12;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(797, 476);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(716, 476);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Insertar
            // 
            this.Insertar.Location = new System.Drawing.Point(635, 476);
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(75, 23);
            this.Insertar.TabIndex = 15;
            this.Insertar.Text = "Insertar";
            this.Insertar.UseVisualStyleBackColor = true;
            this.Insertar.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "idCliente";
            this.idCliente.HeaderText = "Codigo";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            // 
            // Dni_Cli
            // 
            this.Dni_Cli.DataPropertyName = "Dni_Cli";
            this.Dni_Cli.HeaderText = "DNI";
            this.Dni_Cli.Name = "Dni_Cli";
            this.Dni_Cli.ReadOnly = true;
            // 
            // Nom_cli
            // 
            this.Nom_cli.DataPropertyName = "Nom_cli";
            this.Nom_cli.HeaderText = "Nombres";
            this.Nom_cli.Name = "Nom_cli";
            this.Nom_cli.ReadOnly = true;
            // 
            // Ape_cli
            // 
            this.Ape_cli.DataPropertyName = "Ape_cli";
            this.Ape_cli.HeaderText = "Apellidos";
            this.Ape_cli.Name = "Ape_cli";
            this.Ape_cli.ReadOnly = true;
            // 
            // Ruc_Cli
            // 
            this.Ruc_Cli.DataPropertyName = "Ruc_Cli";
            this.Ruc_Cli.HeaderText = "RUC";
            this.Ruc_Cli.Name = "Ruc_Cli";
            this.Ruc_Cli.ReadOnly = true;
            // 
            // Raz_soc_cli
            // 
            this.Raz_soc_cli.DataPropertyName = "Raz_soc_cli";
            this.Raz_soc_cli.HeaderText = "Razon Social";
            this.Raz_soc_cli.Name = "Raz_soc_cli";
            this.Raz_soc_cli.ReadOnly = true;
            // 
            // EstadoCliente
            // 
            this.EstadoCliente.DataPropertyName = "EstadoCliente";
            this.EstadoCliente.HeaderText = "Estado";
            this.EstadoCliente.Name = "EstadoCliente";
            this.EstadoCliente.ReadOnly = true;
            // 
            // ClienteMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.Insertar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgCliente);
            this.Name = "ClienteMan01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Clientes";
            this.Load += new System.EventHandler(this.ClienteMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button Insertar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni_Cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ape_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruc_Cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raz_soc_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCliente;
    }
}