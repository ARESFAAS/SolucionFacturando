using Facturando.Modelos;
using System;
using System.Collections.Generic;

namespace Facturando.Data
{
    interface InventoryInterface
    {
        List<InventoryDetailModel> GetInventoryDetail(Guid producId);
        List<InventoryDetailModel> GetInventoryDetail(Guid productId, DateTime initDate, DateTime endDate, string type);
        List<InventoryDetailModel> GetInventoryDetail(Guid id, bool byId);
        InventoryDetailModel GetLastInventoryDetailInByProductId(Guid productId);
        List<InventoryModel> GetInventory(string barCode, string productName);
        List<InventoryModel> GetInventory(Guid id);
        InventoryModel GetInventoryByProductId(Guid id);
        List<InventoryTypeModel> GetInventoryType(string sign);
        List<InventoryTypeModel> GetInventoryType();
        List<InventoryClassificationModel> GetInventoryClassification();
        List<InventoryLocationModel> GetyInventoryLocation();
        List<ProductModel> GetProduct();
        InventorySaveModel SaveInventory(InventorySaveModel inventory);
        InventorySaveModel UpdateInventory(InventorySaveModel inventory);
    }
}
