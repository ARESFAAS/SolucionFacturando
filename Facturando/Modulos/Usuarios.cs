using Facturando.Data;
using Facturando.Modelos;
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
    public partial class Usuarios : BaseForm
    {
        IUser _userData = new UserData();
        UserModel _userChange = new UserModel();
        RolModel2 _rolChange = new RolModel2();

        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            dtgUsuarios.DataSource = _userData.GetUsers();
            dtgRoles.DataSource = _userData.GetRolesForUpdate();
            lstModulos.DataSource = _userData.GetModules();
            lstModulos.DisplayMember = "Description";
            lstModulos.ValueMember = "Id";
        }

        private void dtgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var userTemp = ((List<UserModel>)senderGrid.DataSource)[e.RowIndex];
            _userChange = userTemp;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Name.Equals("ChangePassword"))
            {
                int randomPassword = new Random().Next(1000, 9999);
                txtPassword.Text = randomPassword.ToString();
            }
        }

        private void btnGuardarPassword_Click(object sender, EventArgs e)
        {
            Encrypt encrypt = new Encrypt();
            _userChange.Password = encrypt.EncryptKey(txtPassword.Text);
            List<UserModel> userModelChanged = new List<UserModel>();
            userModelChanged.Add(_userData.UpdatePassword(_userChange));
            dtgUsuarios.DataSource = userModelChanged;
        }

        private void btnGuardarRolModulo_Click(object sender, EventArgs e)
        {
            var selectedModules = lstModulos.SelectedItems;
            var newModules = new List<ModuleModel>();
            foreach (var item in selectedModules)
            {
                newModules.Add((ModuleModel)item);
            }
            _userData.UpdateModulesForRol(_rolChange.Id, newModules);
        }

        private void dtgRoles_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var rolTemp = ((List<RolModel2>)senderGrid.DataSource)[e.RowIndex];
            _rolChange = rolTemp;
            lstModulos.ClearSelected();
            foreach (var item in rolTemp.ModuleList)
            {
                foreach (var module in (List<ModuleModel>)lstModulos.DataSource)
                {
                    if (item.Description.Equals(module.Description))
                    {
                        lstModulos.SetSelected(lstModulos.Items.IndexOf(module), true);
                    }
                }
            }
        }
    }
}
