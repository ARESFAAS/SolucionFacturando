using Facturando.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturando.Data
{
    interface InventoryInterface
    {
        List<InventoryDetailModel> GetInventoryDetail(Guid producId);
        List<InventoryDetailModel> GetInventoryDetail(Guid id, bool byId);
        List<InventoryModel> GetInventory(string barCode, string productName);
        List<InventoryModel> GetInventory(Guid id);
        List<InventoryTypeModel> GetInventoryType(string sign);
        List<InventoryTypeModel> GetInventoryType();
        List<InventoryClassificationModel> GetInventoryClassification();
        List<InventoryLocationModel> GetyInventoryLocation();
        List<ProductModel> GetProduct();
        InventorySaveModel SaveInventory(InventorySaveModel inventory);
        InventorySaveModel UpdateInventory(InventorySaveModel inventory);
    }
}
