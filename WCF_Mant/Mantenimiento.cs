using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Mant
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Mantenimiento" en el código y en el archivo de configuración a la vez.
    public class Mantenimiento : IMantenimiento
    {
        MANTENIMIENTO Mant = new MANTENIMIENTO();
        public List<MantDC> ListarMantenimientoFechas(DateTime fecini, DateTime fecfin)
        {
            try
            {
                List<MantDC> list = new List<MantDC>();
                var query = Mant.usp_MantFechas( fecini, fecfin);

                foreach (var resultado in query)
                {
                    MantDC objMantDC = new MantDC();
                    objMantDC.idMantenimiento = resultado.idMantenimiento;
                    objMantDC.fec_fac = Convert.ToDateTime(resultado.fec_fac);
                    objMantDC.Fec_can = Convert.ToDateTime(resultado.Fec_can);
                    objMantDC.idVehiculo = resultado.idVehiculo;
                    objMantDC.Num_Factura = resultado.Num_Factura;
                    objMantDC.Est_fac = Convert.ToSingle(resultado.Est_fac);
                    objMantDC.EstadoFactura=resultado.EstadoFactura;
                    objMantDC.Nom_cli = resultado.Nom_cli;
                    objMantDC.Ape_cli = resultado.Ape_cli;
                    objMantDC.Dni_Cli = resultado.Dni_Cli;
                    objMantDC.Ruc_Cli = resultado.Ruc_Cli;
                    objMantDC.Raz_soc_cli= resultado.Raz_soc_cli;
                    list.Add(objMantDC);
                }


                return list;
            }
            catch (Exception ex )
            {

                throw new Exception(ex.Message);
            }
            
        }
    }
}
