//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Facturando.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rol
    {
        public Rol()
        {
            this.RolAction = new HashSet<RolAction>();
            this.RolModule = new HashSet<RolModule>();
            this.UserRol = new HashSet<UserRol>();
        }
    
        public System.Guid Id { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<RolAction> RolAction { get; set; }
        public virtual ICollection<RolModule> RolModule { get; set; }
        public virtual ICollection<UserRol> UserRol { get; set; }
    }
}
