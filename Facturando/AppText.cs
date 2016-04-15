using Facturando.Modelos;
using System.Xml;

namespace Facturando
{
    public class AppText
    {
        private static AppText _instance;
        public AppTextModel AppTextData { get; set; }

        private AppText()
        {
            GetData();
        }
        public static AppText Instance {
            get {
                if (_instance == null)
                {
                    _instance = new AppText();
                }
                return _instance;
            }
        }

        private void GetData() {
            XmlDocument xmlData = new XmlDocument();
            xmlData.Load("AppText.xml");
            AppTextData = new AppTextModel();
            AppTextData.BillData = new BillText();
            AppTextData.RemissionData = new RemissionText();

            #region bill

            XmlNode xmlNodeTemp = xmlData.SelectSingleNode("/AppText/BillData/CompanyName");
            AppTextData.BillData.CompanyName = xmlNodeTemp.InnerText;

            xmlNodeTemp = xmlData.SelectSingleNode("/AppText/BillData/ClientName");
            AppTextData.BillData.ClientName = xmlNodeTemp.InnerText;

            xmlNodeTemp = xmlData.SelectSingleNode("/AppText/BillData/Address1");
            AppTextData.BillData.Address1 = xmlNodeTemp.InnerText;

            xmlNodeTemp = xmlData.SelectSingleNode("/AppText/BillData/Address2");
            AppTextData.BillData.Address2 = xmlNodeTemp.InnerText;

            xmlNodeTemp = xmlData.SelectSingleNode("/AppText/BillData/Address3");
            AppTextData.BillData.Address3 = xmlNodeTemp.InnerText;

            xmlNodeTemp = xmlData.SelectSingleNode("/AppText/BillData/Authorize1");
            AppTextData.BillData.Authorize1 = xmlNodeTemp.InnerText;

            xmlNodeTemp = xmlData.SelectSingleNode("/AppText/BillData/Authorize2");
            AppTextData.BillData.Authorize2 = xmlNodeTemp.InnerText;

            xmlNodeTemp = xmlData.SelectSingleNode("/AppText/BillData/Authorize3");
            AppTextData.BillData.Authorize3 = xmlNodeTemp.InnerText;

            xmlNodeTemp = xmlData.SelectSingleNode("/AppText/BillData/Authorize4");
            AppTextData.BillData.Authorize4 = xmlNodeTemp.InnerText;

            xmlNodeTemp = xmlData.SelectSingleNode("/AppText/BillData/Footer1");
            AppTextData.BillData.Footer1 = xmlNodeTemp.InnerText;

            xmlNodeTemp = xmlData.SelectSingleNode("/AppText/BillData/Footer2");
            AppTextData.BillData.Footer2 = xmlNodeTemp.InnerText;

            xmlNodeTemp = xmlData.SelectSingleNode("/AppText/BillData/Prefix");
            AppTextData.BillData.Prefix = xmlNodeTemp.InnerText;

            xmlNodeTemp = xmlData.SelectSingleNode("/AppText/BillData/BillNote");
            AppTextData.BillData.BillNote = xmlNodeTemp.InnerText;

            xmlNodeTemp = xmlData.SelectSingleNode("/AppText/BillData/TaxPercentage");
            AppTextData.BillData.TaxPercentage = xmlNodeTemp.InnerText;

            xmlNodeTemp = xmlData.SelectSingleNode("/AppText/BillData/MoneySymbol");
            AppTextData.BillData.MoneySymbol = xmlNodeTemp.InnerText;

            xmlNodeTemp = xmlData.SelectSingleNode("/AppText/BillData/MoneyDescription");
            AppTextData.BillData.MoneyDescription = xmlNodeTemp.InnerText;

            #endregion

            #region remission

            xmlNodeTemp = xmlData.SelectSingleNode("/AppText/RemissionData/CompanyName");
            AppTextData.RemissionData.CompanyName = xmlNodeTemp.InnerText;

            xmlNodeTemp = xmlData.SelectSingleNode("/AppText/RemissionData/ClientName");
            AppTextData.RemissionData.ClientName = xmlNodeTemp.InnerText;

            xmlNodeTemp = xmlData.SelectSingleNode("/AppText/RemissionData/Address1");
            AppTextData.RemissionData.Address1 = xmlNodeTemp.InnerText;

            xmlNodeTemp = xmlData.SelectSingleNode("/AppText/RemissionData/Address2");
            AppTextData.RemissionData.Address2 = xmlNodeTemp.InnerText;

            xmlNodeTemp = xmlData.SelectSingleNode("/AppText/RemissionData/MoneySymbol");
            AppTextData.RemissionData.MoneySymbol = xmlNodeTemp.InnerText;

            xmlNodeTemp = xmlData.SelectSingleNode("/AppText/RemissionData/MoneyDescription");
            AppTextData.RemissionData.MoneyDescription = xmlNodeTemp.InnerText;

            #endregion
        }
    }

}
