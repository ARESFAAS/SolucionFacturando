using System;

namespace Facturando.Modelos
{
    public class InventoryModel {
        public Guid Id { get; set; }
        public Guid IdProduct { get; set; }
        public string Product { get; set; }
        public decimal LastSalePrice { get; set; }
        public int Quantity { get; set; }
    }
    public class InventoryDetailModel
    {
        public Guid Id { get; set; }
        public Guid IdInventory { get; set; }
        public Guid IdInventoryType { get; set; }
        public Guid IdProduct { get; set; }
        public string Product { get; set; }
        public string InventoryDescription { get; set; }
        public int Quantity { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime ConstructDate { get; set; }
        public DateTime DueDate { get; set; }
        public string BarCodeData { get; set; }
        public Guid IdInventoryClassification { get; set; }
        public string ClassificationDescription { get; set; }
        public Guid IdInventoryLocalization { get; set; }
        public string LocalizationDescription { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public string Sign { get; set; }
    }
    public class InventoryTypeModel {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Sign { get; set; }
    }
    public class InventoryClassificationModel {
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
    public class InventoryLocationModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
    public class ProductModel {
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
    public class InventorySaveModel
    {
        public InventoryModel Inventory { get; set; }
        public InventoryDetailModel InventoryDetail { get; set; }
    }
    interface IFormInventory
    {
        void UpdateInventoryInfo(InventorySaveModel inventory);
    }
}