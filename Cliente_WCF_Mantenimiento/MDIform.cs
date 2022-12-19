using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cliente_WCF_Mantenimiento
{
    public partial class MDIform : Form
    {
        public MDIform()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteMan01 objClienteMan01 = new ClienteMan01();
            objClienteMan01.Show();
        }

        private void mecanicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MecanicoMan01 objMecanicoMan01 = new MecanicoMan01();
            objMecanicoMan01.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClienteFechas objFechas = new ClienteFechas();
            objFechas.Show();
        }

        private void mantenimientosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MantFechas objMantFechas = new MantFechas();
            objMantFechas.Show();
        }

        private void mecanicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MecanicoFechas objMecFechas = new MecanicoFechas();
            objMecFechas.Show();
        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehiculoFechas objVehiculoFechas = new VehiculoFechas();
            objVehiculoFechas.Show();
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RankingClientes objRankClie = new RankingClientes();
            objRankClie.Show();
        }

        private void mecanicosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RankingMecanicos objRankMeca = new RankingMecanicos();
            objRankMeca.Show();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RankingVehiculos objRankVehiculos = new RankingVehiculos();
            objRankVehiculos.Show();
        }

        private void atencionesPorAñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResumenAtencionesYear objResumen = new ResumenAtencionesYear();
            objResumen.Show();
        }
    }
}