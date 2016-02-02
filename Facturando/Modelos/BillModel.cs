using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturando.Modelos
{
    public class BillModel
    {
        public Guid Id { get; set; }
        public decimal Total { get; set; }
        public long BillNumber { get; set; }
        public Guid IdClient { get; set; }
    }

    public class ClientModel
    {
        public Guid Id { get; set; }
        public Guid IdIdentificationType { get; set; }
        public string IdentificationNumber { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal DiscountPercent { get; set; }
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
    }
}