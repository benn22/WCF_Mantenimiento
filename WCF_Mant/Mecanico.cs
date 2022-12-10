using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Mant
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Mecanico" en el código y en el archivo de configuración a la vez.
    public class Mecanico : IMecanico
    {
        MANTENIMIENTO mant = new MANTENIMIENTO();
        public List<MecanicoFecDC> ListarMecanicoFechas(String strMecanico, DateTime fecini, DateTime fecfin)
        {

            try
            {
                List<MecanicoFecDC> list = new List<MecanicoFecDC>();

                var query = mant.usp_MecanicoFechas(strMecanico, fecini, fecfin);

                foreach (var resultado in query)
                {
                    MecanicoFecDC objMec = new MecanicoFecDC();

                    objMec.idMecanico = resultado.idMecanico;
                    objMec.Fec_Mant_Inic = Convert.ToDateTime(resultado.Fec_Mant_Inic);
                    objMec.Fec_Mant_Fin = Convert.ToDateTime(resultado.Fec_Mant_Fin);
                    objMec.Est_Mec = Convert.ToSingle(resultado.Est_Mec);
                    objMec.Fech_Ingreso = Convert.ToDateTime(resultado.Fech_Ingreso);
                    objMec.Estado = resultado.Estado;
                    objMec.idMantenimiento = resultado.idMantenimiento;
                    objMec.idVehiculo = resultado.idVehiculo;
                    objMec.Tipo_unidad = Convert.ToSingle(resultado.Tipo_unidad);
                    objMec.TipoUnidad = resultado.TipoUnidad;
                    objMec.Ruc_Cli = resultado.Ruc_Cli;
                    objMec.Nom_cli = resultado.Nom_cli;
                    objMec.Ape_cli = resultado.Ape_cli;
                    objMec.Raz_soc_cli = resultado.Raz_soc_cli;
                    objMec.Nom_mec = resultado.Nom_mec;
                    objMec.Ape_mec = resultado.Ape_mec;

                    list.Add(objMec);
                }

                return list;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public List<MecanicoDC> ListarMecanico()
        {

            try
            {
                List<MecanicoDC> objList = new List<MecanicoDC>();

                var query = mant.usp_ListarMecanico();

                foreach (var resultado in query)
                {
                    MecanicoDC objMecanicoDC = new MecanicoDC();
                    objMecanicoDC.idMecanico = resultado.idMecanico;
                    objMecanicoDC.Nom_mec = resultado.Nom_mec;
                    objMecanicoDC.Ape_mec = resultado.Ape_mec;
                    objMecanicoDC.Doc_Iden = resultado.Doc_Iden;
                    objMecanicoDC.dir_mecanico = resultado.dir_mecanico;
                    objMecanicoDC.Fech_Ingreso = Convert.ToDateTime(resultado.Fech_Ingreso);
                    objMecanicoDC.Telf_Mec = resultado.Telf_Mec;
                    objMecanicoDC.Fech_Nac = Convert.ToDateTime(resultado.Fec_Nac);
                    objMecanicoDC.Sexo = resultado.Sexo;


                    objList.Add(objMecanicoDC);

                }

                return objList;
            }
            catch (Exception ex)
            {


                throw new Exception(ex.Message);
            }

        }

        public Boolean InsertarMecanico(MecanicoDC objMecanicoDC)
        {
            try
            {
                mant.usp_InsertarMecanico
                    (
                    objMecanicoDC.cod_ubigeo, objMecanicoDC.Nom_mec, objMecanicoDC.Ape_mec, objMecanicoDC.Doc_Iden, objMecanicoDC.dir_mecanico, Convert.ToDateTime(objMecanicoDC.Fech_Ingreso), objMecanicoDC.Telf_Mec,
                    Convert.ToDateTime(objMecanicoDC.Fech_Nac),objMecanicoDC.Sexo, objMecanicoDC.Espe_Mec, objMecanicoDC.Centro_Estudios, objMecanicoDC.Correo_Mec, objMecanicoDC.Usu_Registro, Convert.ToInt16(objMecanicoDC.Est_Mec)
                  );

                mant.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {


                throw new Exception(ex.Message);
            }


        }

        public Boolean ActualizarMecanico(MecanicoDC objMecanicoDC)
        {
            try
            {
                mant.usp_ActualizarMecanico
                    (
                    objMecanicoDC.idMecanico,objMecanicoDC.cod_ubigeo,objMecanicoDC.Nom_mec,objMecanicoDC.Ape_mec,objMecanicoDC.Doc_Iden,objMecanicoDC.dir_mecanico,Convert.ToDateTime(objMecanicoDC.Fech_Ingreso),objMecanicoDC.Telf_Mec,
                    Convert.ToDateTime(objMecanicoDC.Fech_Nac),objMecanicoDC.Sexo.ToString(),objMecanicoDC.Espe_Mec,objMecanicoDC.Centro_Estudios,objMecanicoDC.Correo_Mec,objMecanicoDC.Usu_Ult_Mod,Convert.ToInt16(objMecanicoDC.Est_Mec)
                  );

                mant.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {


                throw new Exception(ex.Message);
            }


        }

        public Boolean EliminarMecanico(String strCodigo)
        {
            try
            {
                mant.usp_EliminarMecanico(strCodigo);

                mant.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {


                throw new Exception(ex.Message);
            }


        }

        public MecanicoDC ConsultarMecanico(String strCodigo)
        {
           
                try
                {
                    Tb_Mecanico objMecanico = (from objMec in mant.Tb_Mecanico where objMec.idMecanico == strCodigo select objMec).FirstOrDefault();
                    MecanicoDC objMecanicoDC = new MecanicoDC();
                    objMecanicoDC. idMecanico = objMecanico.idMecanico;
                    objMecanicoDC.cod_ubigeo = objMecanico.cod_ubigeo;
                    objMecanicoDC.Est_Mec = Convert.ToSingle( objMecanico.Est_Mec);
                    objMecanicoDC.Nom_mec = objMecanico.Nom_mec;
                    objMecanicoDC.Ape_mec = objMecanico.Ape_mec;
                    objMecanicoDC.Fech_Ingreso = Convert.ToDateTime(objMecanico.Fech_Ingreso);
                    objMecanicoDC.Doc_Iden = objMecanico.Doc_Iden;
                    objMecanicoDC.dir_mecanico = objMecanico.dir_mecanico;
                    objMecanicoDC.Telf_Mec = objMecanico.Telf_Mec;
                    objMecanicoDC.Fech_Nac = Convert.ToDateTime(objMecanico.Fec_Nac);
                    objMecanicoDC.Sexo = objMecanico.Sexo;
                    objMecanicoDC.Espe_Mec = objMecanico.Espe_Mec;
                    objMecanicoDC.Centro_Estudios = objMecanico.Centro_Estudios;
                    objMecanicoDC.Correo_Mec = objMecanico.Correo_Mec;
                    objMecanicoDC.Fech_Registro = Convert.ToDateTime(objMecanico.Fec_Registro);
                    objMecanicoDC.Usu_Registro = objMecanico.Usu_Registro;
                    objMecanicoDC.Fech_Ult_Mod = Convert.ToDateTime(objMecanico.Fec_Ult_Mod);
                    objMecanicoDC.Usu_Ult_Mod = objMecanico.Usu_Ult_Mod;                   

                    return objMecanicoDC;
                }
                catch (EntityException ex)
                {
                    throw new Exception(ex.Message);
                }            
        }
    }
}