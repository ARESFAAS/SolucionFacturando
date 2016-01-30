using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturando.Modelos;

namespace Facturando.Data
{
    public class InventoryData : InventoryInterface
    {
        public List<InventoryModel> GetInventory(string barCode, string productName)
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    List<InventoryModel> result = new List<InventoryModel>();
                    if (!string.IsNullOrEmpty(barCode))
                    {
                        result = new List<InventoryModel>();

                        InventoryDetail inventoryDetailTemp = context.InventoryDetail
                            .Where(x => x.BarCodeData.ToLower().Equals(barCode.ToLower()))
                            .FirstOrDefault();
                        Inventory inventoryTemp = inventoryDetailTemp != null ? inventoryDetailTemp.Inventory : null;

                        if (inventoryTemp != null)
                        {
                            result.Add(new InventoryModel
                            {
                                Id = inventoryTemp.Id,
                                IdProduct = inventoryTemp.IdProduct.Value,
                                Product = string.Concat(inventoryTemp.Product.Description, " ", inventoryTemp.Product.UnitMeasure.Description),
                                Quantity = inventoryTemp.Quantity,
                            });
                        }
                    }
                    if (!string.IsNullOrEmpty(productName))
                    {
                        result = context.Inventory
                        .Where(x => x.Product.Description.ToLower().Contains(productName.ToLower()))
                        .Select(x => new InventoryModel
                        {
                            Id = x.Id,
                            IdProduct = x.IdProduct.Value,
                            Product = string.Concat(x.Product.Description, " ", x.Product.UnitMeasure.Description),
                            Quantity = x.Quantity
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

        public List<InventoryModel> GetInventory(Guid id)
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    return context.Inventory
                        .Where(x => x.Id == id)
                        .Select(x => new InventoryModel
                        {
                            Id = x.Id,
                            IdProduct = x.IdProduct.Value,
                            Product = string.Concat(x.Product.Description, " ", x.Product.UnitMeasure.Description),
                            Quantity = x.Quantity
                        }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<InventoryDetailModel> GetInventoryDetail(Guid productId)
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    return context.InventoryDetail
                        .Where(x => x.Inventory.IdProduct.Value == productId)
                        .Select(x => new InventoryDetailModel
                        {
                            Id = x.Id,
                            BarCodeData = x.BarCodeData,
                            ConstructDate = x.ConstructionDate.Value,
                            InventoryDescription = x.InventoryType.Description,
                            IdProduct = x.Inventory.Product.Id,
                            Product = string.Concat(x.Inventory.Product.Description, " ", x.Inventory.Product.UnitMeasure.Description),
                            DueDate = x.DueDate.Value,
                            EventDate = x.EventDate,
                            IdInventory = x.IdInventory.Value,
                            IdInventoryClassification = x.IdInventoryClassification.Value,
                            ClassificationDescription = x.InventoryClassification.Description,
                            IdInventoryLocalization = x.IdInventoryLocalization.Value,
                            LocalizationDescription = x.InventoryLocation.Description,
                            IdInventoryType = x.IdInventoryType.Value,
                            PurchasePrice = x.PurchasePrice.Value,
                            SalePrice = x.SalePrice.Value,
                            Quantity = x.Quantity,
                            Sign = x.InventoryType.Sign
                        }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<InventoryDetailModel> GetInventoryDetail(Guid id, bool byId)
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    return context.InventoryDetail
                        .Where(x => x.Id == id)
                        .Select(x => new InventoryDetailModel
                        {
                            Id = x.Id,
                            BarCodeData = x.BarCodeData,
                            ConstructDate = x.ConstructionDate.Value,
                            InventoryDescription = x.InventoryType.Description,
                            IdProduct = x.Inventory.Product.Id,
                            Product = string.Concat(x.Inventory.Product.Description, " ", x.Inventory.Product.UnitMeasure.Description),
                            DueDate = x.DueDate.Value,
                            EventDate = x.EventDate,
                            IdInventory = x.IdInventory.Value,
                            IdInventoryClassification = x.IdInventoryClassification.Value,
                            ClassificationDescription = x.InventoryClassification.Description,
                            IdInventoryLocalization = x.IdInventoryLocalization.Value,
                            LocalizationDescription = x.InventoryLocation.Description,
                            IdInventoryType = x.IdInventoryType.Value,
                            PurchasePrice = x.PurchasePrice.Value,
                            SalePrice = x.SalePrice.Value,
                            Quantity = x.Quantity,
                            Sign = x.InventoryType.Sign
                        }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }        

        public List<InventoryTypeModel> GetInventoryType(string sign)
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    return context.InventoryType.Where(x => x.Sign.Equals(sign)).Select(x => new InventoryTypeModel
                    {
                        Id = x.Id,
                        Description = x.Description,
                        Sign = x.Sign
                    }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<InventoryTypeModel> GetInventoryType()
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    return context.InventoryType.Select(x => new InventoryTypeModel
                    {
                        Id = x.Id,
                        Description = x.Description,
                        Sign = x.Sign
                    }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<InventoryLocationModel> GetyInventoryLocation()
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    return context.InventoryLocation.Select(x => new InventoryLocationModel
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

        public List<InventoryClassificationModel> GetInventoryClassification()
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    return context.InventoryClassification.Select(x => new InventoryClassificationModel
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

        public List<ProductModel> GetProduct()
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    return context.Product.Select(x => new ProductModel
                    {
                        Id = x.Id,
                        Description = string.Concat(x.Description, " ", x.UnitMeasure.Description)
                    }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public InventorySaveModel SaveInventory(InventorySaveModel inventory)
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    Inventory inventoryExists = context.Inventory
                        .Where(x => x.IdProduct == inventory.Inventory.IdProduct).ToList().FirstOrDefault();

                    int newQuantity = inventory.InventoryDetail.Quantity;

                    string newSign = context.InventoryType
                            .Where(x => x.Id == inventory.InventoryDetail.IdInventoryType)
                            .ToList().FirstOrDefault().Sign;
                    if (newSign.Equals("-"))
                    {
                        newQuantity = newQuantity * -1;
                    }

                    if (inventoryExists != null)
                    {
                        inventory.Inventory.Id = inventoryExists.Id;
                        inventoryExists.Quantity += newQuantity;
                        inventory.Inventory.IdProduct = inventoryExists.IdProduct.Value;
                        inventory.Inventory.Quantity = inventoryExists.Quantity;
                    }
                    else
                    {
                        inventory.Inventory.Id = Guid.NewGuid();
                        context.Inventory.Add(new Inventory
                        {
                            Id = inventory.Inventory.Id,
                            IdProduct = inventory.Inventory.IdProduct,
                            Quantity = newQuantity
                        });
                    }
                    inventory.InventoryDetail.Id = Guid.NewGuid();
                    context.InventoryDetail.Add(new InventoryDetail
                    {
                        Id = inventory.InventoryDetail.Id,
                        BarCodeData = inventory.InventoryDetail.BarCodeData,
                        ConstructionDate = inventory.InventoryDetail.ConstructDate,
                        DueDate = inventory.InventoryDetail.ConstructDate,
                        EventDate = inventory.InventoryDetail.EventDate,
                        IdInventory = inventory.Inventory.Id,
                        IdInventoryClassification = inventory.InventoryDetail.IdInventoryClassification,
                        IdInventoryLocalization = inventory.InventoryDetail.IdInventoryLocalization,
                        IdInventoryType = inventory.InventoryDetail.IdInventoryType,
                        PurchasePrice = inventory.InventoryDetail.PurchasePrice,
                        SalePrice = inventory.InventoryDetail.SalePrice,
                        Quantity = inventory.InventoryDetail.Quantity
                    });
                    context.SaveChanges();
                    return inventory;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public InventorySaveModel UpdateInventory(InventorySaveModel inventory)
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    bool isNewDetail = false;
                    InventoryDetail inventoryDetail = context.InventoryDetail
                        .Where(x => x.Id == inventory.InventoryDetail.Id)
                        .ToList()
                        .FirstOrDefault();

                    int inventoryQuantityTemp = 0;
                    int actualQuantity = inventoryDetail.Quantity;
                    int newQuantity = inventory.InventoryDetail.Quantity;

                    string actualSign = inventoryDetail.InventoryType.Sign;
                    string newSign = context.InventoryType
                        .Where(x => x.Id == inventory.InventoryDetail.IdInventoryType)
                        .ToList()
                        .FirstOrDefault().Sign;

                    Inventory inventoryTemp = context.Inventory
                           .Where(x => x.Id == inventory.Inventory.Id)
                           .ToList()
                           .FirstOrDefault();

                    if (actualSign.Equals("+") && newSign.Equals("+"))
                    {
                        inventoryQuantityTemp = newQuantity - actualQuantity;
                        inventoryTemp.Quantity += inventoryQuantityTemp;
                    }

                    if (actualSign.Equals("-") && newSign.Equals("-"))
                    {
                        inventoryQuantityTemp = newQuantity - actualQuantity;
                        inventoryTemp.Quantity -= inventoryQuantityTemp;
                    }

                    if (actualSign.Equals("-") && newSign.Equals("+"))
                    {
                        inventoryQuantityTemp = newQuantity;
                        inventoryTemp.Quantity += inventoryQuantityTemp;
                        isNewDetail = true;
                    }

                    if (actualSign.Equals("+") && newSign.Equals("-"))
                    {
                        inventoryQuantityTemp = newQuantity;
                        inventoryTemp.Quantity -= inventoryQuantityTemp;
                        isNewDetail = true;
                    }

                    if (isNewDetail)
                    {
                        SaveInventory(inventory);
                    }
                    else
                    {
                        inventoryDetail.BarCodeData = inventory.InventoryDetail.BarCodeData;
                        inventoryDetail.ConstructionDate = inventory.InventoryDetail.ConstructDate;
                        inventoryDetail.DueDate = inventory.InventoryDetail.ConstructDate;
                        inventoryDetail.EventDate = inventory.InventoryDetail.EventDate;
                        inventoryDetail.IdInventoryClassification = inventory.InventoryDetail.IdInventoryClassification;
                        inventoryDetail.IdInventoryLocalization = inventory.InventoryDetail.IdInventoryLocalization;
                        inventoryDetail.PurchasePrice = inventory.InventoryDetail.PurchasePrice;
                        inventoryDetail.SalePrice = inventory.InventoryDetail.SalePrice;
                        inventoryDetail.IdInventoryType = inventory.InventoryDetail.IdInventoryType;
                        inventoryDetail.Quantity = inventory.InventoryDetail.Quantity;
                    }
                    
                    context.SaveChanges();
                    return inventory;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}