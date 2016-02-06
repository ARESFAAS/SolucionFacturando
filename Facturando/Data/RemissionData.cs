using Facturando.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturando.Data
{
    public class RemissionData : IRemission
    {
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
                        DateEvent = remission.Remission.DateEvent
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
    }
}