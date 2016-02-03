using System;
using System.Windows.Forms;

namespace Facturando
{
    public partial class Principal : Form
    {
        
        public Principal()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Inventario());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Facturacion());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Remision());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Configuracion());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Alertas());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Reportes());
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
