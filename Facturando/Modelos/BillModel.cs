using System;
using System.Collections.Generic;

namespace Facturando.Modelos
{
    public class BillModel
    {
        public Guid Id { get; set; }
        public decimal Total { get; set; }
        public long BillNumber { get; set; }
        public Guid IdClient { get; set; }
        public DateTime DateEvent { get; set; }
        public string TotalInLetters { get; set; }
        public bool IsCanceled { get; set; }
        public DateTime? CancelDate { get; set; }
        public string IdentificationNumber { get; set; }
        public string Name { get; set; }
        public string WatchBill { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TotalTaxes { get; set; }
        public DateTime LimitDate { get; set; }
    }

    public class ClientModel
    {
        public Guid Id { get; set; }
        public Guid IdIdentificationType { get; set; }
        public List<IdentificationTypeModel> TypeList { get; set; }
        public string IdentificationNumber { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal DiscountPercent { get; set; }
        public bool IsNew { get; set; }
        public DateTime DateEvent { get; set; }
        public int CreditDaysNumber { get; set; }
    }

    public class BillDetailModel {
        public Guid Id { get; set; }
        public Guid IdBill { get; set; }
        public Guid IdProduct { get; set; }
        public string Product { get; set; }
        public decimal UnitPrice { get; set; }       
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public bool FreeProduct { get; set; }
    }

    public class Tax {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal PercentageValue { get; set; }
    }

    public class BillTaxesModel
    {
        public Guid Id { get; set; }
        public Guid IdTax { get; set; }
        public Guid IdBill { get; set; }
        public string Description { get; set; }
        public decimal PercentageValue { get; set; }
        public decimal Total { get; set; }
    }
    public class IdentificationTypeModel {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool IsNewRegister { get; set; }
    }

    public class BillSaveModel {
        public ClientModel Client { get; set; }
        public BillModel Bill { get; set; }
        public List<BillDetailModel> BillDetail { get; set; }
        public List<BillTaxesModel> BillTaxes { get; set; }
    }

    public class BillPrintModel {
        public List<ClientModel> Client { get; set; }
        public List<BillModel> Bill { get; set; }
        public List<BillDetailModel> BillDetail { get; set; }
        public List<BillTaxesModel> BillTaxes { get; set; }
        public List<BillText> BillText { get; set; }
    }

    interface IFormBill
    {
        void NewBill();
    }
}