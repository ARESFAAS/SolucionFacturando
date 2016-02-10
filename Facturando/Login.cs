using Facturando.Data;
using Facturando.Modelos;
using System;
using System.Windows.Forms;

namespace Facturando
{
    public partial class Login : BaseForm, IFormLogin
    {
        IUser _userData = new UserData();
        UserModel _user;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Encrypt encrypt = new Encrypt();
            string encText = encrypt.EncryptKey(txtContraseña.Text);
            //string decText = encrypt.DecryptKey(encText);
            _user =_userData.GetUser(new UserModel {
                 Login = txtUsuario.Text,
                 Password = encText
            });

            if (_user != null)
            {
                Hide();
                Principal principal = new Principal(SystemCompany, _user);
                principal.Show(this);
            }
            else {
                MessageBox.Show("Error en usuario o contraseña");
            }
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
