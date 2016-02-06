using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturando.Modelos;

namespace Facturando.Data
{
    public class ConfigurationData : IConfiguration
    {
        public List<ConfigurationModel> GetConfigurationList()
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    return context.ConfigurationSystem.Select(x => new ConfigurationModel
                    {
                        Id = x.Id,
                        FiscalYear = x.FiscalYear,
                        AuthorizedbillingEnd = x.AuthorizedBillingEnd,
                        AuthorizedBillingInit = x.AuthorizedBillingInit,
                        IdCountry = x.IdCountry.Value,
                        IdCurrency = x.IdCurrency.Value,
                        OperationsInitDate = x.OperationsInitDate
                    }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CurrencyTypeModel> GetCurrencyList()
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    return context.CurrencyType.Select(x => new CurrencyTypeModel
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

        public List<CountryModel> GetCountryList()
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    return context.Country.Select(x => new CountryModel
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

        public List<ConfigurationModel> SaveConfiguration(List<ConfigurationModel> configurationList)
        {
            try
            {
                var configurationUpdateList = configurationList.Where(x => !x.IsNewRegister).ToList();
                var configurationNewList = configurationList.Where(x => x.IsNewRegister).ToList();
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    foreach (var item in configurationUpdateList)
                    {
                        ConfigurationSystem configurationModelTemp = context.ConfigurationSystem
                            .Where(x => x.Id == item.Id)
                            .FirstOrDefault();
                        configurationModelTemp.IdCountry = item.IdCountry;
                        configurationModelTemp.IdCurrency = item.IdCurrency;
                        configurationModelTemp.OperationsInitDate = item.OperationsInitDate;
                        configurationModelTemp.FiscalYear = item.FiscalYear;
                        configurationModelTemp.AuthorizedBillingInit = item.AuthorizedBillingInit;
                        configurationModelTemp.AuthorizedBillingEnd = item.AuthorizedbillingEnd;
                    }
                    foreach (var item in configurationNewList)
                    {
                        context.ConfigurationSystem.Add(new ConfigurationSystem
                        {
                            Id = item.Id,
                            FiscalYear = item.FiscalYear,
                            OperationsInitDate = item.OperationsInitDate,
                            AuthorizedBillingEnd = item.AuthorizedbillingEnd,
                            AuthorizedBillingInit = item.AuthorizedBillingInit,
                            IdCountry = item.IdCountry,
                            IdCurrency = item.IdCurrency
                        });
                    }

                    context.SaveChanges();
                    return context.ConfigurationSystem.Select(x => new ConfigurationModel
                    {
                        Id = x.Id,
                        AuthorizedbillingEnd = x.AuthorizedBillingEnd,
                        AuthorizedBillingInit = x.AuthorizedBillingInit,
                        FiscalYear = x.FiscalYear,
                        IdCountry = x.IdCountry.Value,
                        IdCurrency = x.IdCurrency.Value,
                        OperationsInitDate = x.OperationsInitDate
                    }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TaxModel> GetTaxList()
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    return context.Tax.Select(x => new TaxModel
                    {
                        Id = x.Id,
                        Description = x.Description,
                        PercentageValue = x.PercentageValue
                    }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TaxModel> SaveTax(List<TaxModel> taxes)
        {
            try
            {
                var taxUpdateList = taxes.Where(x => !x.IsNewRegister).ToList();
                var taxNewList = taxes.Where(x => x.IsNewRegister).ToList();
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    foreach (var item in taxUpdateList)
                    {
                        Tax taxTemp = context.Tax
                            .Where(x => x.Id == item.Id)
                            .FirstOrDefault();
                        taxTemp.Description = item.Description;
                        taxTemp.PercentageValue = item.PercentageValue;
                    }
                    foreach (var item in taxNewList)
                    {
                        context.Tax.Add(new Tax
                        {
                            Id = item.Id,
                            Description = item.Description,
                            PercentageValue = item.PercentageValue
                        });
                    }

                    context.SaveChanges();
                    return context.Tax.Select(x => new TaxModel
                    {
                        Id = x.Id,
                        Description = x.Description,
                        PercentageValue = x.PercentageValue
                    }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<InventoryLocationModel> GetInventoryLocationList()
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

        public List<InventoryLocationModel> SaveInventoryLocation(List<InventoryLocationModel> locations)
        {
            try
            {
                var locationUpdateList = locations.Where(x => !x.IsNewRegister).ToList();
                var locationNewList = locations.Where(x => x.IsNewRegister).ToList();
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    foreach (var item in locationUpdateList)
                    {
                        InventoryLocation locationTemp = context.InventoryLocation
                            .Where(x => x.Id == item.Id)
                            .FirstOrDefault();
                        locationTemp.Description = item.Description;
                    }
                    foreach (var item in locationNewList)
                    {
                        context.InventoryLocation.Add(new InventoryLocation
                        {
                            Id = item.Id,
                            Description = item.Description
                        });
                    }

                    context.SaveChanges();
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

        public List<IdentificationTypeModel> GetIdentificationTypeList()
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

        public List<IdentificationTypeModel> SaveIdentificationType(List<IdentificationTypeModel> identificationTypes)
        {
            try
            {
                var identificationUpdateList = identificationTypes.Where(x => !x.IsNewRegister).ToList();
                var identificationNewList = identificationTypes.Where(x => x.IsNewRegister).ToList();
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    foreach (var item in identificationUpdateList)
                    {
                        IdentificacionType identificationTemp = context.IdentificacionType
                            .Where(x => x.Id == item.Id)
                            .FirstOrDefault();
                        identificationTemp.Description = item.Description;
                    }
                    foreach (var item in identificationNewList)
                    {
                        context.IdentificacionType.Add(new IdentificacionType
                        {
                            Id = item.Id,
                            Description = item.Description
                        });
                    }

                    context.SaveChanges();
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

        public List<UnitMeasureModel> GetUnitMeasureList()
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    return context.UnitMeasure.Select(x => new UnitMeasureModel
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

        public List<UnitMeasureModel> SaveUnitMeasure(List<UnitMeasureModel> unitMeasures)
        {
            try
            {
                var unitUpdateList = unitMeasures.Where(x => !x.IsNewRegister).ToList();
                var unitNewList = unitMeasures.Where(x => x.IsNewRegister).ToList();
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    foreach (var item in unitUpdateList)
                    {
                        UnitMeasure unitTemp = context.UnitMeasure
                            .Where(x => x.Id == item.Id)
                            .FirstOrDefault();
                        unitTemp.Description = item.Description;
                    }
                    foreach (var item in unitNewList)
                    {
                        context.UnitMeasure.Add(new UnitMeasure
                        {
                            Id = item.Id,
                            Description = item.Description
                        });
                    }

                    context.SaveChanges();
                    return context.UnitMeasure.Select(x => new UnitMeasureModel
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
