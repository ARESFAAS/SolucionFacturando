using Facturando.Modelos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace Facturando.Modulos
{
    public partial class VisorRemisionMediaCartaVertical : BaseForm
    {
        RemissionPrintModel _remission = new RemissionPrintModel();
        private bool _readOnly = false;

        public VisorRemisionMediaCartaVertical()
        {
            InitializeComponent();
        }

        public VisorRemisionMediaCartaVertical(RemissionSaveModel remission)
        {
            InitializeComponent();

            if (ConfigurationManager.AppSettings["SaveType"].ToString().ToUpper().Equals("IMPRIMIRGUARDAR"))
            {
                btnNuevaRemision.Visible = false;
            }
            else
            {
                btnNuevaRemision.Visible = true;
            }

            _remission.Client = new List<ClientModel>();
            _remission.Client.Add(remission.Client);
            _remission.Remission = new List<RemissionModel>();
            _remission.Remission.Add(remission.Remission);
            _remission.RemissionDetail = remission.RemissionDetail;
            _remission.RemissionText = new List<RemissionText>();
            _remission.RemissionText.Add(AppText.Instance.AppTextData.RemissionData);
        }

        public VisorRemisionMediaCartaVertical(RemissionSaveModel remission, bool readOnly)
        {
            InitializeComponent();
            _remission.Client = new List<ClientModel>();
            _remission.Client.Add(remission.Client);
            _remission.Remission = new List<RemissionModel>();
            _remission.Remission.Add(remission.Remission);
            _remission.RemissionDetail = remission.RemissionDetail;
            _remission.RemissionText = new List<RemissionText>();
            _remission.RemissionText.Add(AppText.Instance.AppTextData.RemissionData);

            btnNuevaRemision.Enabled = false;
            btnNuevaRemision.Visible = false;
            _readOnly = true;
        }

        private void VisorRemisionMediaCartaVertical_Load(object sender, EventArgs e)
        {
            remissionPrintModelBindingSource1.DataSource = _remission.Client;
            remissionPrintModelBindingSource2.DataSource = _remission.Remission;
            remissionPrintModelBindingSource3.DataSource = _remission.RemissionDetail;
            remissionPrintModelBindingSource.DataSource = _remission.RemissionText;

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
            this.reportViewer1.SetPageSettings(new System.Drawing.Printing.PageSettings
            {
                PaperSize = paperSize,
                Landscape = false,
                Margins = new System.Drawing.Printing.Margins { Top = marginTop, Left = marginLeft, Right = marginRight, Bottom = marginBottom }
            });

            this.reportViewer1.RefreshReport();
        }

        private void btnNuevaRemision_Click(object sender, EventArgs e)
        {
            IFormRemission formInterface = Owner.Controls.Find("Remision", true).FirstOrDefault() as IFormRemission;

            if (formInterface != null)
            {
                formInterface.NewRemission();
            }
            Close();
        }

        private void reportViewer1_PrintingBegin(object sender, Microsoft.Reporting.WinForms.ReportPrintEventArgs e)
        {
            if (ConfigurationManager.AppSettings["SaveType"].ToString().ToUpper().Equals("IMPRIMIRGUARDAR"))
            {
                IFormRemission formInterface = Owner.Controls.Find("Remision", true).FirstOrDefault() as IFormRemission;

                if (formInterface != null)
                {
                    formInterface.NewRemission();
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
