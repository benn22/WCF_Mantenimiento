using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Mant
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IMantenimiento" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IMantenimiento
    {
        [OperationContract]        
        List<MantDC> ListarMantenimientoFechas(DateTime fecini, DateTime fecfin);
        [OperationContract]
        List<MantYearDC> ListarMantenimientoYear(Int16 Year);
    }

    [DataContract]
    [Serializable]
    public class MantDC
    {
        [DataMember]
        public String idMantenimiento { get; set; }
        [DataMember]
        public String idVehiculo { get; set; }
        [DataMember]
        public String Num_Factura { get; set; }
        [DataMember]
        public Single Est_fac { get; set; }
        [DataMember]
        public String EstadoFactura { get; set; }
        [DataMember]
        public DateTime fec_fac { get; set; }
        [DataMember]
        public DateTime Fec_can { get; set; }
        [DataMember]
        public String Nom_cli { get; set; }
        [DataMember]
        public String Ape_cli { get; set; }
        [DataMember]
        public String Dni_Cli { get; set; }

        [DataMember]
        public String Ruc_Cli { get; set; }
        [DataMember]
        public String Raz_soc_cli { get; set; }
        
    }

    [DataContract]
    [Serializable]
    public class MantYearDC
    {
        [DataMember]
        public String idMecanico { get; set; }
        [DataMember]
        public String NombreCompleto { get; set; }
        [DataMember]
        public String idVehiculo { get; set; }
        [DataMember]
        public Int16 tipo_mantenimiento { get; set; }
        [DataMember]
        public String Mantenimiento { get; set; }
        [DataMember]
        public String Nombre_Man { get; set; }
        [DataMember]
        public Int16 Estado_Man { get; set; }
        [DataMember]
        public String Estado { get; set; }
        [DataMember]
        public Single Costo_Man { get; set; }
        [DataMember]
        public DateTime Fecha { get; set; }
    }
}