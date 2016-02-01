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
    
    public partial class Client
    {
        public Client()
        {
            this.Bill = new HashSet<Bill>();
            this.Remission = new HashSet<Remission>();
        }
    
        public System.Guid Id { get; set; }
        public string IdentificationNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal DisccountPercent { get; set; }
        public Nullable<System.Guid> IdIdentificationType { get; set; }
    
        public virtual ICollection<Bill> Bill { get; set; }
        public virtual ICollection<Remission> Remission { get; set; }
        public virtual IdentificacionType IdentificacionType { get; set; }
    }
}
