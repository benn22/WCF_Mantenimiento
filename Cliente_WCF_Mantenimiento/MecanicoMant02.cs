using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cliente_WCF_Mantenimiento
{
    public partial class MecanicoMant02 : Form
    {
        ProxyMecanico.MecanicoClient objServiceMecanico = new ProxyMecanico.MecanicoClient();
        ProxyMecanico.MecanicoDC objMecanicoDC = new ProxyMecanico.MecanicoDC(); 

        public MecanicoMant02()
        {
            InitializeComponent();
        }

        private void MecanicoMant02_Load(object sender, EventArgs e)
        {
            try
            {
                cboDepartamento.DisplayMember = "LIMA";
                cboDistrito.DisplayMember = "LIMA";
                cboProvincia.DisplayMember = "LA VICTORIA";
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

                objMecanicoDC.Fech_Nac = Convert.ToDateTime(dtpNac.Text);
                objMecanicoDC.Espe_Mec = txtEspecialidad.Text.Trim();
                objMecanicoDC.Centro_Estudios = txtEstudios.Text.Trim();
                objMecanicoDC.Fech_Ingreso = Convert.ToDateTime(dtpFecIng.Text);
                //objClienteDC.cod_ubigeo = cboDepartamento.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() + cboDistrito.SelectedValue.ToString();
                objMecanicoDC.cod_ubigeo = "010101";
                objMecanicoDC.Est_Mec = Convert.ToInt16(chkEstado.Checked);
                objMecanicoDC.Usu_Registro = "admin";
                objMecanicoDC.Usu_Ult_Mod = "admin";
                if (objServiceMecanico.InsertarMecanico(objMecanicoDC) == true)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
