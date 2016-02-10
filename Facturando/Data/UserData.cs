using System;
using System.Linq;
using Facturando.Modelos;

namespace Facturando.Data
{
    public class UserData : IUser
    {
        public UserModel GetUser(UserModel user)
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {

                    var result = context.User
                        .Where(x => x.Login.Equals(user.Login) && x.Password.Equals(user.Password))
                        .Select(x => new UserModel
                        {
                             Id = x.Id,
                             Login = x.Login,
                             Password = x.Password,
                             DateEvent = x.DateEvent                             
                        }).FirstOrDefault();

                    if (result != null)
                    {
                        result.Roles = context.UserRol.Where(x => x.IdUser == result.Id).Select(x => new RolModel
                        {
                            Id = x.IdRol.Value,
                            RolName = x.Rol.Description
                        }).ToList();

                        if (result.Roles != null)
                        {
                            foreach (var rol in result.Roles)
                            {
                                rol.ActionList = context.RolAction.Where(x => x.IdRol == rol.Id).Select(x => x.Action.Description).ToList();
                                rol.ModuleList = context.RolModule.Where(x => x.IdRol == rol.Id).Select(x => x.Module.Description).ToList();
                            }
                        }
                    }                 
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
