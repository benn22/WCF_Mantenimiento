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
    
    public partial class Tb_Mantenimiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Mantenimiento()
        {
            this.Tb_Factura = new HashSet<Tb_Factura>();
            this.Tb_Mant_Detalle = new HashSet<Tb_Mant_Detalle>();
        }
    
        public string idMantenimiento { get; set; }
        public string idVehiculo { get; set; }
        public string idMecanico { get; set; }
        public System.DateTime Fec_Mant_Inic { get; set; }
        public System.DateTime Fec_Mant_Fin { get; set; }
        public int Kilom_Veh_Ent { get; set; }
        public int Kilom_Veh_Sali { get; set; }
        public Nullable<int> Horom_Veh { get; set; }
        public byte[] FotoAntes { get; set; }
        public byte[] FotoDespues { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Factura> Tb_Factura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Mant_Detalle> Tb_Mant_Detalle { get; set; }
        public virtual Tb_Mecanico Tb_Mecanico { get; set; }
        public virtual Tb_Vehiculo Tb_Vehiculo { get; set; }
    }
}
