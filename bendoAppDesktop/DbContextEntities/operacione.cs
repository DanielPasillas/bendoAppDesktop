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
    
    public partial class operacione
    {
        public operacione()
        {
            this.operaciones_modulos = new HashSet<operaciones_modulos>();
        }
    
        public long id_operacion { get; set; }
        public long id_modulo { get; set; }
        public string operacion { get; set; }
    
        public virtual modulo modulo { get; set; }
        public virtual ICollection<operaciones_modulos> operaciones_modulos { get; set; }
    }
}
