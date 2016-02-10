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
    public partial class RemisionReporte : Form
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
