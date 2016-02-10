using Facturando.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturando.Data
{
    interface IReport
    {
        List<InventoryModel> GetInventory();
        List<ClientViewModel> GetClients();
        List<ProductModel> GetProducts();
    }
}
