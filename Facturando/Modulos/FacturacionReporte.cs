using Facturando.Data;
using System;

namespace Facturando.Modulos
{
    public partial class FacturacionReporte : BaseForm
    {
        public FacturacionReporte()
        {
            InitializeComponent();
        }

        private void FacturacionReporte_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            IBill bill = new BillData();
            billPrintModelBindingSource.DataSource = bill.GetBillList(0, string.Empty, dtpInicio.Value, dtpFin.Value);
            this.rpvFacturacionReporte.RefreshReport();
        }
    }
}
