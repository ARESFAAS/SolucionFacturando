using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturando.Modelos;

namespace Facturando.Data
{
    public class BillData : IBill
    {
        public List<BillTaxesModel> GetBillTaxes()
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    return context.Tax.Select(x => new BillTaxesModel
                    {
                        Id = Guid.NewGuid(),
                        IdTax = x.Id,
                        Description = x.Description,
                        PercentageValue = x.PercentageValue,
                        Total = 0

                    }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ClientModel GetClient(ClientModel client)
        {
            try
            {
                ClientModel result = new ClientModel();
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    result = context.Client
                        .Where(x => x.IdIdentificationType == client.IdIdentificationType &&
                        x.IdentificationNumber.Equals(client.IdentificationNumber))
                        .Select(x => new ClientModel
                        {
                            Id = x.Id,
                            IdentificationNumber = x.IdentificationNumber,
                            IdIdentificationType = x.IdIdentificationType.Value,
                            Adress = x.Address,
                            DiscountPercent = x.DisccountPercent,
                            Email = x.Email,
                            Name = x.Name,
                            Phone = x.Phone
                        }).ToList().FirstOrDefault();

                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<IdentificationTypeModel> GetIdentificationType()
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    return context.IdentificacionType.Select(x => new IdentificationTypeModel
                    {
                        Id = x.Id,
                        Description = x.Description
                    }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
