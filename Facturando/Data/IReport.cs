using Facturando.Modelos;
using System;
using System.Collections.Generic;

namespace Facturando.Data
{
    interface IReport
    {
        List<InventoryModel> GetInventory();
        List<ClientViewModel> GetClients();
        List<ProductModel> GetProducts();
        DailyReportModel GetDaily(DateTime initDate, DateTime endDate);
    }
}
