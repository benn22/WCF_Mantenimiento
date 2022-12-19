using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Mant
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IMecanico" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IMecanico
    {
        [OperationContract]
        List<MecanicoFecDC> ListarMecanicoFechas(String strMecanico, DateTime fecini, DateTime fecfin);

        [OperationContract]
        List<MecanicoDC> ListarMecanico();

        [OperationContract]
        Boolean InsertarMecanico(MecanicoDC objMecanicoDC);

        [OperationContract]
        Boolean ActualizarMecanico(MecanicoDC objMecanicoDC);

        [OperationContract]
        Boolean EliminarMecanico(String strCodigo);

        [OperationContract]
        MecanicoDC ConsultarMecanico(String strCodigo);
    }



    [DataContract]
    [Serializable]
    public class MecanicoFecDC
    {
        [DataMember]
        public String idMecanico { get; set; }
        [DataMember]
        public Single Est_Mec { get; set; }
        [DataMember]
        public String Estado { get; set; }
        [DataMember]
        public DateTime Fech_Ingreso { get; set; }
        [DataMember]
        public String idMantenimiento { get; set; }
        [DataMember]
        public DateTime Fec_Mant_Inic { get; set; }
        [DataMember]
        public DateTime Fec_Mant_Fin { get; set; }
        [DataMember]
        public String idVehiculo { get; set; }
        [DataMember]
        public Single Tipo_unidad { get; set; }
        [DataMember]
        public String TipoUnidad { get; set; }

        [DataMember]
        public String Nom_cli { get; set; }
        [DataMember]
        public String Ape_cli { get; set; }
        [DataMember]
        public String Ruc_Cli { get; set; }
        [DataMember]
        public String Raz_soc_cli { get; set; }
        [DataMember]
        public String Nom_mec { get; set; }
        [DataMember]
        public String Ape_mec { get; set; }
    }
    
    [DataContract]
    [Serializable]
    public class MecanicoDC
    {
        [DataMember]
        public String idMecanico { get; set; }

        [DataMember]
        public String cod_ubigeo { get; set; }

        [DataMember]
        public String Nom_mec { get; set; }

        [DataMember]
        public String Ape_mec { get; set; }

        [DataMember]
        public String Doc_Iden { get; set; }

        [DataMember]
        public String dir_mecanico { get; set; }

        [DataMember]
        public DateTime Fech_Ingreso { get; set; }

        [DataMember]
        public String Telf_Mec { get; set; }

        [DataMember]
        public DateTime Fech_Nac { get; set; }

        [DataMember]
        public String Sexo { get; set; }

        [DataMember]
        public String Espe_Mec { get; set; }

        [DataMember]
        public String Centro_Estudios { get; set; }

        [DataMember]
        public String Correo_Mec { get; set; }

        [DataMember]
        public DateTime Fech_Registro { get; set; }

        [DataMember]
        public String Usu_Registro { get; set; }

        [DataMember]
        public Int16 Est_Mec { get; set; }

        [DataMember]
        public String Estado { get; set; }
        
        [DataMember]
        public DateTime Fech_Ult_Mod { get; set; }

        [DataMember]
        public String Usu_Ult_Mod { get; set; }
    }
}