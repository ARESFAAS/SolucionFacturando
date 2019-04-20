using Facturando.Modelos;
using System;
using System.Collections.Generic;

namespace Facturando.Data
{
    interface IUser
    {
        UserModel GetUser(UserModel user);
        List<UserModel> GetUsers();
        List<RolModel> GetRoles();
        List<ModuleModel> GetModules();
        UserModel UpdatePassword(UserModel user);
        List<RolModel2> GetRolesForUpdate();
        bool UpdateModulesForRol(Guid rolId, List<ModuleModel> modules);
    }
}
