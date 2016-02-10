using Facturando.Modelos;
using System.Collections.Generic;

namespace Facturando.Data
{
    interface IClient
    {
        List<ClientModel> GetClientList(ClientModel client);
        List<ClientModel> SaveClient(List<ClientModel> clientList);
        bool ClientExists(ClientModel client);
    }
}
