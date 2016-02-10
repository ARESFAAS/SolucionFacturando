using Facturando.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Facturando
{
    public class BaseForm : Form
    {
        public string SystemCompany { get; set; }
        public UserModel User { get; set; }
        public Dictionary<string,string> Modules { get; set; }
        public Dictionary<string, string> Actions { get; set; }

        public BaseForm()
        {

        }
    }
}
