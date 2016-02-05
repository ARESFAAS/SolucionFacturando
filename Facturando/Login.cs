using Facturando.Modelos;
using System;

namespace Facturando
{
    public partial class Login : BaseForm, IFormLogin
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Principal principal = new Principal(SystemCompany);
            principal.Show(this);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SystemCompany = System.Configuration.ConfigurationSettings.AppSettings["SystemCompany"].ToString();
            lblNombreEmpresa.Text = SystemCompany;            
        }

        public void Logout()
        {
            Close();
        }
    }
}
