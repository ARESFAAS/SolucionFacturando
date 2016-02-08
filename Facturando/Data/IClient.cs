using Facturando.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturando.Data
{
    interface IClient
    {
        List<ClientModel> GetClientList(ClientModel client);
        List<ClientModel> SaveClient(List<ClientModel> clientList);
        bool ClientExists(ClientModel client);
    }
}
