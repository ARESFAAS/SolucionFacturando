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
    
    public partial class Tax
    {
        public Tax()
        {
            this.BillTaxes = new HashSet<BillTaxes>();
        }
    
        public System.Guid Id { get; set; }
        public string Description { get; set; }
        public decimal PercentageValue { get; set; }
    
        public virtual ICollection<BillTaxes> BillTaxes { get; set; }
    }
}
