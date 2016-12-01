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
        long GetBillNumber(string macAddress);
        BillSaveModel SaveBill(BillSaveModel bill);
        BillSaveModel SaveBill(BillSaveModel bill, string macAddress);
        List<BillModel> GetBillList(long billNumber, string identificationNumber, DateTime? initDate, DateTime? endDate);
        BillSaveModel GetBillData(BillModel bill);
        List<BillModel> CancelBill(List<BillModel> bill);
    }
}
