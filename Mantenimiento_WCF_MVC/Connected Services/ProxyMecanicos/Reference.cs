//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mantenimiento_WCF_MVC.ProxyMecanicos {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MecanicoFecDC", Namespace="http://schemas.datacontract.org/2004/07/WCF_Mant")]
    [System.SerializableAttribute()]
    public partial class MecanicoFecDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Ape_cliField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Ape_mecField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float Est_MecField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fec_Mant_FinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fec_Mant_InicField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fech_IngresoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nom_cliField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nom_mecField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Raz_soc_cliField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Ruc_CliField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoUnidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float Tipo_unidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idMantenimientoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idMecanicoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idVehiculoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ape_cli {
            get {
                return this.Ape_cliField;
            }
            set {
                if ((object.ReferenceEquals(this.Ape_cliField, value) != true)) {
                    this.Ape_cliField = value;
                    this.RaisePropertyChanged("Ape_cli");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ape_mec {
            get {
                return this.Ape_mecField;
            }
            set {
                if ((object.ReferenceEquals(this.Ape_mecField, value) != true)) {
                    this.Ape_mecField = value;
                    this.RaisePropertyChanged("Ape_mec");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Est_Mec {
            get {
                return this.Est_MecField;
            }
            set {
                if ((this.Est_MecField.Equals(value) != true)) {
                    this.Est_MecField = value;
                    this.RaisePropertyChanged("Est_Mec");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fec_Mant_Fin {
            get {
                return this.Fec_Mant_FinField;
            }
            set {
                if ((this.Fec_Mant_FinField.Equals(value) != true)) {
                    this.Fec_Mant_FinField = value;
                    this.RaisePropertyChanged("Fec_Mant_Fin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fec_Mant_Inic {
            get {
                return this.Fec_Mant_InicField;
            }
            set {
                if ((this.Fec_Mant_InicField.Equals(value) != true)) {
                    this.Fec_Mant_InicField = value;
                    this.RaisePropertyChanged("Fec_Mant_Inic");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fech_Ingreso {
            get {
                return this.Fech_IngresoField;
            }
            set {
                if ((this.Fech_IngresoField.Equals(value) != true)) {
                    this.Fech_IngresoField = value;
                    this.RaisePropertyChanged("Fech_Ingreso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom_cli {
            get {
                return this.Nom_cliField;
            }
            set {
                if ((object.ReferenceEquals(this.Nom_cliField, value) != true)) {
                    this.Nom_cliField = value;
                    this.RaisePropertyChanged("Nom_cli");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom_mec {
            get {
                return this.Nom_mecField;
            }
            set {
                if ((object.ReferenceEquals(this.Nom_mecField, value) != true)) {
                    this.Nom_mecField = value;
                    this.RaisePropertyChanged("Nom_mec");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Raz_soc_cli {
            get {
                return this.Raz_soc_cliField;
            }
            set {
                if ((object.ReferenceEquals(this.Raz_soc_cliField, value) != true)) {
                    this.Raz_soc_cliField = value;
                    this.RaisePropertyChanged("Raz_soc_cli");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ruc_Cli {
            get {
                return this.Ruc_CliField;
            }
            set {
                if ((object.ReferenceEquals(this.Ruc_CliField, value) != true)) {
                    this.Ruc_CliField = value;
                    this.RaisePropertyChanged("Ruc_Cli");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoUnidad {
            get {
                return this.TipoUnidadField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoUnidadField, value) != true)) {
                    this.TipoUnidadField = value;
                    this.RaisePropertyChanged("TipoUnidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Tipo_unidad {
            get {
                return this.Tipo_unidadField;
            }
            set {
                if ((this.Tipo_unidadField.Equals(value) != true)) {
                    this.Tipo_unidadField = value;
                    this.RaisePropertyChanged("Tipo_unidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string idMantenimiento {
            get {
                return this.idMantenimientoField;
            }
            set {
                if ((object.ReferenceEquals(this.idMantenimientoField, value) != true)) {
                    this.idMantenimientoField = value;
                    this.RaisePropertyChanged("idMantenimiento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string idMecanico {
            get {
                return this.idMecanicoField;
            }
            set {
                if ((object.ReferenceEquals(this.idMecanicoField, value) != true)) {
                    this.idMecanicoField = value;
                    this.RaisePropertyChanged("idMecanico");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string idVehiculo {
            get {
                return this.idVehiculoField;
            }
            set {
                if ((object.ReferenceEquals(this.idVehiculoField, value) != true)) {
                    this.idVehiculoField = value;
                    this.RaisePropertyChanged("idVehiculo");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MecanicoDC", Namespace="http://schemas.datacontract.org/2004/07/WCF_Mant")]
    [System.SerializableAttribute()]
    public partial class MecanicoDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Ape_mecField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Centro_EstudiosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Correo_MecField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Doc_IdenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Espe_MecField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float Est_MecField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fech_IngresoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fech_NacField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fech_RegistroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fech_Ult_ModField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nom_mecField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Telf_MecField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Usu_RegistroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Usu_Ult_ModField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cod_ubigeoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string dir_mecanicoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idMecanicoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ape_mec {
            get {
                return this.Ape_mecField;
            }
            set {
                if ((object.ReferenceEquals(this.Ape_mecField, value) != true)) {
                    this.Ape_mecField = value;
                    this.RaisePropertyChanged("Ape_mec");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Centro_Estudios {
            get {
                return this.Centro_EstudiosField;
            }
            set {
                if ((object.ReferenceEquals(this.Centro_EstudiosField, value) != true)) {
                    this.Centro_EstudiosField = value;
                    this.RaisePropertyChanged("Centro_Estudios");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Correo_Mec {
            get {
                return this.Correo_MecField;
            }
            set {
                if ((object.ReferenceEquals(this.Correo_MecField, value) != true)) {
                    this.Correo_MecField = value;
                    this.RaisePropertyChanged("Correo_Mec");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Doc_Iden {
            get {
                return this.Doc_IdenField;
            }
            set {
                if ((object.ReferenceEquals(this.Doc_IdenField, value) != true)) {
                    this.Doc_IdenField = value;
                    this.RaisePropertyChanged("Doc_Iden");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Espe_Mec {
            get {
                return this.Espe_MecField;
            }
            set {
                if ((object.ReferenceEquals(this.Espe_MecField, value) != true)) {
                    this.Espe_MecField = value;
                    this.RaisePropertyChanged("Espe_Mec");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Est_Mec {
            get {
                return this.Est_MecField;
            }
            set {
                if ((this.Est_MecField.Equals(value) != true)) {
                    this.Est_MecField = value;
                    this.RaisePropertyChanged("Est_Mec");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((this.EstadoField.Equals(value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fech_Ingreso {
            get {
                return this.Fech_IngresoField;
            }
            set {
                if ((this.Fech_IngresoField.Equals(value) != true)) {
                    this.Fech_IngresoField = value;
                    this.RaisePropertyChanged("Fech_Ingreso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fech_Nac {
            get {
                return this.Fech_NacField;
            }
            set {
                if ((this.Fech_NacField.Equals(value) != true)) {
                    this.Fech_NacField = value;
                    this.RaisePropertyChanged("Fech_Nac");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fech_Registro {
            get {
                return this.Fech_RegistroField;
            }
            set {
                if ((this.Fech_RegistroField.Equals(value) != true)) {
                    this.Fech_RegistroField = value;
                    this.RaisePropertyChanged("Fech_Registro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fech_Ult_Mod {
            get {
                return this.Fech_Ult_ModField;
            }
            set {
                if ((this.Fech_Ult_ModField.Equals(value) != true)) {
                    this.Fech_Ult_ModField = value;
                    this.RaisePropertyChanged("Fech_Ult_Mod");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom_mec {
            get {
                return this.Nom_mecField;
            }
            set {
                if ((object.ReferenceEquals(this.Nom_mecField, value) != true)) {
                    this.Nom_mecField = value;
                    this.RaisePropertyChanged("Nom_mec");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sexo {
            get {
                return this.SexoField;
            }
            set {
                if ((object.ReferenceEquals(this.SexoField, value) != true)) {
                    this.SexoField = value;
                    this.RaisePropertyChanged("Sexo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telf_Mec {
            get {
                return this.Telf_MecField;
            }
            set {
                if ((object.ReferenceEquals(this.Telf_MecField, value) != true)) {
                    this.Telf_MecField = value;
                    this.RaisePropertyChanged("Telf_Mec");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Usu_Registro {
            get {
                return this.Usu_RegistroField;
            }
            set {
                if ((object.ReferenceEquals(this.Usu_RegistroField, value) != true)) {
                    this.Usu_RegistroField = value;
                    this.RaisePropertyChanged("Usu_Registro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Usu_Ult_Mod {
            get {
                return this.Usu_Ult_ModField;
            }
            set {
                if ((object.ReferenceEquals(this.Usu_Ult_ModField, value) != true)) {
                    this.Usu_Ult_ModField = value;
                    this.RaisePropertyChanged("Usu_Ult_Mod");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cod_ubigeo {
            get {
                return this.cod_ubigeoField;
            }
            set {
                if ((object.ReferenceEquals(this.cod_ubigeoField, value) != true)) {
                    this.cod_ubigeoField = value;
                    this.RaisePropertyChanged("cod_ubigeo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string dir_mecanico {
            get {
                return this.dir_mecanicoField;
            }
            set {
                if ((object.ReferenceEquals(this.dir_mecanicoField, value) != true)) {
                    this.dir_mecanicoField = value;
                    this.RaisePropertyChanged("dir_mecanico");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string idMecanico {
            get {
                return this.idMecanicoField;
            }
            set {
                if ((object.ReferenceEquals(this.idMecanicoField, value) != true)) {
                    this.idMecanicoField = value;
                    this.RaisePropertyChanged("idMecanico");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyMecanicos.IMecanico")]
    public interface IMecanico {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMecanico/ListarMecanicoFechas", ReplyAction="http://tempuri.org/IMecanico/ListarMecanicoFechasResponse")]
        Mantenimiento_WCF_MVC.ProxyMecanicos.MecanicoFecDC[] ListarMecanicoFechas(string strMecanico, System.DateTime fecini, System.DateTime fecfin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMecanico/ListarMecanicoFechas", ReplyAction="http://tempuri.org/IMecanico/ListarMecanicoFechasResponse")]
        System.Threading.Tasks.Task<Mantenimiento_WCF_MVC.ProxyMecanicos.MecanicoFecDC[]> ListarMecanicoFechasAsync(string strMecanico, System.DateTime fecini, System.DateTime fecfin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMecanico/ListarMecanico", ReplyAction="http://tempuri.org/IMecanico/ListarMecanicoResponse")]
        Mantenimiento_WCF_MVC.ProxyMecanicos.MecanicoDC[] ListarMecanico();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMecanico/ListarMecanico", ReplyAction="http://tempuri.org/IMecanico/ListarMecanicoResponse")]
        System.Threading.Tasks.Task<Mantenimiento_WCF_MVC.ProxyMecanicos.MecanicoDC[]> ListarMecanicoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMecanico/InsertarMecanico", ReplyAction="http://tempuri.org/IMecanico/InsertarMecanicoResponse")]
        bool InsertarMecanico(Mantenimiento_WCF_MVC.ProxyMecanicos.MecanicoDC objMecanicoDC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMecanico/InsertarMecanico", ReplyAction="http://tempuri.org/IMecanico/InsertarMecanicoResponse")]
        System.Threading.Tasks.Task<bool> InsertarMecanicoAsync(Mantenimiento_WCF_MVC.ProxyMecanicos.MecanicoDC objMecanicoDC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMecanico/ActualizarMecanico", ReplyAction="http://tempuri.org/IMecanico/ActualizarMecanicoResponse")]
        bool ActualizarMecanico(Mantenimiento_WCF_MVC.ProxyMecanicos.MecanicoDC objMecanicoDC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMecanico/ActualizarMecanico", ReplyAction="http://tempuri.org/IMecanico/ActualizarMecanicoResponse")]
        System.Threading.Tasks.Task<bool> ActualizarMecanicoAsync(Mantenimiento_WCF_MVC.ProxyMecanicos.MecanicoDC objMecanicoDC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMecanico/EliminarMecanico", ReplyAction="http://tempuri.org/IMecanico/EliminarMecanicoResponse")]
        bool EliminarMecanico(string strCodigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMecanico/EliminarMecanico", ReplyAction="http://tempuri.org/IMecanico/EliminarMecanicoResponse")]
        System.Threading.Tasks.Task<bool> EliminarMecanicoAsync(string strCodigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMecanico/ConsultarMecanico", ReplyAction="http://tempuri.org/IMecanico/ConsultarMecanicoResponse")]
        Mantenimiento_WCF_MVC.ProxyMecanicos.MecanicoDC ConsultarMecanico(string strCodigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMecanico/ConsultarMecanico", ReplyAction="http://tempuri.org/IMecanico/ConsultarMecanicoResponse")]
        System.Threading.Tasks.Task<Mantenimiento_WCF_MVC.ProxyMecanicos.MecanicoDC> ConsultarMecanicoAsync(string strCodigo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMecanicoChannel : Mantenimiento_WCF_MVC.ProxyMecanicos.IMecanico, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MecanicoClient : System.ServiceModel.ClientBase<Mantenimiento_WCF_MVC.ProxyMecanicos.IMecanico>, Mantenimiento_WCF_MVC.ProxyMecanicos.IMecanico {
        
        public MecanicoClient() {
        }
        
        public MecanicoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MecanicoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MecanicoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MecanicoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Mantenimiento_WCF_MVC.ProxyMecanicos.MecanicoFecDC[] ListarMecanicoFechas(string strMecanico, System.DateTime fecini, System.DateTime fecfin) {
            return base.Channel.ListarMecanicoFechas(strMecanico, fecini, fecfin);
        }
        
        public System.Threading.Tasks.Task<Mantenimiento_WCF_MVC.ProxyMecanicos.MecanicoFecDC[]> ListarMecanicoFechasAsync(string strMecanico, System.DateTime fecini, System.DateTime fecfin) {
            return base.Channel.ListarMecanicoFechasAsync(strMecanico, fecini, fecfin);
        }
        
        public Mantenimiento_WCF_MVC.ProxyMecanicos.MecanicoDC[] ListarMecanico() {
            return base.Channel.ListarMecanico();
        }
        
        public System.Threading.Tasks.Task<Mantenimiento_WCF_MVC.ProxyMecanicos.MecanicoDC[]> ListarMecanicoAsync() {
            return base.Channel.ListarMecanicoAsync();
        }
        
        public bool InsertarMecanico(Mantenimiento_WCF_MVC.ProxyMecanicos.MecanicoDC objMecanicoDC) {
            return base.Channel.InsertarMecanico(objMecanicoDC);
        }
        
        public System.Threading.Tasks.Task<bool> InsertarMecanicoAsync(Mantenimiento_WCF_MVC.ProxyMecanicos.MecanicoDC objMecanicoDC) {
            return base.Channel.InsertarMecanicoAsync(objMecanicoDC);
        }
        
        public bool ActualizarMecanico(Mantenimiento_WCF_MVC.ProxyMecanicos.MecanicoDC objMecanicoDC) {
            return base.Channel.ActualizarMecanico(objMecanicoDC);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarMecanicoAsync(Mantenimiento_WCF_MVC.ProxyMecanicos.MecanicoDC objMecanicoDC) {
            return base.Channel.ActualizarMecanicoAsync(objMecanicoDC);
        }
        
        public bool EliminarMecanico(string strCodigo) {
            return base.Channel.EliminarMecanico(strCodigo);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarMecanicoAsync(string strCodigo) {
            return base.Channel.EliminarMecanicoAsync(strCodigo);
        }
        
        public Mantenimiento_WCF_MVC.ProxyMecanicos.MecanicoDC ConsultarMecanico(string strCodigo) {
            return base.Channel.ConsultarMecanico(strCodigo);
        }
        
        public System.Threading.Tasks.Task<Mantenimiento_WCF_MVC.ProxyMecanicos.MecanicoDC> ConsultarMecanicoAsync(string strCodigo) {
            return base.Channel.ConsultarMecanicoAsync(strCodigo);
        }
    }
}
