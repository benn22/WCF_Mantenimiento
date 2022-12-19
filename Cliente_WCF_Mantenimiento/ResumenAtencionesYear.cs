using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cliente_WCF_Mantenimiento
{
    public partial class ResumenAtencionesYear : Form
    {
        public ResumenAtencionesYear()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {            
            try
            {
                ProxyMant.MantenimientoClient objServiceMant = new ProxyMant.MantenimientoClient();
                dtgMant.DataSource = objServiceMant.ListarMantenimientoYear(Convert.ToInt16(cboYear.Text));
                lblRegistros.Text = dtgMant.RowCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void ResumenAtencionesYear_Load(object sender, EventArgs e)
        {
            dtgMant.AutoGenerateColumns = false;
        }
    }
}