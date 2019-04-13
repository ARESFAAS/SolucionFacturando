using Facturando.Modelos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace Facturando.Modulos
{
    public partial class VisorFacturaMediaCartaVertical : BaseForm
    {
        BillPrintModel _bill = new BillPrintModel();
        private bool _readOnly = false;

        public VisorFacturaMediaCartaVertical()
        {
            InitializeComponent();            
        }

        public VisorFacturaMediaCartaVertical(BillSaveModel bill)
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

        public VisorFacturaMediaCartaVertical(BillSaveModel bill, bool readOnly)
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

        private void VisorFacturaMediaCartaVertical_Load(object sender, EventArgs e)
        {
            billPrintModelBindingSource.DataSource = _bill.Client;
            billPrintModelBindingSource1.DataSource = _bill.Bill;
            billPrintModelBindingSource2.DataSource = _bill.BillDetail;
            billPrintModelBindingSource3.DataSource = _bill.BillTaxes;
            billPrintModelBindingSource4.DataSource = _bill.BillText;

            this.reportViewer1.PrinterSettings.PrinterName = System.Configuration.ConfigurationSettings.AppSettings["NormalPrinterName"].ToString();
            this.reportViewer1.PrinterSettings.Copies = short.Parse(System.Configuration.ConfigurationSettings.AppSettings["NormalPrinterCopies"].ToString());
            System.Drawing.Printing.PaperSize paperSize = new System.Drawing.Printing.PaperSize();
            int marginTop = int.Parse(System.Configuration.ConfigurationSettings.AppSettings["NormalPrinterMargins"].ToString().Split(';')[0].Split(',')[1]);
            int marginLeft = int.Parse(System.Configuration.ConfigurationSettings.AppSettings["NormalPrinterMargins"].ToString().Split(';')[1].Split(',')[1]);
            int marginRight = int.Parse(System.Configuration.ConfigurationSettings.AppSettings["NormalPrinterMargins"].ToString().Split(';')[2].Split(',')[1]);
            int marginBottom = int.Parse(System.Configuration.ConfigurationSettings.AppSettings["NormalPrinterMargins"].ToString().Split(';')[3].Split(',')[1]);
                //System.Configuration.ConfigurationSettings.AppSettings["NormalPrinterMargins"].ToString().Split(';');
            foreach (System.Drawing.Printing.PaperSize item in this.reportViewer1.PrinterSettings.PaperSizes)
            {
                if (item.PaperName.ToLowerInvariant().
                    Equals(System.Configuration.ConfigurationSettings.AppSettings["NormalPaperName"].ToString().ToLowerInvariant()))
                {
                    paperSize = item;
                }
            }
            this.reportViewer1.SetPageSettings(new System.Drawing.Printing.PageSettings {
                PaperSize = paperSize,
                Landscape = false,
                Margins = new System.Drawing.Printing.Margins { Top = marginTop, Left = marginLeft, Right = marginRight, Bottom = marginBottom }
            });

            this.reportViewer1.RefreshReport();
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

        private void reportViewer1_PrintingBegin(object sender, Microsoft.Reporting.WinForms.ReportPrintEventArgs e)
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
                    reportViewer1.ShowPrintButton = true;
                }
                else
                {
                    reportViewer1.ShowPrintButton = false;
                }                
            }
        }
    }
}
