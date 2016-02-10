using Facturando.Modelos;
using System.Collections.Generic;

namespace Facturando.Data
{
    interface IProduct
    {
        List<ProductModel> GetProduct(ProductModel product);
        List<ProductModel> SaveProduct(ProductModel product);
    }
}
