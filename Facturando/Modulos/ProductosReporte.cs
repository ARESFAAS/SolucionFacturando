using Facturando.Data;
using System;

namespace Facturando.Modulos
{
    public partial class ProductosReporte : BaseForm
    {
        public ProductosReporte()
        {
            InitializeComponent();
        }

        private void ProductosReporte_Load(object sender, EventArgs e)
        {
            IReport report = new ReportData();
            ProductReportModelBindingSource.DataSource = report.GetProducts();
            this.rpvProducto.RefreshReport();
        }
    }
}
