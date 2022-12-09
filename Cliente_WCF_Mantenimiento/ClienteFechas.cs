using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cliente_WCF_Mantenimiento
{
    public partial class ClienteFechas : Form
    {
        ProxyCliente.ServicioClienteClient objServiceCliente = new ProxyCliente.ServicioClienteClient();
        ProxyCliente.ClienteDC objClienteDC = new ProxyCliente.ClienteDC();

        public ClienteFechas()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                objClienteDC = objServiceCliente.ConsultarCliente(txtCod.Text.Trim());

                lblNombres.Text = objClienteDC.Ape_cli + ", " + objClienteDC.Nom_cli;
                lblRuc.Text = objClienteDC.Ruc_Cli;
                lblRaz.Text = objClienteDC.Raz_soc_cli;
                lblDni.Text = objClienteDC.Dni_Cli;                

                if (objClienteDC.Est_Cli == 1)
                {
                    lblEstado.Text = "Activo";
                }
                else
                {
                    lblEstado.Text = "Inactivo";
                }

                dtgCliente.DataSource = objServiceCliente.ListarClienteFechas(txtCod.Text.Trim(), dtpFecIni.Value.Date, dtpFecFin.Value.Date);
                lblRegistros.Text = dtgCliente.Rows.Count.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClienteFechas_Load(object sender, EventArgs e)
        {
            dtgCliente.AutoGenerateColumns = false;

        }
    }
}
