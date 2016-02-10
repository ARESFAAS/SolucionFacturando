using Facturando.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturando.Modulos
{
    public partial class ClientesReporte : Form
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
