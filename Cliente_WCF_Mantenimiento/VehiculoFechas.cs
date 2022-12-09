using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cliente_WCF_Mantenimiento
{
    public partial class VehiculoFechas : Form
    {
        ProxyVehiculo.ServicioVehiculosClient objServiceVehiculo = new ProxyVehiculo.ServicioVehiculosClient();
        ProxyVehiculo.VehiculoDC objVehiculoDC = new ProxyVehiculo.VehiculoDC();


        public VehiculoFechas()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                objVehiculoDC = objServiceVehiculo.ConsultarVehiculos(txtCod.Text.Trim());

                if (objVehiculoDC.Tipo_Trans == 1)
                {
                    lblTrans.Text = "Automático";
                }
                else if(objVehiculoDC.Tipo_Trans == 2)
                {
                    lblTrans.Text = "Mecánico";

                }else if(objVehiculoDC.Tipo_Trans == 3)
                {
                    lblTrans.Text = "SemiAutomático";
                }

                lblMarca.Text = objVehiculoDC.idMarca;
                lblModelo.Text = objVehiculoDC.modelo;

                if ( objVehiculoDC.Tipo_Unidad== 1)
                {
                    lblUnidad.Text = "Auto";
                }
                else if( objVehiculoDC.Tipo_Unidad== 2)
                {
                    lblUnidad.Text = "Bus";
                }
                else if( objVehiculoDC.Tipo_Unidad== 3)
                {
                    lblUnidad.Text = "Camión";
                }else if( objVehiculoDC.Tipo_Unidad== 4)
                {
                    lblUnidad.Text = "Moto";
                }


                dtgVehiculos.DataSource = objServiceVehiculo.ListarVehiculosFechas(txtCod.Text.Trim(), dtpFecIni.Value.Date, dtpFecFin.Value.Date);
                lblRegistros.Text = dtgVehiculos.Rows.Count.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
