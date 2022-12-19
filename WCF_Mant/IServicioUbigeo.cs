using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Mant
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioUbigeo" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioUbigeo
    {
        [OperationContract]
        List<UbigeoDC> ListarUbigeo_Departamento();

        [OperationContract]
        List<UbigeoDC> ListarUbigeo_ProvinciasDepartamento(String strIdDepartamento);

        [OperationContract]
        List<UbigeoDC> ListarUbigeo_DistritoProvinciaDepartamento(String strIdDepartamento, String strIdProvincia);
    }

    [DataContract]
    [Serializable]

    public class UbigeoDC
    {
        [DataMember] 
        public String cod_ubigeo { get; set; }
        [DataMember]
        public String IdDepa { get; set; }
        [DataMember]
        public String IdProv {get; set; }
        [DataMember]
        public String IdDist { get; set; }
        [DataMember]
        public String Departamento { get; set; }
        [DataMember]
        public String Provincia { get; set; }
        [DataMember]
        public String Distrito { get; set; }



    }
}
