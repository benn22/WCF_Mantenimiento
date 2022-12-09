using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cliente_WCF_Mantenimiento
{
    public partial class MecanicoMan01 : Form
    {
        ProxyMecanico.MecanicoClient objServiceMecanico = new ProxyMecanico.MecanicoClient();

        public MecanicoMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            dtgMecanico.DataSource = objServiceMecanico.ListarMecanico();

            lblRegistros.Text = dtgMecanico.Rows.Count.ToString();
        }

        private void MecanicoMan01_Load(object sender, EventArgs e)
        {

            try
            {
                dtgMecanico.AutoGenerateColumns = false;
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

        private void dtgMecanico_DoubleClick(object sender, EventArgs e)
        {
            btnActualizar.PerformClick();
        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                MecanicoMant02 objMecanicoMan02 = new MecanicoMant02();
                objMecanicoMan02.ShowDialog();
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
                MecanicoMant03 objMecanicoMan03 = new MecanicoMant03();
                String strCodigo = dtgMecanico.CurrentRow.Cells[0].Value.ToString();
                objMecanicoMan03.Codigo = strCodigo;
                objMecanicoMan03.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
