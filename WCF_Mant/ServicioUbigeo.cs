using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Mant
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUbigeo" en el código y en el archivo de configuración a la vez.
    public class ServicioUbigeo : IServicioUbigeo
 
    {
        MANTENIMIENTO mant = new MANTENIMIENTO();
        public List<UbigeoDC> ListarUbigeo_Departamento()
        {
            try
            {
                List<UbigeoDC> lista = new List<UbigeoDC>();

                var query = mant.usp_Ubigeo_Departamentos();

                foreach(var resultado in query)
                {

                    UbigeoDC objUbigeo  =  new UbigeoDC();
                    objUbigeo.IdDepa = resultado.IDDEPA;
                    objUbigeo.Departamento = resultado.DEPARTAMENTO;

                   lista.Add(objUbigeo);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<UbigeoDC> ListarUbigeo_ProvinciasDepartamento(String strIdDepartamento)
        {
            try
            {
                List<UbigeoDC> lista = new List<UbigeoDC>();

                var query = mant.usp_Ubigeo_ProvinciasDepartamento(strIdDepartamento);

                foreach (var resultado in query)
                {

                    UbigeoDC objUbigeo = new UbigeoDC();
                    
                    objUbigeo.Provincia = resultado.PROVINCIA;
                    objUbigeo.IdProv = resultado.IDPROV;
                    
                    lista.Add(objUbigeo);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<UbigeoDC> ListarUbigeo_DistritoProvinciaDepartamento(String strIdDepartamento, String strIdProvincia)
        {
            try
            {
                List<UbigeoDC> lista = new List<UbigeoDC>();

                var query = mant.usp_Ubigeo_DistritosProvinciaDepartamento(strIdDepartamento, strIdProvincia);

                foreach (var resultado in query)
                {

                    UbigeoDC objUbigeo = new UbigeoDC();

                    
                    objUbigeo.Distrito = resultado.DISTRITO;
                    objUbigeo.IdDist = resultado.IDDIST;
                    

                    lista.Add(objUbigeo);
                }
                return lista;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
