using Facturando.Data;
using System;

namespace Facturando.Modulos
{
    public partial class RemisionReporte : BaseForm
    {
        public RemisionReporte()
        {
            InitializeComponent();
        }

        private void RemisionReporte_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            IRemission remision = new RemissionData();
            RemissionPrintModelBindingSource.DataSource = remision.GetRemissionList(0, string.Empty, dtpInicio.Value, dtpFin.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
