using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturando.Modelos
{
    public class CashBoxModel
    {
        public Guid Id { get; set; }
        public long CashNumber { get; set; }
        public decimal Total { get; set; }
        public DateTime? OpenDate { get; set; }
        public decimal CloseTotal { get; set; }
        public DateTime? CloseDate { get; set; }
        public bool IsClosed { get; set; }
        public Guid IdUser { get; set; }
        public string Comments { get; set; }
        public string EditCashBox { get; set; }
       
    }

    public class CashBoxDetailModel
    {
        public Guid Id { get; set; }
        public Guid IdCashBox { get; set; }
        public decimal Total { get; set; }
        public DateTime? MovementDate { get; set; }
        public Guid IdCashBoxType { get; set; }
        public string Sign { get; set; }
        public string CashBoxTypeDescription { get; set; }
        public string Comments { get; set; }
    }

    public class CashBoxTypeModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Sign { get; set; }
    }

    public class CashBoxSaveModel
    {        
        public CashBoxModel CashBox { get; set; }
        public List<CashBoxDetailModel> CashBoxDetail { get; set;}
    }

    interface IFormCashBox
    {
        void NewCashBox(CashBoxSaveModel cashBox, int typeRegister);
    }
}
