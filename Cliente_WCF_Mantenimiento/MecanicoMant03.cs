using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cliente_WCF_Mantenimiento
{
    public partial class MecanicoMant03 : Form
    {
        ProxyMecanico.MecanicoClient objServiceMecanico = new ProxyMecanico.MecanicoClient();
        ProxyMecanico.MecanicoDC objMecanicoDC = new ProxyMecanico.MecanicoDC();

        public MecanicoMant03()
        {
            InitializeComponent();
        }

        private String _Codigo;
        public String Codigo { get; set; }

        private void MecanicoMant03_Load(object sender, EventArgs e)
        {
            try
            {
                objMecanicoDC = objServiceMecanico.ConsultarMecanico(Codigo);
                lblCodigo.Text = objMecanicoDC.idMecanico;
                txtNombres.Text = objMecanicoDC.Nom_mec;
                txtApellidos.Text = objMecanicoDC.Ape_mec;
                txtDireccion.Text = objMecanicoDC.dir_mecanico;
                txtTelefono.Text = objMecanicoDC.Telf_Mec;
                txtCorreo.Text = objMecanicoDC.Correo_Mec;

                if (objMecanicoDC.Sexo == "M")
                {
                    rbMasculino.Checked = true;
                }
                else
                {
                    rbFemenino.Checked = true;
                }
                mskDni.Text = objMecanicoDC.Doc_Iden;
                lblCentro.Text = objMecanicoDC.Centro_Estudios;
                lblEspec.Text = objMecanicoDC.Espe_Mec;              
                              
                dtpNac.Text = Convert.ToString(objMecanicoDC.Fech_Nac);
                dtpFecIng.Text = Convert.ToString(objMecanicoDC.Fech_Ingreso);
                chkEstado.Checked = Convert.ToBoolean(objMecanicoDC.Est_Mec);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

                objMecanicoDC.Nom_mec = txtNombres.Text.Trim();
                objMecanicoDC.Ape_mec = txtApellidos.Text.Trim();
                objMecanicoDC.dir_mecanico = txtDireccion.Text.Trim();
                objMecanicoDC.Telf_Mec = txtTelefono.Text.Trim();
                objMecanicoDC.Correo_Mec = txtCorreo.Text.Trim();

                if (rbMasculino.Checked)
                {
                    objMecanicoDC.Sexo = "M";
                }
                else
                {
                    objMecanicoDC.Sexo = "F";
                }
                objMecanicoDC.Doc_Iden = mskDni.Text.Trim();
                objMecanicoDC.Espe_Mec = lblEspec.Text.Trim();
                objMecanicoDC.Centro_Estudios = lblCentro.Text.Trim();
                objMecanicoDC.Fech_Nac = Convert.ToDateTime(dtpNac.Text);
                objMecanicoDC.Fech_Ingreso = Convert.ToDateTime(dtpFecIng.Text);
                //objClienteDC.cod_ubigeo = cboDepartamento.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() + cboDistrito.SelectedValue.ToString();
                objMecanicoDC.cod_ubigeo = "010101";
                objMecanicoDC.Est_Mec = Convert.ToInt16(chkEstado.Checked);
                objMecanicoDC.Usu_Registro = "admin";
                objMecanicoDC.Usu_Ult_Mod = "admin";

                if (objServiceMecanico.ActualizarMecanico(objMecanicoDC) == true)
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
