using System;
using System.Collections.Generic;
using System.Linq;
using Facturando.Modelos;

namespace Facturando.Data
{
    public class ProductData : IProduct
    {
        public List<ProductModel> GetProduct(ProductModel product)
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    return context.Product
                        .Where(x => x.Description.ToLower()
                        .Contains(product.Description.ToLower()))
                        .Select(x => new ProductModel
                        {
                            Id = x.Id,
                            Description = x.Description,
                            IdUnit = x.IdUnit.Value,
                            DescriptionUnit = x.UnitMeasure.Description
                        })
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ProductModel> SaveProduct(ProductModel product)
        {
            try
            {
                List<ProductModel> result = new List<ProductModel>();
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    var productTemp = context.Product.Where(x => x.Id == product.Id).FirstOrDefault();
                    if (productTemp == null)
                    {
                        context.Product.Add(new Product
                        {
                            Id = product.Id,
                            Description = product.Description,
                            IdUnit = product.IdUnit                            
                        });
                    }
                    else
                    {
                        productTemp.Description = product.Description;
                        productTemp.IdUnit = product.IdUnit;
                    }
                    context.SaveChanges();
                    result.Add(product);
                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}