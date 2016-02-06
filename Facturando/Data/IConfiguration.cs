using Facturando.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturando.Data
{
    interface IConfiguration
    {
        List<ConfigurationModel> GetConfigurationList();
        List<CurrencyTypeModel> GetCurrencyList();
        List<CountryModel> GetCountryList();
        List<ConfigurationModel> SaveConfiguration(List<ConfigurationModel> configurationList);
        List<TaxModel> GetTaxList();
        List<TaxModel> SaveTax(List<TaxModel> taxes);
        List<InventoryLocationModel> GetInventoryLocationList();
        List<InventoryLocationModel> SaveInventoryLocation(List<InventoryLocationModel> locations);
        List<IdentificationTypeModel> GetIdentificationTypeList();
        List<IdentificationTypeModel> SaveIdentificationType(List<IdentificationTypeModel> identificationTypes);
        List<UnitMeasureModel> GetUnitMeasureList();
        List<UnitMeasureModel> SaveUnitMeasure(List<UnitMeasureModel> unitMeasures);

    }
}
