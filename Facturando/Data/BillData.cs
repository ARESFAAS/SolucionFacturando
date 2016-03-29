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
                    ConfigurationSystem lastConfiguration = context.ConfigurationSystem
                        .OrderByDescending(x => x.OperationsInitDate)
                        .FirstOrDefault();
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
                                result = lastConfiguration.AuthorizedBillingInit;
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

        public List<BillModel> GetBillList(long billNumber, string identificationNumber, DateTime? initDate, DateTime? endDate)
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    List<BillModel> result = null;
                    if (billNumber > 0)
                    {
                        result = context.Bill
                            .Where(x => x.BillNumber == billNumber)
                            .Select(x => new BillModel
                            {
                                BillNumber = x.BillNumber,
                                CancelDate = x.CancelDate,
                                DateEvent = x.DateEvent.Value,
                                Id = x.Id,
                                IdClient = x.IdClient.Value,
                                IsCanceled = x.IsCanceled != null ? x.IsCanceled.Value : false,
                                Total = x.Total,
                                IdentificationNumber = x.Client.IdentificationNumber,
                                Name = x.Client.Name
                            }).ToList();
                    }

                    if (!string.IsNullOrEmpty(identificationNumber))
                    {
                        result = context.Bill
                            .Where(x => x.Client.IdentificationNumber.Equals(identificationNumber))
                            .Select(x => new BillModel
                            {
                                BillNumber = x.BillNumber,
                                CancelDate = x.CancelDate,
                                DateEvent = x.DateEvent.Value,
                                Id = x.Id,
                                IdClient = x.IdClient.Value,
                                IsCanceled = x.IsCanceled != null ? x.IsCanceled.Value : false,
                                Total = x.Total,
                                IdentificationNumber = x.Client.IdentificationNumber,
                                Name = x.Client.Name
                            }).ToList();
                    }

                    if (initDate != null && endDate != null)
                    {
                        result = context.Bill
                           .Where(x => x.DateEvent.Value >= initDate && x.DateEvent.Value <= endDate)
                           .Select(x => new BillModel
                           {
                               BillNumber = x.BillNumber,
                               CancelDate = x.CancelDate,
                               DateEvent = x.DateEvent.Value,
                               Id = x.Id,
                               IdClient = x.IdClient.Value,
                               IsCanceled = x.IsCanceled != null ? x.IsCanceled.Value : false,
                               Total = x.Total,
                               IdentificationNumber = x.Client.IdentificationNumber,
                               Name = x.Client.Name
                           }).ToList();
                    }
                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public BillSaveModel GetBillData(BillModel bill)
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    BillSaveModel result = new BillSaveModel();
                    result.Bill = bill;
                    result.BillDetail = context.BillDetail
                        .Where(x => x.IdBill == result.Bill.Id)
                        .Select(x => new BillDetailModel
                        {
                            Id = x.Id,
                            IdBill = x.IdBill,
                            IdProduct = x.IdProduct.Value,
                            Product = string.Concat(x.Product.Description, " ", x.Product.UnitMeasure.Description),
                            Quantity = x.Quantity,
                            Total = x.Total,
                            UnitPrice = x.UnitPrice != null ? x.UnitPrice.Value : 0
                        }).ToList();

                    result.Client = context.Client
                        .Where(x => x.Id == result.Bill.IdClient)
                        .Select(x => new ClientModel
                        {
                            Id = x.Id,
                            Adress = x.Address,
                            DateEvent = x.DateEvent != null ? x.DateEvent.Value : DateTime.MinValue,
                            DiscountPercent = x.DisccountPercent,
                            Email = x.Email,
                            IdentificationNumber = x.IdentificationNumber,
                            IdIdentificationType = x.IdIdentificationType.Value,
                            Name = x.Name,
                            Phone = x.Phone
                        }).FirstOrDefault();

                    result.BillTaxes = context.BillTaxes
                        .Where(x => x.IdBill == result.Bill.Id)
                        .Select(x => new BillTaxesModel
                        {
                            Id = x.Id,
                            Description = x.Tax.Description,
                            IdBill = x.IdBill.Value,
                            IdTax = x.IdTax.Value,
                            PercentageValue = x.Tax.PercentageValue,
                            Total = x.Total
                        }).ToList();

                    return result;

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<BillModel> CancelBill(List<BillModel> billList)
        {
            try
            {
                DateTime cancelDate = DateTime.Now;
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    InventoryInterface inventoryData = new InventoryData();
                    var inventoryTypeList = inventoryData.GetInventoryType();
                    InventoryTypeModel inventoryTypeIn = inventoryTypeList.Where(x => x.Description.Equals("Devolución Cliente")).FirstOrDefault();
                    InventoryTypeModel inventoryTypeOut = inventoryTypeList.Where(x => x.Description.Equals("Venta")).FirstOrDefault();

                    foreach (var item in billList)
                    {
                        var billTemp = context.Bill.Where(x => x.Id == item.Id).FirstOrDefault();

                        // Simon Ariza - 10-03-2016 - inventory affect
                        if (billTemp.IsCanceled != item.IsCanceled)
                        {   
                            var billDetailTemp = context.BillDetail.Where(x => x.IdBill == item.Id).ToList();
                            foreach (var billProduct in billDetailTemp)
                            {
                                InventoryModel inventoryTemp = inventoryData.GetInventoryByProductId(billProduct.IdProduct.Value);
                                InventoryDetailModel inventoryDetailTemp = inventoryData.GetLastInventoryDetailInByProductId(billProduct.IdProduct.Value);
                                InventorySaveModel inventorySaveTemp = new InventorySaveModel {  Inventory = inventoryTemp, InventoryDetail = inventoryDetailTemp };
                                if (item.IsCanceled) // inventory in
                                {
                                    inventorySaveTemp.InventoryDetail.IdInventoryType = inventoryTypeIn.Id;                                    
                                }
                                else // inventory out
                                {
                                    inventorySaveTemp.InventoryDetail.IdInventoryType = inventoryTypeOut.Id;                                   
                                }
                                inventorySaveTemp.InventoryDetail.Quantity = billProduct.Quantity;
                                inventoryData.SaveInventory(inventorySaveTemp);
                            } 
                        }
                        //fin cambio

                        if (item.IsCanceled)
                        {
                            billTemp.IsCanceled = item.IsCanceled;
                            billTemp.CancelDate = cancelDate;
                            item.CancelDate = cancelDate;                            
                        }
                        else
                        {
                            billTemp.IsCanceled = item.IsCanceled;
                            billTemp.CancelDate = null;
                            item.CancelDate = null;
                        }
                    }
                    context.SaveChanges();
                    return billList;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
