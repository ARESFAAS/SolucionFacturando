using Facturando.Modelos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace Facturando.Modulos
{
    public partial class VisorFactura : BaseForm
    {
        BillPrintModel _bill = new BillPrintModel();
        private bool _readOnly = false;

        public VisorFactura()
        {
            InitializeComponent();
        }

        public VisorFactura(BillSaveModel bill)
        {
            InitializeComponent();

            if (ConfigurationManager.AppSettings["SaveType"].ToString().ToUpper().Equals("IMPRIMIRGUARDAR"))
            {
                btnNuevaFactura.Visible = false;
            }
            else
            {
                btnNuevaFactura.Visible = true;
            }

            _bill.Client = new List<ClientModel>();
            _bill.Client.Add(bill.Client);
            _bill.Bill = new List<BillModel>();
            _bill.Bill.Add(bill.Bill);
            _bill.BillDetail = bill.BillDetail;
            _bill.BillTaxes = bill.BillTaxes;
            _bill.BillText = new List<BillText>();
            _bill.BillText.Add(AppText.Instance.AppTextData.BillData);
        }

        public VisorFactura(BillSaveModel bill, bool readOnly)
        {
            InitializeComponent();
            _bill.Client = new List<ClientModel>();
            _bill.Client.Add(bill.Client);
            _bill.Bill = new List<BillModel>();
            _bill.Bill.Add(bill.Bill);
            _bill.BillDetail = bill.BillDetail;
            _bill.BillTaxes = bill.BillTaxes;
            _bill.BillText = new List<BillText>();
            _bill.BillText.Add(AppText.Instance.AppTextData.BillData);

            btnNuevaFactura.Enabled = false;
            btnNuevaFactura.Visible = false;
            _readOnly = true;
        }

        private void VisorFactura_Load(object sender, EventArgs e)
        {            
            billPrintModelBindingSource.DataSource = _bill.Client;
            billPrintModelBindingSource1.DataSource = _bill.Bill;
            billPrintModelBindingSource2.DataSource = _bill.BillDetail;
            billPrintModelBindingSource3.DataSource = _bill.BillTaxes;
            billPrintModelBindingSource4.DataSource = _bill.BillText;
            rvwFactura.RefreshReport();

        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            IFormBill formInterface = Owner.Controls.Find("Facturacion", true).FirstOrDefault() as IFormBill;

            if (formInterface != null)
            {
                formInterface.NewBill();
            }
            Close();
        }

        private void rvwFactura_PrintingBegin(object sender, Microsoft.Reporting.WinForms.ReportPrintEventArgs e)
        {
            if (ConfigurationManager.AppSettings["SaveType"].ToString().ToUpper().Equals("IMPRIMIRGUARDAR"))
            {
                IFormBill formInterface = Owner.Controls.Find("Facturacion", true).FirstOrDefault() as IFormBill;

                if (formInterface != null)
                {
                    formInterface.NewBill();
                }
                if (_readOnly)
                {
                    
                    rvwFactura.ShowPrintButton = true;
                }
                else
                {
                    rvwFactura.ShowPrintButton = false;
                }
            }
        }
    }
}
