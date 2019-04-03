using Facturando.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturando.Data
{
    public class RemissionData : IRemission
    {
        public List<RemissionModel> GetRemissionList(long remissionNumber, string identificationNumber, DateTime? initDate, DateTime? endDate)
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    List<RemissionModel> result = null;
                    if (remissionNumber > 0)
                    {
                        result = context.Remission
                            .Where(x => x.RemissionNumber == remissionNumber)
                            .Select(x => new RemissionModel
                            {
                                RemissionNumber = x.RemissionNumber,
                                DateEvent = x.DateEvent.Value,
                                Id = x.Id,
                                IdClient = x.IdClient.Value,
                                Total = x.Total,
                                IdentificationNumber = x.Client.IdentificationNumber,
                                Name = x.Client.Name,
                                IsPaid = x.IsPaid != null ? x.IsPaid.Value : false,
                                PaidDate = x.PaidDate,
                                Comments = x.Comments
                            }).ToList();
                    }

                    if (!string.IsNullOrEmpty(identificationNumber))
                    {
                        result = context.Remission
                            .Where(x => x.Client.IdentificationNumber.Equals(identificationNumber))
                            .Select(x => new RemissionModel
                            {
                                RemissionNumber = x.RemissionNumber,
                                DateEvent = x.DateEvent.Value,
                                Id = x.Id,
                                IdClient = x.IdClient.Value,
                                Total = x.Total,
                                IdentificationNumber = x.Client.IdentificationNumber,
                                Name = x.Client.Name,
                                IsPaid = x.IsPaid != null ? x.IsPaid.Value : false,
                                PaidDate = x.PaidDate,
                                Comments = x.Comments
                            }).ToList();
                    }

                    if (initDate != null && endDate != null)
                    {
                        result = context.Remission
                           .Where(x => x.DateEvent.Value >= initDate && x.DateEvent.Value <= endDate)
                           .Select(x => new RemissionModel
                           {
                               RemissionNumber = x.RemissionNumber,
                               DateEvent = x.DateEvent.Value,
                               Id = x.Id,
                               IdClient = x.IdClient.Value,
                               Total = x.Total,
                               IdentificationNumber = x.Client.IdentificationNumber,
                               Name = x.Client.Name,
                               IsPaid = x.IsPaid != null ? x.IsPaid.Value : false,
                               PaidDate = x.PaidDate,
                               Comments = x.Comments
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

        public long GetRemissionNumber()
        {
            try
            {
                long result = 0;
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    RemissionModel remission = context.Remission.OrderByDescending(x => x.RemissionNumber).Select(x => new RemissionModel
                    {
                        RemissionNumber = x.RemissionNumber
                    }).FirstOrDefault();

                    if (remission != null)
                    {
                        result = remission.RemissionNumber + 1;
                    }
                    else
                    {
                        result = 1;
                    };
                    return result;
                }
            }
                catch (Exception)
            {
                throw;
            }
        }

        public long GetRemissionNumber(string macAddress)
        {
            try
            {
                long result = 0;
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    RemissionModel remission = context.GetRemissionNumber(macAddress).Select(x => new RemissionModel
                    {
                        RemissionNumber = x.RemissionNumber
                    }).FirstOrDefault();

                    if (remission != null)
                    {
                        result = remission.RemissionNumber;
                    }

                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public RemissionSaveModel SaveRemission(RemissionSaveModel remission)
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    if (remission.Client.IsNew)
                    {
                        // verificar nuevamente si el cliente realmente no existe

                        var clientValidate = context.Client
                            .Where(x => x.IdIdentificationType == remission.Client.IdIdentificationType
                            && x.IdentificationNumber.Equals(remission.Client.IdentificationNumber)).FirstOrDefault();

                        if (clientValidate == null)
                        {
                            context.Client.Add(new Client
                            {
                                Address = remission.Client.Adress,
                                DisccountPercent = remission.Client.DiscountPercent,
                                Email = remission.Client.Email,
                                Id = remission.Client.Id,
                                IdIdentificationType = remission.Client.IdIdentificationType,
                                IdentificationNumber = remission.Client.IdentificationNumber,
                                Name = remission.Client.Name,
                                Phone = remission.Client.Phone,
                                DateEvent = DateTime.Now
                            });
                        }
                        else
                        {
                            remission.Client.Id = clientValidate.Id;
                            remission.Remission.IdClient = clientValidate.Id;
                        }
                    }

                    context.Remission.Add(new Remission
                    {
                        Id = remission.Remission.Id,
                        RemissionNumber = remission.Remission.RemissionNumber,
                        IdClient = remission.Remission.IdClient,
                        Total = remission.Remission.Total,
                        DateEvent = remission.Remission.DateEvent,
                        IsPaid = remission.Remission.IsPaid,
                        PaidDate = remission.Remission.PaidDate,
                        Comments = remission.Remission.Comments,
                        IdUser = remission.Remission.IdUser
                    });

                    foreach (var item in remission.RemissionDetail)
                    {
                        context.RemissionDetail.Add(new RemissionDetail
                        {
                            Id = item.Id,
                            IdRemission = item.IdRemission,
                            IdProduct = item.IdProduct,
                            Quantity = item.Quantity,
                            UnitPrice = item.UnitPrice,
                            Total = item.Total
                        });
                    }
                    context.SaveChanges();
                    return remission;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public RemissionSaveModel SaveRemission(RemissionSaveModel remission, string macAddress) {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    if (remission.Client.IsNew)
                    {
                        // verificar nuevamente si el cliente realmente no existe

                        var clientValidate = context.Client
                            .Where(x => x.IdIdentificationType == remission.Client.IdIdentificationType
                            && x.IdentificationNumber.Equals(remission.Client.IdentificationNumber)).FirstOrDefault();

                        if (clientValidate == null)
                        {
                            context.Client.Add(new Client
                            {
                                Address = remission.Client.Adress,
                                DisccountPercent = remission.Client.DiscountPercent,
                                Email = remission.Client.Email,
                                Id = remission.Client.Id,
                                IdIdentificationType = remission.Client.IdIdentificationType,
                                IdentificationNumber = remission.Client.IdentificationNumber,
                                Name = remission.Client.Name,
                                Phone = remission.Client.Phone,
                                DateEvent = DateTime.Now
                            });
                        }
                        else
                        {
                            remission.Client.Id = clientValidate.Id;
                            remission.Remission.IdClient = clientValidate.Id;
                        }
                    }

                    context.Remission.Add(new Remission
                    {
                        Id = remission.Remission.Id,
                        RemissionNumber = remission.Remission.RemissionNumber,
                        IdClient = remission.Remission.IdClient,
                        Total = remission.Remission.Total,
                        DateEvent = remission.Remission.DateEvent,
                        IsPaid = remission.Remission.IsPaid,
                        PaidDate = remission.Remission.PaidDate,
                        Comments = remission.Remission.Comments,
                        IdUser = remission.Remission.IdUser
                    });

                    foreach (var item in remission.RemissionDetail)
                    {
                        context.RemissionDetail.Add(new RemissionDetail
                        {
                            Id = item.Id,
                            IdRemission = item.IdRemission,
                            IdProduct = item.IdProduct,
                            Quantity = item.Quantity,
                            UnitPrice = item.UnitPrice,
                            Total = item.Total
                        });
                    }
                    RemissionTemp remissionTemp = context.RemissionTemp.Where(x => x.RemissionNumber.Equals(remission.Remission.RemissionNumber) && x.MacAddress.Equals(macAddress)).FirstOrDefault();
                    context.RemissionTemp.Remove(remissionTemp);                    
                    context.SaveChanges();
                    return remission;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public RemissionSaveModel GetRemissionData(RemissionModel remission)
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    RemissionSaveModel result = new RemissionSaveModel();
                    result.Remission = remission;
                    result.RemissionDetail = context.RemissionDetail
                        .Where(x => x.IdRemission == result.Remission.Id)
                        .Select(x => new RemissionDetailModel
                        {
                            Id = x.Id,
                            IdRemission = x.IdRemission.Value,
                            IdProduct = x.IdProduct.Value,
                            Product = string.Concat(x.Product.Description, " ", x.Product.UnitMeasure.Description),
                            Quantity = x.Quantity,
                            Total = x.Total,
                            UnitPrice = x.UnitPrice
                        }).ToList();

                    result.Client = context.Client
                        .Where(x => x.Id == result.Remission.IdClient)
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

                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<RemissionModel> EditRemission(List<RemissionModel> remissionList)
        {
            try
            {
                DateTime editDate = DateTime.Now;
                using (FacturandoEntities context = new FacturandoEntities())
                {                    
                    foreach (var item in remissionList)
                    {
                        var remissionTemp = context.Remission.Where(x => x.Id == item.Id).FirstOrDefault();
                        
                        if (item.IsPaid)
                        {
                            remissionTemp.IsPaid = item.IsPaid;
                            remissionTemp.PaidDate = editDate;
                            item.PaidDate = editDate;
                        }
                        else
                        {
                            remissionTemp.IsPaid = item.IsPaid;
                            remissionTemp.PaidDate = null;
                            item.PaidDate = null;
                        }
                    }
                    context.SaveChanges();
                    return remissionList;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public decimal GetRemisionTotal(Guid idUser, DateTime movementDate)
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    DateTime movementDateTemp = new DateTime(movementDate.Year, movementDate.Month, movementDate.Day);
                    decimal result = 0;
                    var resultList = context.Remission
                        .Where(x => x.DateEvent.Value >= movementDateTemp && x.DateEvent <= movementDateTemp)
                        .Where(x => x.IsPaid.Value)
                        .ToList();
                    result = resultList.Sum(x => x.Total);
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