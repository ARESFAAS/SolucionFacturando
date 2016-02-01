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

namespace Facturando
{
    public partial class Facturacion : Form
    {
        IBill _billData = new BillData();
        InventoryInterface _inventoryData = new InventoryData();
        ClientModel _client = new ClientModel();
        List<BillDetailModel> _billDetail = new List<BillDetailModel>();
        BillModel _bill = new BillModel();

        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            cmbTipoIdentificacion.DataSource = _billData.GetIdentificationType();
            cmbTipoIdentificacion.ValueMember = "Id";
            cmbTipoIdentificacion.DisplayMember = "Description";
            _bill = new BillModel { Id = Guid.NewGuid() };
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            _client = _billData.GetClient(new ClientModel
            {
                IdIdentificationType = (Guid)cmbTipoIdentificacion.SelectedValue,
                IdentificationNumber = txtIdentificacionCliente.Text
            });

            if (_client != null)
            {
                txtNombreCliente.Text = _client.Name;
                txtDireccion.Text = _client.Adress;
                txtEmail.Text = _client.Email;
                txtDescuentoCliente.Text = _client.DiscountPercent.ToString();
                txtTelefono.Text = _client.Phone;
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            lstProducto.DataSource = _inventoryData
                .GetInventory(txtCodigoBarras.Text, txtNombreProducto.Text);
            lstProducto.DisplayMember = "Product";
            lstProducto.ValueMember = "Id";
        }

        private void lstProducto_Click(object sender, EventArgs e)
        {
            ListBox lstBox = (ListBox)sender;
            InventoryModel inventoryItem = (InventoryModel)lstBox.SelectedItem;

            if ((List<InventoryModel>)lstBox.DataSource != null)
            {

                if (((List<InventoryModel>)lstBox.DataSource).Count > 0)
                {
                    _billDetail.Add(new BillDetailModel
                    {
                        Id = Guid.NewGuid(),
                        IdBill = _bill.Id,
                        IdProduct = inventoryItem.IdProduct,
                        Product = inventoryItem.Product,
                        Quantity = 0,
                        Discount = _client.DiscountPercent,
                        Total = 0
                    });
                    dtgDetalleFactura.DataSource = new List<BillDetailModel>();
                    dtgDetalleFactura.DataSource = _billDetail;
                }
            }
        }

        private void dtgDetalleFactura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (_billDetail.Count > 0)
                {
                    e.Handled = true;
                    _billDetail.Remove((BillDetailModel)((DataGridView)sender).CurrentRow.DataBoundItem);
                    dtgDetalleFactura.DataSource = new List<BillDetailModel>();
                    dtgDetalleFactura.DataSource = _billDetail;
                }
            }
        }

        private void lstProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListBox lstBox = (ListBox)sender;
                if ((List<InventoryModel>)lstBox.DataSource != null)
                {
                    if (((List<InventoryModel>)lstBox.DataSource).Count > 0)
                    {
                        InventoryModel inventoryItem = (InventoryModel)lstBox.SelectedItem;

                        _billDetail.Add(new BillDetailModel
                        {
                            Id = Guid.NewGuid(),
                            IdBill = _bill.Id,
                            IdProduct = inventoryItem.IdProduct,
                            Product = inventoryItem.Product,
                            Quantity = 0,
                            Discount = _client.DiscountPercent,
                            Total = 0
                        });
                        dtgDetalleFactura.DataSource = new List<BillDetailModel>();
                        dtgDetalleFactura.DataSource = _billDetail;
                    }
                }
            }
        }

        private void dtgDetalleFactura_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtgDetalleFactura_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell dtgridCellEdit = ((DataGridView)sender).CurrentCell;
            if (dtgridCellEdit.OwningColumn.Name.Equals("Quantity") || dtgridCellEdit.OwningColumn.Name.Equals("Discount") || dtgridCellEdit.OwningColumn.Name.Equals("Total"))
            {
                BillDetailModel billDetailEditRow = (BillDetailModel)dtgridCellEdit.OwningRow.DataBoundItem;
                _billDetail.Find(x => x.Id == billDetailEditRow.Id).Quantity = billDetailEditRow.Quantity;
                _billDetail.Find(x => x.Id == billDetailEditRow.Id).Discount = billDetailEditRow.Discount;
                _billDetail.Find(x => x.Id == billDetailEditRow.Id).Total = billDetailEditRow.Total;
            }
        }
    }
}
