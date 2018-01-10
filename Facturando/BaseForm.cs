using Facturando.Modelos;
using System.Collections.Generic;
using System.Configuration;
using System.Net.NetworkInformation;
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

        public string GetMacAddress()
        {
            string result = string.Empty;
            //result = NetworkInterface.GetAllNetworkInterfaces()[0].GetPhysicalAddress().ToString();
            result = ConfigurationManager.AppSettings["MacAddress"];
            return result;
        }
    }
}
