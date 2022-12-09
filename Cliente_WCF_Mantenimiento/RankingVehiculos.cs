using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cliente_WCF_Mantenimiento
{
    public partial class RankingVehiculos : Form
    {
        public RankingVehiculos()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                ProxyRank.ServicioEstadisticaClient objServiceEstadistica = new ProxyRank.ServicioEstadisticaClient();
                dtgDatos.DataSource = objServiceEstadistica.RankingVehiculoMantAño(Convert.ToInt16(txtTime.Text.Trim()), Convert.ToInt16(cboTop.SelectedItem));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }
    }
}
