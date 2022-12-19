using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cliente_WCF_Mantenimiento
{    
    public partial class ClienteMan02 : Form
    {
        ProxyCliente.ServicioClienteClient objServiceCliente = new ProxyCliente.ServicioClienteClient();
        ProxyCliente.ClienteDC objClienteDC = new ProxyCliente.ClienteDC();
        ProxyUbigeo.ServicioUbigeoClient objServiceUbigeo = new ProxyUbigeo.ServicioUbigeoClient();
        public ClienteMan02()
        {
            InitializeComponent();
        }

        private void ClienteMan02_Load(object sender, EventArgs e)
        {
            try
            {
                CargarUbigeo("01", "01", "01");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
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
                objClienteDC.cod_ubigeo = cboDepartamento.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() + cboDistrito.SelectedValue.ToString();
                //objClienteDC.cod_ubigeo = "010101";
                objClienteDC.Est_Cli = Convert.ToInt16(chkEstado.Checked);
                objClienteDC.Usu_Registro = "admin";
                objClienteDC.Usu_Ult_Mod = "admin";                
                if (objServiceCliente.InsertarCliente(objClienteDC) == true)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {
            cboDepartamento.DataSource = objServiceUbigeo.ListarUbigeo_Departamento();
            cboDepartamento.ValueMember = "IdDepa";
            cboDepartamento.DisplayMember = "Departamento";
            cboDepartamento.SelectedValue = IdDepa;

            cboProvincia.DataSource = objServiceUbigeo.ListarUbigeo_ProvinciasDepartamento(IdDepa);
            cboProvincia.ValueMember = "IdProv";
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.SelectedValue = IdProv;

            cboDistrito.DataSource = objServiceUbigeo.ListarUbigeo_DistritoProvinciaDepartamento(IdDepa, IdProv);
            cboDistrito.ValueMember = "IdDist";
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.SelectedValue = IdDist;

        }

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(),"01","01");
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
        }
    }
}