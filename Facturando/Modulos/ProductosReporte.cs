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
    public partial class ProductosReporte : Form
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
