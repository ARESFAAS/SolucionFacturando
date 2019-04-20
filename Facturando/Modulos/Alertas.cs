using Facturando.Data;
using Facturando.Modelos;
using System;
using System.Collections.Generic;

namespace Facturando
{
    public partial class Alertas : BaseForm
    {
        public Alertas()
        {
            InitializeComponent();
        }

        private void Alertas_Load(object sender, EventArgs e)
        {
            IReport report = new ReportData();
            InventoryReportModelBindingSource.DataSource = report.GetInventoryFromSP(null);
            List<InventoryReportParamsModel> reportParams = new List<InventoryReportParamsModel>();
            reportParams.Add(new InventoryReportParamsModel
            {
                InventoryAlert = int.Parse(System.Configuration.ConfigurationManager.AppSettings["InventoryAlert"].ToString())
            });
            InventoryReportParamBS.DataSource = reportParams;
            this.rpvInventario.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string productDescription = string.IsNullOrEmpty(txtProductoBusqueda.Text) ? null : txtProductoBusqueda.Text;
            IReport report = new ReportData();
            InventoryReportModelBindingSource.DataSource = report.GetInventoryFromSP(productDescription);
            List<InventoryReportParamsModel> reportParams = new List<InventoryReportParamsModel>();
            reportParams.Add(new InventoryReportParamsModel
            {
                InventoryAlert = int.Parse(System.Configuration.ConfigurationManager.AppSettings["InventoryAlert"].ToString())
            });
            InventoryReportParamBS.DataSource = reportParams;
            this.rpvInventario.RefreshReport();
        }
    }
}
