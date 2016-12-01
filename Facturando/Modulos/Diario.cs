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
    public partial class Diario : BaseForm
    {
        public Diario()
        {
            InitializeComponent();
        }

        private void Diario_Load(object sender, EventArgs e)
        {
            IReport report = new ReportData();
            DailyReportModelBindingSource.DataSource = report.GetDaily(dtpFechaConsulta.Value, dtpFechaConsulta.Value);
            rpvDiario.RefreshReport();
        }

        private void dtpFechaConsulta_ValueChanged(object sender, EventArgs e)
        {
            IReport report = new ReportData();
            DailyReportModelBindingSource.DataSource = report.GetDaily(dtpFechaConsulta.Value, dtpFechaConsulta.Value);
            rpvDiario.RefreshReport();
        }
    }
}
