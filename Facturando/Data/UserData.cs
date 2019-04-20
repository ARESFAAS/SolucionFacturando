using System;
using System.Collections.Generic;
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

        public List<UserModel> GetUsers()
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {

                    var result = context.User
                        .Select(x => new UserModel
                        {
                            Id = x.Id,
                            Login = x.Login,
                            Password = x.Password,
                            DateEvent = x.DateEvent
                        }).ToList();
                    
                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<RolModel> GetRoles()
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {

                    var result = context.Rol
                        .Select(x => new RolModel
                        {
                            Id = x.Id,
                            RolName = x.Description
                        }).ToList();

                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ModuleModel> GetModules()
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {

                    var result = context.Module
                        .Select(x => new ModuleModel
                        {
                            Id = x.Id,
                            Description = x.Description
                        }).ToList();

                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public UserModel UpdatePassword(UserModel user)
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    var userTemp = context.User.Where(x => x.Id == user.Id).FirstOrDefault();
                    userTemp.Password = user.Password;
                    context.SaveChanges();                   
                }
                return user;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<RolModel2> GetRolesForUpdate()
        {
            try
            {
                using (FacturandoEntities context = new FacturandoEntities())
                {

                    var result = context.Rol
                        .Select(x => new RolModel2
                        {
                            Id = x.Id,
                            Description = x.Description                           
                        }).ToList();
                    
                    if (result != null)
                    {
                        foreach (var item in result)
                        {
                            item.ModuleList = context.RolModule.Where(y => y.IdRol == item.Id).Select(y => new ModuleModel
                            {
                                Id = y.Module.Id,
                                Description = y.Module.Description
                            }).ToList();
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

        public bool UpdateModulesForRol(Guid rolId, List<ModuleModel> modules)
        {
            try
            {
                bool result = false;
                using (FacturandoEntities context = new FacturandoEntities())
                {
                    List<RolModule> oldRoles = context.RolModule.Where(x => x.IdRol == rolId).ToList();
                    oldRoles.Clear();
                    foreach (var item in modules)
                    {
                        context.RolModule.Add(new RolModule { Id = Guid.NewGuid(), IdRol = rolId, IdModule = item.Id });
                    }
                    context.SaveChanges();
                    result = true;
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
