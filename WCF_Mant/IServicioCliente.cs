using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCF_Mant
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioCliente" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioCliente
    {        
        [OperationContract]
        ClienteDC ConsultarCliente(String strCodigo);
        [OperationContract]
        List<ClienteFecDC> ListarClienteFechas(String strCliente,DateTime fecini, DateTime fecfin);

        [OperationContract]
        List<ClienteDC> ListarCliente();

        [OperationContract]
        Boolean InsertarCliente(ClienteDC objClienteDC);

        [OperationContract]
        Boolean ActualizarCliente(ClienteDC objClienteDC);
        [OperationContract]
        Boolean EliminarCliente(String strCodigo);

    }

    [DataContract]
    [Serializable]
    public class ClienteFecDC
    {
        [DataMember]
        public String idCliente { get; set; }       
        [DataMember]
        public String Ape_cli { get; set; }
        [DataMember]
        public String Nom_cli { get; set; }
        [DataMember]
        public String Ruc_Cli { get; set; }
        [DataMember]
        public String Raz_soc_cli { get; set; }
        [DataMember]
        public String Dni_Cli { get; set; }
        [DataMember]
        public Single Est_Cli { get; set; }
        [DataMember]
        public String EstadoCliente { get; set; }
        [DataMember]
        public String idVehiculo { get; set; }
        [DataMember]
        public String idMarca { get; set; }

        [DataMember]
        public Single Tipo_Unidad { get; set; }
        [DataMember]
        public String TipoUnidad { get; set; }
        [DataMember]
        public DateTime Fec_Mant_Inic { get; set; }
        [DataMember]
        public DateTime Fec_Mant_Fin { get; set; }
        [DataMember]
        public String Nom_mec { get; set; }
        [DataMember]
        public String Ape_mec { get; set; }
        [DataMember]
        public Single Est_Mec { get; set; }

        [DataMember]
        public String EstadoMecanico { get; set; }
    }

    public class ClienteDC
    {
        [DataMember]
        public String idCliente { get; set;}
        [DataMember]
        public String Ape_cli { get; set; }
        [DataMember]
        public String Nom_cli { get; set; }
        [DataMember]
        public String Ruc_Cli { get; set; }
        [DataMember]
        public String Raz_soc_cli { get; set; }
        [DataMember]
        public String Dni_Cli { get; set; }
        [DataMember]
        public Single Est_Cli { get; set; }
        [DataMember]
        public String EstadoCliente { get; set; }

        [DataMember]
        public String dir_cli { get; set; }

        [DataMember]
        public String Telf_Cli { get; set; }
        [DataMember]
        public DateTime Fec_Reg_Cli { get; set; }
        [DataMember]
        public DateTime Fec_Ult_Mod { get; set; }
        [DataMember]
        public DateTime Fec_Nac_Cli { get; set; }

        [DataMember]
        public String Correo_Cli { get; set; }

        [DataMember]
        public String Sexo { get; set; }

        [DataMember]
        public String cod_ubigeo { get; set; }

        [DataMember]
        public String Usu_Registro { get; set; }

        [DataMember]
        public Single TipoCliente { get; set; }

        [DataMember]
        public String Usu_Ult_Mod { get; set; }
    }
}

