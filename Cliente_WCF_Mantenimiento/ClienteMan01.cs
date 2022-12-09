using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cliente_WCF_Mantenimiento
{
    public partial class ClienteMan01 : Form
    {
        ProxyCliente.ServicioClienteClient objServiceCliente = new ProxyCliente.ServicioClienteClient();
        
        public ClienteMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            dtgCliente.DataSource = objServiceCliente.ListarCliente();
            lblRegistros.Text = dtgCliente.Rows.Count.ToString();
            
        }

        private void ClienteMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgCliente.AutoGenerateColumns = false;
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteMan02 objClienteMan02 = new ClienteMan02();
                objClienteMan02.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteMan03 objClienteMan03 = new ClienteMan03();
                String strCodigo = dtgCliente.CurrentRow.Cells[0].Value.ToString();
                objClienteMan03.Codigo = strCodigo;
                objClienteMan03.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgCliente_DoubleClick(object sender, EventArgs e)
        {
            btnActualizar.PerformClick();
        }        
    }
}