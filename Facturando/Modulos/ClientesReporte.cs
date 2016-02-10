using Facturando.Data;
using System;

namespace Facturando.Modulos
{
    public partial class ClientesReporte : BaseForm
    {
        public ClientesReporte()
        {
            InitializeComponent();
        }

        private void ClientesReporte_Load(object sender, EventArgs e)
        {
            IReport report = new ReportData();
            ClientReportModelBindingSource.DataSource = report.GetClients();
            this.rpvClientes.RefreshReport();
        }
    }
}
