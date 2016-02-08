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
    public partial class Cliente : Form
    {
        IClient _clientData = new ClientData();
        IBill _billData = new BillData();
        
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            cmbTipo.DataSource = _billData.GetIdentificationType();
            cmbTipo.ValueMember = "Id";
            cmbTipo.DisplayMember = "Description";
            cmbTipo.SelectedIndex = 0;

            BindingSource clientSource = new BindingSource();
            clientSource.DataSource = new List<ClientModel>();
            dtgCliente.DataSource = clientSource;
            ((DataGridViewComboBoxColumn)dtgCliente.Columns["TypeList"])
                .DataSource = _billData.GetIdentificationType();
            ((DataGridViewComboBoxColumn)dtgCliente.Columns["TypeList"])
               .DisplayMember = "Description";
            ((DataGridViewComboBoxColumn)dtgCliente.Columns["TypeList"])
               .ValueMember = "Id";
            ((DataGridViewComboBoxColumn)dtgCliente.Columns["TypeList"])
               .DataPropertyName = "IdIdentificationType";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            BindingSource clientSource = new BindingSource();
            clientSource.DataSource = _clientData.GetClientList(new ClientModel
            {
                IdentificationNumber = txtIdentificacion.Text,
                IdIdentificationType = (Guid)cmbTipo.SelectedValue
            });
            dtgCliente.DataSource = clientSource;
            //((DataGridViewComboBoxColumn)dtgCliente.Columns["TypeList"])
            //    .DataSource = _billData.GetIdentificationType();
            //((DataGridViewComboBoxColumn)dtgCliente.Columns["TypeList"])
            //   .DisplayMember = "Description";
            //((DataGridViewComboBoxColumn)dtgCliente.Columns["TypeList"])
            //   .ValueMember = "Id";
            //((DataGridViewComboBoxColumn)dtgCliente.Columns["TypeList"])
            //   .DataPropertyName = "IdIdentificationType";
        }

        private void dtgCliente_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (e.Row.IsNewRow)
            {
                ((List<ClientModel>)((BindingSource)dtgCliente.DataSource).DataSource)[e.Row.Index - 1].Id = Guid.NewGuid();
                ((List<ClientModel>)((BindingSource)dtgCliente.DataSource).DataSource)[e.Row.Index - 1].DateEvent = DateTime.Now;

                dtgCliente.Rows[e.Row.Index - 1].Cells["IdIdentificationType"].Value =
                    ((List<IdentificationTypeModel>)((DataGridViewComboBoxColumn)(dtgCliente.Columns["TypeList"])).DataSource).FirstOrDefault().Id;                
            }
        }

        private void dtgCliente_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {            
            BindingSource clientSource = new BindingSource();
            clientSource.DataSource = _clientData.SaveClient((List<ClientModel>)((BindingSource)dtgCliente.DataSource).DataSource);
        }

        private void dtgCliente_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgCliente.Columns[e.ColumnIndex].Name.Equals("IdentificationNumber"))
            {
                if (((BindingSource)dtgCliente.DataSource) != null)
                {
                    if((List<ClientModel>)((BindingSource)dtgCliente.DataSource).DataSource != null)
                    {
                        string identificationTemp = ((List<ClientModel>)((BindingSource)dtgCliente.DataSource).DataSource)[e.RowIndex].IdentificationNumber;
                        if (_clientData.ClientExists(((List<ClientModel>)((BindingSource)dtgCliente.DataSource).DataSource)[e.RowIndex]))
                        {
                            MessageBox.Show("El número de identificación  ingresado ya existe en la base de datos");
                            ((List<ClientModel>)((BindingSource)dtgCliente.DataSource).DataSource)[e.RowIndex].IdentificationNumber = string.Empty;
                        }
                        else {
                            if (((List<ClientModel>)((BindingSource)dtgCliente.DataSource).DataSource)
                                .Count(x => x.IdentificationNumber.Equals(identificationTemp)) > 1)
                            {
                                MessageBox.Show("El número de identificación ingresado ya existe en este formulario");
                                ((List<ClientModel>)((BindingSource)dtgCliente.DataSource).DataSource)[e.RowIndex].IdentificationNumber = string.Empty;
                            }
                        }
                    }
                }
            }
        }
    }
}
