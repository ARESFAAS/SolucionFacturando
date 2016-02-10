using Facturando.Modelos;

namespace Facturando.Data
{
    interface IUser
    {
        UserModel GetUser(UserModel user);
    }
}
