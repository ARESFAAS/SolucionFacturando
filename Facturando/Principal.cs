using Facturando.Modelos;
using Facturando.Modulos;
using System;
using System.Configuration;
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
            string saveProductKey = ConfigurationManager.AppSettings["ProductKey"];
            //string validProductKey = new KeyGenData.KeyGen(string.Empty).GenerateKeyEncrypt();
            string validProductKey = new KeyGenData.KeyGen(GetMacAddress()).GenerateKeyEncrypt();

            if (string.IsNullOrEmpty(saveProductKey))
            {
                string userProductKey = getProductKey();
                if (userProductKey.Equals(validProductKey))
                {
                    saveProductKey = userProductKey;
                }
            }

            if (saveProductKey.Equals(validProductKey))
            {
                lblNombreEmpresa.Text = SystemCompany;
                lblRol.Text = User.Roles.FirstOrDefault().RolName;
                lblFechaSistema.Text = DateTime.Now.ToShortDateString();
                Modules = System.Configuration.ConfigurationSettings.AppSettings["Modules"].ToString()
                    .Split('|')
                    .ToDictionary(x => x.Split('-')[0], x => x.Split('-')[1]);
                Actions = System.Configuration.ConfigurationSettings.AppSettings["Actions"].ToString()
                    .Split('|')
                    .ToDictionary(x => x.Split('-')[0], x => x.Split('-')[1]);
            }
            else
            {
                logOut();
            }
        }

        private void picAgregaFactura_Click(object sender, EventArgs e)
        {

            foreach (var rol in User.Roles)
            {
                foreach (var module in rol.ModuleList)
                {
                    if (module.Equals(Modules["NF"]))
                    {
                        AddFormInPanel(new Facturacion(base.User));
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
                        AddFormInPanel(new Remision(base.User));
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
            logOut();
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var rol in User.Roles)
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
            foreach (var rol in User.Roles)
            {
                foreach (var module in rol.ModuleList)
                {
                    if (module.Equals(Modules["R"]))
                    {
                        AddFormInPanel(new Alertas());
                        return;
                    }
                }
            }            
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var rol in User.Roles)
            {
                foreach (var module in rol.ModuleList)
                {
                    if (module.Equals(Modules["R"]))
                    {
                        AddFormInPanel(new FacturacionReporte());
                        return;
                    }
                }
            }            
        }

        private void remisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var rol in User.Roles)
            {
                foreach (var module in rol.ModuleList)
                {
                    if (module.Equals(Modules["R"]))
                    {
                        AddFormInPanel(new RemisionReporte());
                        return;
                    }
                }
            }            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var rol in User.Roles)
            {
                foreach (var module in rol.ModuleList)
                {
                    if (module.Equals(Modules["R"]))
                    {
                        AddFormInPanel(new ClientesReporte());
                        return;
                    }
                }
            }            
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

        private void picCaja_Click(object sender, EventArgs e)
        {
            foreach (var rol in User.Roles)
            {
                foreach (var module in rol.ModuleList)
                {
                    if (module.Equals(Modules["CJ"]))
                    {
                        AddFormInPanel(new Caja(base.User));
                        return;
                    }
                }
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var rol in User.Roles)
            {
                foreach (var module in rol.ModuleList)
                {
                    if (module.Equals(Modules["R"]))
                    {
                        AddFormInPanel(new ProductosReporte());
                        return;
                    }
                }
            }
        }

        private void diarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var rol in User.Roles)
            {
                foreach (var module in rol.ModuleList)
                {
                    if (module.Equals(Modules["R"]))
                    {
                        AddFormInPanel(new Diario());
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

        private string getProductKey()
        {
            KeyValidate keyDialog = new KeyValidate();
            string result;

            if (keyDialog.ShowDialog(this) == DialogResult.OK)
            {
                result = keyDialog.TextBox1;
            }
            else
            {
                result = string.Empty;
            }
            keyDialog.Dispose();
            return result;
        }

        private void logOut() {
            IFormLogin formInterface = Owner as IFormLogin;
            this.Close();
            if (formInterface != null)
            {
                formInterface.Logout();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var rol in User.Roles)
            {
                foreach (var module in rol.ModuleList)
                {
                    if (module.Equals(Modules["U"]))
                    {
                        AddFormInPanel(new Usuarios());
                        return;
                    }
                }
            }
        }
    }
}