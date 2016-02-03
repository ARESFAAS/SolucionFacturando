using Facturando.Modelos;
using System.Collections.Generic;

namespace Facturando.Data
{
    interface IBill
    {
        ClientModel GetClient(ClientModel client);
        List<IdentificationTypeModel> GetIdentificationType();
        List<BillTaxesModel> GetBillTaxes();
        long GetBillNumber();
        BillSaveModel SaveBill(BillSaveModel bill); 
    }
}
