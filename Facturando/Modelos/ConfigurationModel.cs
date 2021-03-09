using System;
using System.Collections.Generic;

namespace Facturando.Modelos
{
    public class ConfigurationModel
    {
        public Guid Id { get; set; }
        public int FiscalYear { get; set; }
        public DateTime OperationsInitDate { get; set; }
        public long AuthorizedBillingInit { get; set; }
        public long AuthorizedbillingEnd { get; set; }
        public Guid IdCountry { get; set; }
        public Guid IdCurrency { get; set; }
        public List<CurrencyTypeModel> CurrencyList { get; set; }
        public List<CountryModel> CountryList { get; set; }
        public bool IsNewRegister { get; set; }
    }

    public class CurrencyTypeModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }

    }

    public class CountryModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
    }

    public class TaxModel {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal PercentageValue { get; set; }
        public bool IsNewRegister { get; set; }

    }

    public class UnitMeasureModel {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool IsNewRegister { get; set; } 
    }       
}
