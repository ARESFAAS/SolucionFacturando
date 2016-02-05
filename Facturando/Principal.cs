using Facturando.Modelos;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Facturando
{
    public partial class Principal : BaseForm
    {        
        public Principal()
        {
            InitializeComponent();
        }

        public Principal(string systemCompany)
        {
            InitializeComponent();
            SystemCompany = systemCompany;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblNombreEmpresa.Text = SystemCompany;
        }

        private void picAgregaFactura_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Facturacion());
        }

        private void pctNuevaRemision_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Remision());
        }

        private void picInventario_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Inventario());
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IFormLogin formInterface = Owner as IFormLogin;
            this.Close();
            if (formInterface != null)
            {
                formInterface.Logout();
            }            
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alertasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void remisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void AddFormInPanel(object formHijo)
        {
            if (this.splitContainer1.Panel2.Controls.Count > 0)
                this.splitContainer1.Panel2.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(fh);
            this.splitContainer1.Panel2.Tag = fh;
            fh.Show();
        }
    }
}
