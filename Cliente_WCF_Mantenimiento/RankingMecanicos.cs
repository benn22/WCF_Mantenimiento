using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cliente_WCF_Mantenimiento
{
    public partial class RankingMecanicos : Form
    {
        public RankingMecanicos()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                ProxyRank.ServicioEstadisticaClient objServiceEstadistica = new ProxyRank.ServicioEstadisticaClient();
                dtgDatos.DataSource = objServiceEstadistica.RankingMecanicoMantAño(Convert.ToInt16(txtTime.Text.Trim()), Convert.ToInt16(cboTop.SelectedItem));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void RankingMecanicos_Load(object sender, EventArgs e)
        {

        }
    }
}
