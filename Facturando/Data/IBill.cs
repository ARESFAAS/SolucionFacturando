using Facturando.Modelos;
using System;
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
        List<BillModel> GetBillList(long billNumber, string identificationNumber, DateTime? initDate, DateTime? endDate);
        BillSaveModel GetBillData(BillModel bill);
        List<BillModel> CancelBill(List<BillModel> bill);
    }
}
