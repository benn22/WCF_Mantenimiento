using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cliente_WCF_Mantenimiento
{
    public partial class MantFechas : Form
    {
        public MantFechas()
        {
            InitializeComponent();
        }

        private void dtgVendedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                ProxyMant.MantenimientoClient objServiceMat = new ProxyMant.MantenimientoClient();
                dtgMant.DataSource = objServiceMat.ListarMantenimientoFechas(dtpFecIni.Value.Date, dtpFecFin.Value.Date);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }
    }
}