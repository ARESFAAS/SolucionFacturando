using System;
using System.Windows.Forms;

namespace Facturando
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Principal principal = new Principal();
            principal.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
