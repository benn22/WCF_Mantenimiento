//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Mant
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_Factura
    {
        public string Num_Factura { get; set; }
        public System.DateTime fec_fac { get; set; }
        public Nullable<System.DateTime> Fec_can { get; set; }
        public string Est_fac { get; set; }
        public Nullable<System.DateTime> Fec_Registro { get; set; }
        public string Usu_registro { get; set; }
        public Nullable<System.DateTime> Fec_Ulti_Mod { get; set; }
        public string Usu_Ulti_Mod { get; set; }
        public string idMantenimiento { get; set; }
        public string idCliente { get; set; }
    
        public virtual Tb_Cliente Tb_Cliente { get; set; }
        public virtual Tb_Mantenimiento Tb_Mantenimiento { get; set; }
    }
}
