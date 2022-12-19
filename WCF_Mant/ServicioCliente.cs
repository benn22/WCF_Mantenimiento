using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Mant
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCliente" en el código y en el archivo de configuración a la vez.
    public class ServicioCliente : IServicioCliente
    {
        MANTENIMIENTO mant = new MANTENIMIENTO();
        
        public ClienteDC ConsultarCliente(String strCodigo)
        {
            try
            {
                Tb_Cliente objCliente = (from objCli in mant.Tb_Cliente where objCli.idCliente == strCodigo select objCli).FirstOrDefault();
                ClienteDC objClienteDC = new ClienteDC();
                objClienteDC.idCliente = objCliente.idCliente;
                objClienteDC.cod_ubigeo = objCliente.cod_ubigeo;
                objClienteDC.Nom_cli = objCliente.Nom_cli;
                objClienteDC.Ape_cli = objCliente.Ape_cli;
                objClienteDC.dir_cli = objCliente.dir_cli;
                objClienteDC.Ruc_Cli = objCliente.Ruc_Cli;
                objClienteDC.Telf_Cli = objCliente.Telf_Cli;
                objClienteDC.Fec_Nac_Cli = Convert.ToDateTime(objCliente.Fec_Nac_Cli);
                objClienteDC.Correo_Cli = objCliente.Correo_Cli;
                objClienteDC.Sexo = objCliente.Sexo;
                objClienteDC.Raz_soc_cli = objCliente.Raz_soc_cli;
                objClienteDC.Dni_Cli = objCliente.Dni_Cli;
                objClienteDC.Fec_Reg_Cli = Convert.ToDateTime(objCliente.Registro_Cliente);
                objClienteDC.Usu_Registro = objCliente.Usu_Registro;
                objClienteDC.Fec_Ult_Mod = Convert.ToDateTime(objCliente.Fec_Ult_Mod);
                objClienteDC.Usu_Ult_Mod = objCliente.Usu_Ult_Mod;
                objClienteDC.Est_Cli = Convert.ToInt16(objCliente.Est_Cli);
                objClienteDC.TipoCliente = Convert.ToInt16(objCliente.TipoCliente);

                return objClienteDC;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public List<ClienteFecDC> ListarClienteFechas(String strCliente, DateTime fecini, DateTime fecfin)
        {

            try
            {
                List<ClienteFecDC> objList = new List<ClienteFecDC>();

                var query = mant.usp_ClientesFechas(strCliente, fecini, fecfin);

                foreach (var resultado in query)
                {
                    ClienteFecDC objClienteFecDC = new ClienteFecDC();
                    objClienteFecDC.idCliente = resultado.idCliente;
                    objClienteFecDC.Nom_cli=resultado.Nom_cli;
                    objClienteFecDC.Ape_cli = resultado.Ape_cli;
                    objClienteFecDC.Ruc_Cli = resultado.Ruc_Cli;
                    objClienteFecDC.Raz_soc_cli = resultado.Raz_soc_cli;
                    objClienteFecDC.Dni_Cli = resultado.Dni_Cli;
                    objClienteFecDC.EstadoCliente = resultado.EstadoCliente;
                    objClienteFecDC.Est_Cli= Convert.ToSingle(resultado.Est_Cli);
                    objClienteFecDC.idVehiculo = resultado.idVehiculo;
                    objClienteFecDC.idMarca = resultado.idMarca;
                    objClienteFecDC.TipoUnidad = resultado.TipoUnidad;
                    objClienteFecDC.Tipo_Unidad =Convert.ToSingle(resultado.Tipo_Unidad);
                    objClienteFecDC.Fec_Mant_Inic = Convert.ToDateTime(resultado.Fec_Mant_Inic);
                    objClienteFecDC.Fec_Mant_Fin = Convert.ToDateTime(resultado.Fec_Mant_Fin);
                    objClienteFecDC.Nom_mec =resultado.Nom_mec;
                    objClienteFecDC.Ape_mec = resultado.Ape_mec;
                    objClienteFecDC.EstadoMecanico = resultado.EstadoMecanico;
                    objClienteFecDC.Est_Mec = Convert.ToSingle(resultado.Est_Mec);

                    objList.Add(objClienteFecDC);
                    
                }

                return objList;
            }
            catch (Exception ex )
            {
                throw new Exception(ex.Message);
            }

        }

        public List<ClienteDC> ListarCliente()
        {

            try
            {
                List<ClienteDC> objList = new List<ClienteDC>();

                var query = mant.usp_ListarClienteGrilla();

                foreach (var resultado in query)
                {
                    ClienteDC objClienteDC = new ClienteDC();
                    objClienteDC.idCliente = resultado.idCliente;
                    objClienteDC.Nom_cli = resultado.Nom_cli;
                    objClienteDC.Ape_cli = resultado.Ape_cli;
                    objClienteDC.Ruc_Cli = resultado.Ruc_Cli;
                    objClienteDC.Raz_soc_cli = resultado.Raz_soc_cli;
                    objClienteDC.Dni_Cli = resultado.Dni_Cli;
                    objClienteDC.EstadoCliente = resultado.EstadoCliente;
                    objClienteDC.Est_Cli = Convert.ToSingle(resultado.Est_Cli);
                    objList.Add(objClienteDC);

                }

                return objList;
            }
            catch (Exception ex)
            {


                throw new Exception(ex.Message);
            }

        }

        public Boolean InsertarCliente(ClienteDC objClienteDC)
        {
            try
            {
                mant.usp_InsertarCliente
                    (
                    objClienteDC.cod_ubigeo,objClienteDC.Nom_cli,objClienteDC.Ape_cli,objClienteDC.dir_cli,objClienteDC.Ruc_Cli,objClienteDC.Telf_Cli,Convert.ToDateTime(objClienteDC.Fec_Nac_Cli),objClienteDC.Correo_Cli,
                    objClienteDC.Sexo,objClienteDC.Dni_Cli,objClienteDC.Usu_Registro, Convert.ToInt16(objClienteDC.Est_Cli), Convert.ToInt16(objClienteDC.TipoCliente)
                  );
                mant.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean ActualizarCliente(ClienteDC objClienteDC)
        {
            try
            {
                mant.usp_ActualizarCliente
                    (
                    objClienteDC.idCliente,objClienteDC.cod_ubigeo, objClienteDC.Nom_cli, objClienteDC.Ape_cli, objClienteDC.dir_cli, objClienteDC.Ruc_Cli, objClienteDC.Telf_Cli, Convert.ToDateTime(objClienteDC.Fec_Nac_Cli), objClienteDC.Correo_Cli,
                    objClienteDC.Sexo, objClienteDC.Dni_Cli, objClienteDC.Usu_Ult_Mod, Convert.ToInt16(objClienteDC.Est_Cli), Convert.ToInt16(objClienteDC.TipoCliente)
                  );

                mant.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public Boolean EliminarCliente(String strCodigo)
        {
            try
            {
                mant.usp_EliminarCliente(strCodigo);

                mant.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}