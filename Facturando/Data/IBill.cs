using Facturando.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturando.Data
{
    interface IBill
    {
        ClientModel GetClient(ClientModel client);
        List<IdentificationTypeModel> GetIdentificationType();
        List<BillTaxesModel> GetBillTaxes();
    }
}
