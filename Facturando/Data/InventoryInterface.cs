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
        List<InventoryDetailModel> GetInventoryDetail();
        List<InventoryModel> GetInventory();
        List<InventoryTypeModel> GetInventoryType();
        List<InventoryClassificationModel> GetInventoryClassification();
        List<InventoryLocationModel> GetyInventoryLocation();
        List<ProductModel> GetProduct();

        InventorySaveModel SaveInventory(InventorySaveModel inventory);
        InventorySaveModel UpdateInventory(InventorySaveModel inventory);

    }
}
