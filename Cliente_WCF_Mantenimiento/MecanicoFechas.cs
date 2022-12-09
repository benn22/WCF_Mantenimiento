using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cliente_WCF_Mantenimiento
{
    public partial class MecanicoFechas : Form
    {

        ProxyMecanico.MecanicoClient objServiceMecanico = new ProxyMecanico.MecanicoClient();
        ProxyMecanico.MecanicoDC objMecanicoDC = new ProxyMecanico.MecanicoDC();

        public MecanicoFechas()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                objMecanicoDC = objServiceMecanico.ConsultarMecanico(txtCod.Text.Trim());
                lblNombres.Text = objMecanicoDC.Ape_mec + ", " + objMecanicoDC.Nom_mec;

                if (objMecanicoDC.Est_Mec == 1)
                {
                    lblEstado.Text = "Activo";
                }
                else
                {
                    lblEstado.Text = "Inactivo";
                }


                dtgMecanico.DataSource = objServiceMecanico.ListarMecanicoFechas(txtCod.Text.Trim(), dtpFecIni.Value.Date, dtpFecFin.Value.Date);
                lblRegistros.Text = dtgMecanico.Rows.Count.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void MecanicoFechas_Load(object sender, EventArgs e)
        {
            dtgMecanico.AutoGenerateColumns = false;
        }
    }
}
