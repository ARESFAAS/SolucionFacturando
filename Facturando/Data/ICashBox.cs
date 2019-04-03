using Facturando.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturando.Data
{
    interface ICashBox
    {
        CashBoxSaveModel SaveCashBox(CashBoxSaveModel cashBox);
        List<CashBoxTypeModel> GetCashBoxType();
        bool CashBoxExistsValidate(UserModel user);
        CashBoxModel CloseCashBox(CashBoxModel cashBox);
        List<CashBoxModel> GetCashBoxList();
        List<CashBoxDetailModel> GetCashBoxDetailList(CashBoxModel cashBox);
    }
}
