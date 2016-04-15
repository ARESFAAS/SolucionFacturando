using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturando.Modelos
{
    public class AppTextModel
    {
        public BillText BillData { get; set; }
        public RemissionText RemissionData { get; set; }
    }

    public class BillText
    {
        public string CompanyName { get; set; }
        public string ClientName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Authorize1 { get; set; }
        public string Authorize2 { get; set; }
        public string Authorize3 { get; set; }
        public string Authorize4 { get; set; }
        public string Footer1 { get; set; }
        public string Footer2 { get; set; }
        public string Prefix { get; set; }
        public string BillNote { get; set; }
        public string TaxPercentage { get; set; }
        public string MoneySymbol { get; set; }
        public string MoneyDescription { get; set; }
    }

    public class RemissionText
    {
        public string CompanyName { get; set; }
        public string ClientName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string MoneySymbol { get; set; }
        public string MoneyDescription { get; set; }
    }
}