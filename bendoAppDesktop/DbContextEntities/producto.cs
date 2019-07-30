//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bendoAppDesktop.DbContextEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class producto
    {
        public producto()
        {
            this.detalle_venta = new HashSet<detalle_venta>();
            this.kits_paquetes = new HashSet<kits_paquetes>();
        }
    
        public long id_producto { get; set; }
        public string codigo_barras { get; set; }
        public string descripcion { get; set; }
        public long id_unidad { get; set; }
        public long id_categoria { get; set; }
        public decimal precio_costo { get; set; }
        public decimal ganancia { get; set; }
        public decimal precio_venta { get; set; }
        public decimal precio_mayoreo { get; set; }
        public int utiliza_inventario { get; set; }
        public decimal existencias { get; set; }
        public decimal minimo { get; set; }
        public decimal maximo { get; set; }
    
        public virtual categoria categoria { get; set; }
        public virtual ICollection<detalle_venta> detalle_venta { get; set; }
        public virtual ICollection<kits_paquetes> kits_paquetes { get; set; }
        public virtual unidades_medida unidades_medida { get; set; }
    }
}