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

        public List<InventoryDetailModel> GetInventoryDetail()
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    return context.InventoryDetail.Select(x => new InventoryDetailModel
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
                        Quantity = x.Quantity
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

                    if (inventoryExists != null)
                    {
                        inventory.Inventory.Id = inventoryExists.Id;
                        string newSign = context.InventoryType
                            .Where(x => x.Id == inventory.InventoryDetail.IdInventoryType)
                            .ToList().FirstOrDefault().Sign;
                        int newQuantity = inventory.InventoryDetail.Quantity;
                        if(newSign.Equals("-"))
                        {
                            newQuantity = newQuantity * -1;
                        }
                        inventoryExists.Quantity += newQuantity;
                        inventory.Inventory.IdProduct = inventoryExists.IdProduct.Value;
                        inventory.Inventory.Quantity = inventoryExists.Quantity;                      
                    }
                    else
                    {
                        inventory.Inventory.Id = Guid.NewGuid();
                        string newSign = context.InventoryType
                            .Where(x => x.Id == inventory.InventoryDetail.IdInventoryType)
                            .ToList().FirstOrDefault().Sign;
                        int newQuantity = inventory.InventoryDetail.Quantity;
                        if (newSign.Equals("-"))
                        {
                            newQuantity = newQuantity * -1;
                        }
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
                    InventoryDetail inventoryDetail = context.InventoryDetail
                        .Where(x => x.Id == inventory.InventoryDetail.Id)
                        .ToList()
                        .FirstOrDefault();
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

                    int inventoryQuantityTemp = 0;
                    int actualQuantity = inventoryDetail.Quantity;
                    int newQuantity = inventory.InventoryDetail.Quantity;
                    string actualSign = inventoryDetail.InventoryType.Sign;
                    string newSign = context.InventoryType
                        .Where(x => x.Id == inventory.InventoryDetail.IdInventoryType)
                        .ToList()
                        .FirstOrDefault().Sign;
                    if(actualSign.Equals("-"))
                    {
                        actualQuantity = actualQuantity * -1;
                    }
                    if(newSign.Equals("-"))
                    {
                        newQuantity = newQuantity * -1;
                    }
                    if (newQuantity != actualQuantity)
                    {
                        inventoryQuantityTemp = newQuantity + actualQuantity;
                    }

                    Inventory inventoryTemp = context.Inventory
                        .Where(x => x.Id == inventory.Inventory.Id)
                        .ToList()
                        .FirstOrDefault();

                    inventoryTemp.Quantity += inventoryQuantityTemp; 

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