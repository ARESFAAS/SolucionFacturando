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
    
    public partial class Bill
    {
        public Bill()
        {
            this.BillDetail = new HashSet<BillDetail>();
            this.BillTaxes = new HashSet<BillTaxes>();
        }
    
        public System.Guid Id { get; set; }
        public decimal Total { get; set; }
        public long BillNumber { get; set; }
        public Nullable<System.Guid> IdClient { get; set; }
        public Nullable<System.DateTime> DateEvent { get; set; }
        public Nullable<bool> IsCanceled { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }
        public Nullable<System.DateTime> LimitDate { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual ICollection<BillDetail> BillDetail { get; set; }
        public virtual ICollection<BillTaxes> BillTaxes { get; set; }
    }
}
