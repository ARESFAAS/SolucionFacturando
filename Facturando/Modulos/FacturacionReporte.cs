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
    public partial class FacturacionReporte : Form
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
