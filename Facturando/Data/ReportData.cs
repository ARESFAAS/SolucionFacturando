using System;
using System.Collections.Generic;
using System.Linq;
using Facturando.Modelos;

namespace Facturando.Data
{
    public class ReportData : IReport
    {
        public List<ClientViewModel> GetClients()
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    return context.Client                        
                        .Select(x => new ClientViewModel
                        {
                            IdentificationType = x.IdentificacionType.Description,
                            IdentificationNumber = x.IdentificationNumber,
                            Adress = x.Address,
                            DiscountPercent = x.DisccountPercent,
                            Email = x.Email,
                            Name = x.Name,
                            Phone = x.Phone,
                            DateEvent = x.DateEvent != null ? x.DateEvent.Value : DateTime.MinValue
                        }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DailyReportModel GetDaily(DateTime initDate, DateTime endDate)
        {
            DailyReportModel result = new DailyReportModel();
            
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    result.Daily = context.DailyGet(initDate, endDate).Select(x => new DailyModel {
                         Group = x.Description,
                         Quantity = x.Quantity.HasValue ? x.Quantity.Value : 0,
                         Total = x.Total.HasValue ? x.Total.Value : 0,
                         ClassT = x.ClassT
                         
                    }).ToList();
                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<InventoryModel> GetInventory()
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    return context.Inventory.Select(x => new InventoryModel
                    {
                        Id = x.Id,
                        IdProduct = x.IdProduct.Value,
                        LastSalePrice = x.LastSalePrice.Value,
                        Product = string.Concat(x.Product.Description, " ", x.Product.UnitMeasure.Description),
                        Quantity = x.Quantity
                    }).OrderBy(x => x.Quantity).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<InventoryModel> GetInventoryFromSP()
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    return context.GetInventoryFromSP().Select(x => new InventoryModel
                    {
                        Id = x.Id,
                        IdProduct = x.IdProduct.Value,
                        LastSalePrice = x.LastSalePrice.Value,
                        Product = x.Product,
                        Quantity = x.Quantity,
                        GroupT = x.GroupT
                    }).OrderBy(x => x.Quantity).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ProductModel> GetProducts()
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    return context.Product.Select(x => new ProductModel
                    {
                      Description = x.Description,
                      DescriptionUnit = x.UnitMeasure.Description                          
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
