using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturando.Modelos
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime DateEvent { get; set; }
        public List<RolModel> Roles { get; set; }

    }

    public class RolModel {
        public Guid Id { get; set; }
        public string RolName { get; set; }
        public List<string> ModuleList { get; set; }
        public List<string> ActionList { get; set; }
    }
}
