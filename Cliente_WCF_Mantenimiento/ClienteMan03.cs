using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cliente_WCF_Mantenimiento
{
    public partial class ClienteMan03 : Form
    {
        ProxyCliente.ServicioClienteClient objServiceCliente = new ProxyCliente.ServicioClienteClient();
        ProxyCliente.ClienteDC objClienteDC = new ProxyCliente.ClienteDC();
        public ClienteMan03()
        {
            InitializeComponent();
        }

        private String _Codigo;
        public String Codigo { get; set; }

        private void ClienteMan03_Load(object sender, EventArgs e)
        {
            try
            {
                objClienteDC = objServiceCliente.ConsultarCliente(Codigo);
                lblCodigo.Text = objClienteDC.idCliente;
                txtNombres.Text = objClienteDC.Nom_cli;
                txtApellidos.Text = objClienteDC.Ape_cli;
                txtDireccion.Text = objClienteDC.dir_cli;
                txtTelefono.Text = objClienteDC.Telf_Cli;
                txtCorreo.Text = objClienteDC.Correo_Cli;
                if (objClienteDC.Sexo == "M")
                {
                    rbMasculino.Checked = true;
                }
                else
                {
                    rbFemenino.Checked = true;
                }
                mskDni.Text = objClienteDC.Dni_Cli;
                mskRuc.Text = objClienteDC.Ruc_Cli;
                if (objClienteDC.TipoCliente == 1)
                {
                    cboTipoClie.Text = "Con Opción a Crédito";
                }
                else
                {
                    cboTipoClie.Text = "Sin Opción a Crédito";
                }
                dtpFecNac.Text = Convert.ToString(objClienteDC.Fec_Nac_Cli);
                chkEstado.Checked = Convert.ToBoolean(objClienteDC.Est_Cli);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombres.Text.Length == 0)
                {
                    throw new Exception("El Nombre no puede estar vacio.");
                }

                if (txtApellidos.Text.Length == 0)
                {
                    throw new Exception("El Apellido no puede estar vacio.");
                }

                if (mskDni.MaskFull == false)
                {
                    throw new Exception("El DNI debe tener 8 caracteres.");
                }

                if (mskRuc.MaskFull == false)
                {
                    throw new Exception("El RUC debe tener 10 caracteres.");
                }

                if (cboTipoClie.SelectedIndex == 0)
                {
                    objClienteDC.TipoCliente = 1;
                }
                else
                {
                    objClienteDC.TipoCliente = 2;
                }
                objClienteDC.Nom_cli = txtNombres.Text.Trim();
                objClienteDC.Ape_cli = txtApellidos.Text.Trim();
                objClienteDC.dir_cli = txtDireccion.Text.Trim();
                objClienteDC.Telf_Cli = txtTelefono.Text.Trim();
                objClienteDC.Correo_Cli = txtCorreo.Text.Trim();
                if (rbMasculino.Checked)
                {
                    objClienteDC.Sexo = "M";
                }
                else
                {
                    objClienteDC.Sexo = "F";
                }
                objClienteDC.Dni_Cli = mskDni.Text.Trim();
                objClienteDC.Ruc_Cli = mskRuc.Text.Trim();
                objClienteDC.Fec_Nac_Cli = Convert.ToDateTime(dtpFecNac.Text);
                //objClienteDC.cod_ubigeo = cboDepartamento.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() + cboDistrito.SelectedValue.ToString();
                objClienteDC.cod_ubigeo = "010101";
                objClienteDC.Est_Cli = Convert.ToInt16(chkEstado.Checked);
                objClienteDC.Usu_Registro = "admin";
                objClienteDC.Usu_Ult_Mod = "admin";
                if (objServiceCliente.ActualizarCliente(objClienteDC) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto el registro, contacte con TI");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);                
            }
        }        
    }
}