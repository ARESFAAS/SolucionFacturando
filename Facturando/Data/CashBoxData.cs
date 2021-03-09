using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturando.Modelos;

namespace Facturando.Data
{
    public class CashBoxData : ICashBox
    {
        public bool CashBoxExistsValidate(UserModel user)
        {
            bool result = false;
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    result = context.CashBox.Any(x => x.IdUser.Value.Equals(user.Id) && !x.IsClosed);
                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public CashBoxModel CloseCashBox(CashBoxModel cashBox)
        {
            CashBox cashBoxTemp = null;
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    cashBoxTemp = context.CashBox.Where(x => x.Id.Equals(cashBox.Id)).FirstOrDefault();
                    cashBoxTemp.IsClosed = true;
                    cashBoxTemp.CloseDate = DateTime.Now;
                    cashBoxTemp.CloseTotal = cashBox.CloseTotal;
                    context.SaveChanges();
                    return cashBox;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CashBoxDetailModel> GetCashBoxDetailList(CashBoxModel cashBox)
        {
            List<CashBoxDetailModel> result = new List<CashBoxDetailModel>();
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    result = context.CashBoxDetail.Where(x => x.IdCashBox.Equals(cashBox.Id)).Select(x => new CashBoxDetailModel
                    {
                        Id = x.Id,
                        IdCashBox = x.IdCashBox,
                        IdCashBoxType = x.IdCashBoxType.Value,
                        Sign = x.CashBoxType.Sign,
                        MovementDate = x.MovementDate,
                        Total = x.Total,
                        Comments = x.Comments,
                        CashBoxTypeDescription = x.CashBoxType.Description 
                    }).ToList();
                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CashBoxModel> GetCashBoxList()
        {
            List<CashBoxModel> result = new List<CashBoxModel>();
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    result = context.CashBox.Select(x => new CashBoxModel
                    {
                        Id = x.Id,
                        CashNumber = x.CashNumber,
                        Total = x.Total,
                        OpenDate = x.OpenDate,
                        CloseDate = x.CloseDate,
                        IdUser = x.IdUser.Value,
                        IsClosed = x.IsClosed,
                        Comments = x.Comments,
                        CloseTotal = x.CloseTotal.HasValue ? x.CloseTotal.Value : 0
                    })
                    .OrderByDescending(x => x.CashNumber)
                    .ToList();
                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CashBoxTypeModel> GetCashBoxType()
        {
            List<CashBoxTypeModel> result = new List<CashBoxTypeModel>();
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    result = context.CashBoxType.Select(x => new CashBoxTypeModel
                    {
                        Id = x.Id,
                        Description = x.Description,
                        Sign = x.Sign
                    }).ToList();
                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public CashBoxSaveModel SaveCashBox(CashBoxSaveModel cashBox)
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    var cashBoxTemp = context.CashBox.Where(x => x.Id == cashBox.CashBox.Id).FirstOrDefault();
                    if (cashBoxTemp == null)
                    {
                        context.CashBox.Add(new CashBox
                        {
                            Id = cashBox.CashBox.Id,
                            Total = cashBox.CashBox.Total,
                            OpenDate = DateTime.Now,
                            CloseDate = null,
                            IsClosed = false,
                            IdUser = cashBox.CashBox.IdUser,
                            Comments = cashBox.CashBox.Comments
                        });
                    }

                    foreach (var item in cashBox.CashBoxDetail)
                    {
                        context.CashBoxDetail.Add(new CashBoxDetail
                        {
                            Id = item.Id,
                            IdCashBox = item.IdCashBox,
                            IdCashBoxType = item.IdCashBoxType,
                            Total = item.Total,
                            MovementDate = DateTime.Now,
                            Comments = item.Comments
                        });
                    }
                    context.SaveChanges();
                    return cashBox;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
