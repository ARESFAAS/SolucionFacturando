using Facturando.Modelos;
using System;
using System.Collections.Generic;

namespace Facturando.Data
{
    interface IRemission
    {
        long GetRemissionNumber();
        long GetRemissionNumber(string macAddress);
        RemissionSaveModel SaveRemission(RemissionSaveModel remission);
        RemissionSaveModel SaveRemission(RemissionSaveModel remission, string macAddress);
        List<RemissionModel> GetRemissionList(long remissionNumber, string identificationNumber, DateTime? initDate, DateTime? endDate);
        RemissionSaveModel GetRemissionData(RemissionModel remission);
        List<RemissionModel> EditRemission(List<RemissionModel> remissionList);
        decimal GetRemisionTotal(Guid idUser, DateTime movementDate);
    }
}
