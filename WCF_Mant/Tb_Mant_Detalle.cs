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
    
    public partial class Tb_Mant_Detalle
    {
        public string idMant_Detalle { get; set; }
        public int tipo_mantenimiento { get; set; }
        public string idMantenimiento { get; set; }
        public string idAct_Man { get; set; }
        public string id_Sist_Veh { get; set; }
        public string id_Sub_Sist_Veh { get; set; }
        public string idRep { get; set; }
    
        public virtual Tb_Act_Man Tb_Act_Man { get; set; }
        public virtual Tb_Sist_Veh Tb_Sist_Veh { get; set; }
        public virtual Tb_Sub_Sist_Veh Tb_Sub_Sist_Veh { get; set; }
        public virtual Tb_Mantenimiento Tb_Mantenimiento { get; set; }
        public virtual Tb_Repuesto Tb_Repuesto { get; set; }
    }
}