using System;
using System.Collections.Generic;
using System.Linq;
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
                            Phone = x.Phone,
                            DateEvent = x.DateEvent != null ? x.DateEvent.Value : DateTime.MinValue
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

        public long GetBillNumber()
        {
            try
            {
                long result = 0;
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    ConfigurationSystem lastConfiguration = context.ConfigurationSystem.OrderByDescending(x => x.FiscalYear).FirstOrDefault();
                    BillModel bill = context.Bill.OrderByDescending(x => x.BillNumber).Select(x => new BillModel
                    {
                        BillNumber = x.BillNumber
                    }).FirstOrDefault();

                    if (lastConfiguration != null)
                    {
                        if (bill != null)
                        {
                            result = bill.BillNumber + 1;
                            if (!(result >= lastConfiguration.AuthorizedBillingInit && result <= lastConfiguration.AuthorizedBillingEnd))
                            {
                                result = 0;
                            }
                        }
                        else
                        {
                            result = lastConfiguration.AuthorizedBillingInit;
                        };
                    }
                    else { result = 0; }
                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public BillSaveModel SaveBill(BillSaveModel bill)
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    if (bill.Client.IsNew)
                    {
                        // verificar nuevamente si el cliente realmente no existe

                        var clientValidate = context.Client
                            .Where(x => x.IdIdentificationType == bill.Client.IdIdentificationType
                            && x.IdentificationNumber.Equals(bill.Client.IdentificationNumber)).FirstOrDefault();

                        if (clientValidate == null)
                        {
                            context.Client.Add(new Client
                            {
                                Address = bill.Client.Adress,
                                DisccountPercent = bill.Client.DiscountPercent,
                                Email = bill.Client.Email,
                                Id = bill.Client.Id,
                                IdIdentificationType = bill.Client.IdIdentificationType,
                                IdentificationNumber = bill.Client.IdentificationNumber,
                                Name = bill.Client.Name,
                                Phone = bill.Client.Phone,
                                DateEvent = DateTime.Now
                            });
                        }
                        else
                        {
                            bill.Client.Id = clientValidate.Id;
                            bill.Bill.IdClient = clientValidate.Id;
                        }
                    }
                    context.Bill.Add(new Bill
                    {
                        Id = bill.Bill.Id,
                        BillNumber = bill.Bill.BillNumber,
                        IdClient = bill.Bill.IdClient,
                        Total = bill.Bill.Total,
                        DateEvent = bill.Bill.DateEvent
                    });
                    foreach (var item in bill.BillDetail)
                    {
                        context.BillDetail.Add(new BillDetail
                        {
                            Id = item.Id,
                            IdBill = item.IdBill,
                            IdProduct = item.IdProduct,
                            Quantity = item.Quantity,
                            UnitPrice = item.UnitPrice,
                            Total = item.Total
                        });
                    }
                    foreach (var item in bill.BillTaxes)
                    {
                        context.BillTaxes.Add(new BillTaxes
                        {
                            Id = item.Id,
                            IdBill = item.IdBill,
                            IdTax = item.IdTax,
                            Total = item.Total
                        });
                    }
                    context.SaveChanges();
                    return bill;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
