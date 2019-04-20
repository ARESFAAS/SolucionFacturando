using System;
using System.Collections.Generic;

namespace Facturando.Modelos
{
    public class InventoryReportModel
    {
        public List<InventoryModel> Inventory { get; set; }    
    }

    public class InventoryReportParamsModel {
        public int InventoryAlert { get; set; }
    }

    public class ClientViewModel
    {
        public string IdentificationType { get; set; }
        public string IdentificationNumber { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal DiscountPercent { get; set; }
        public DateTime DateEvent { get; set; }
    }

    public class ClientReportModel
    {

        public List<ClientViewModel> Client { get; set; }
    }

    public class ProductReportModel {
        public List<ProductModel> Product { get; set; }
    }

    public class DailyModel {
        public string Group { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public string ClassT { get; set; }
    }

    public class DailyReportModel
    {
        public List<DailyModel> Daily { get; set; }
    }
}