using System;
using System.Collections.Generic;
using System.Linq;
using Facturando.Modelos;

namespace Facturando.Data
{
    public class ClientData : IClient
    {
        public bool ClientExists(ClientModel client)
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    return context.Client.Any(x => x.IdentificationNumber.Equals(client.IdentificationNumber));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ClientModel> GetClientList(ClientModel client)
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    return context.Client
                        .Where(x => x.IdIdentificationType == client.IdIdentificationType &&
                        x.IdentificationNumber.Equals(client.IdentificationNumber))
                        .Select(x => new ClientModel
                        {
                            Id = x.Id,
                            IdentificationNumber = x.IdentificationNumber,
                            IdIdentificationType = x.IdIdentificationType.Value,
                            Adress = x.Address,
                            DiscountPercent = x.DisccountPercent,
                            Email = x.Email,
                            Name = x.Name,
                            Phone = x.Phone,
                            DateEvent = x.DateEvent != null ? x.DateEvent.Value : DateTime.MinValue,
                            CreditDaysNumber = x.CreditDaysNumber.HasValue ? x.CreditDaysNumber.Value : 0
                        }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ClientModel> SaveClient(List<ClientModel> clientList)
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    foreach (var item in clientList)
                    {
                        var clientTemp = context.Client.Where(x => x.Id == item.Id).FirstOrDefault();
                        if (clientTemp == null)
                        {
                            context.Client.Add(new Client
                            {
                                Id = item.Id,
                                Address = item.Adress,
                                DateEvent = item.DateEvent,
                                DisccountPercent = item.DiscountPercent,
                                Email = item.Email,
                                IdIdentificationType = item.IdIdentificationType,                                
                                IdentificationNumber = item.IdentificationNumber,
                                Name = item.Name,
                                Phone = item.Phone,
                                CreditDaysNumber = item.CreditDaysNumber
                            });
                        }
                        else
                        {
                            clientTemp.Address = item.Adress;
                            clientTemp.DisccountPercent = item.DiscountPercent;
                            clientTemp.Email = item.Email;
                            clientTemp.Name = item.Name;
                            clientTemp.Phone = item.Phone;
                            clientTemp.CreditDaysNumber = item.CreditDaysNumber;
                        }
                    }
                    context.SaveChanges();
                    return clientList;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
