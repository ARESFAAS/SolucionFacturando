using Facturando.Modelos;
using Facturando.Modulos;
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

        public Principal(string systemCompany, UserModel user)
        {
            InitializeComponent();
            SystemCompany = systemCompany;
            User = user;

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblNombreEmpresa.Text = SystemCompany;
            lblRol.Text = User.Roles.FirstOrDefault().RolName;
            Modules = System.Configuration.ConfigurationSettings.AppSettings["Modules"].ToString()
                .Split('|')                
                .ToDictionary(x => x.Split('-')[0], x => x.Split('-')[1]);
            Actions = System.Configuration.ConfigurationSettings.AppSettings["Actions"].ToString()
                .Split('|')                
                .ToDictionary(x => x.Split('-')[0], x => x.Split('-')[1]);
        }

        private void picAgregaFactura_Click(object sender, EventArgs e)
        {
            
            foreach (var rol in User.Roles)
            {
                foreach (var module in rol.ModuleList)
                {
                    if (module.Equals(Modules["NF"])) {
                        AddFormInPanel(new Facturacion());
                        return;
                    }
                }
            }
            
        }

        private void pctNuevaRemision_Click(object sender, EventArgs e)
        {
            foreach (var rol in User.Roles)
            {
                foreach (var module in rol.ModuleList)
                {
                    if (module.Equals(Modules["NR"]))
                    {
                        AddFormInPanel(new Remision());
                        return;
                    }
                }
            }
        }

        private void picInventario_Click(object sender, EventArgs e)
        {
            foreach (var rol in User.Roles)
            {
                foreach (var module in rol.ModuleList)
                {
                    if (module.Equals(Modules["I"]))
                    {
                        AddFormInPanel(new Inventario());
                        return;
                    }
                }
            }            
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
            foreach(var rol in User.Roles)
            {
                foreach (var module in rol.ModuleList)
                {
                    if (module.Equals(Modules["C"]))
                    {
                        AddFormInPanel(new Configuracion());
                        return;
                    }
                }
            }            
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
        
        private void picConsultarFactura_Click(object sender, EventArgs e)
        {
            foreach (var rol in User.Roles)
            {
                foreach (var module in rol.ModuleList)
                {
                    if (module.Equals(Modules["CF"]))
                    {
                        AddFormInPanel(new ConsultarFactura());
                        return;
                    }
                }
            }            
        }

        private void picConsultarRemision_Click(object sender, EventArgs e)
        {
            foreach (var rol in User.Roles)
            {
                foreach (var module in rol.ModuleList)
                {
                    if (module.Equals(Modules["CR"]))
                    {
                        AddFormInPanel(new ConsultarRemision());
                        return;
                    }
                }
            }            
        }

        private void picClientes_Click(object sender, EventArgs e)
        {
            foreach (var rol in User.Roles)
            {
                foreach (var module in rol.ModuleList)
                {
                    if (module.Equals(Modules["CL"]))
                    {
                        AddFormInPanel(new Cliente());
                        return;
                    }
                }
            }            
        }

        private void picProductos_Click(object sender, EventArgs e)
        {
            foreach (var rol in User.Roles)
            {
                foreach (var module in rol.ModuleList)
                {
                    if (module.Equals(Modules["PR"]))
                    {
                        AddFormInPanel(new Producto());
                        return;
                    }
                }
            }
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