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
