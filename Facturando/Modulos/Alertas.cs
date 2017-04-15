using Facturando.Data;
using System;

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
            InventoryReportModelBindingSource.DataSource = report.GetInventoryFromSP();
            this.rpvInventario.RefreshReport();
        }
    }
}
