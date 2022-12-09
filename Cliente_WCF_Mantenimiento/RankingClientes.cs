using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cliente_WCF_Mantenimiento
{
    public partial class RankingClientes : Form
    {
        public RankingClientes()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                ProxyRank.ServicioEstadisticaClient objServiceEstadistica = new ProxyRank.ServicioEstadisticaClient();
                dtgDatos.DataSource = objServiceEstadistica.RankingClientesAño(Convert.ToInt16(txtTime.Text.Trim()),Convert.ToInt16(cboTop.SelectedItem));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }
    }
}
