using Facturando.Data;
using Facturando.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturando
{
    public partial class Facturacion : Form
    {
        IBill _billData = new BillData();
        InventoryInterface _inventoryData = new InventoryData();
        ClientModel _client = null;
        List<BillDetailModel> _billDetail = new List<BillDetailModel>();
        BillModel _bill = new BillModel();
        List<BillTaxesModel> _billTaxes = new List<BillTaxesModel>();

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
            _billTaxes = _billData.GetBillTaxes();
            dtgImpuestos.DataSource = _billTaxes;
            lblGranTotal.Text = "$0,00";
            txtSubTotal.Text = string.Format("{0:0.00}", 0.00);
            txtDescuentoFinal.Text = string.Format("{0:0.00}", 0.00);
            txtDescuentoCliente.Text = string.Format("{0:0.00}", 0.00);
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
            else
            {
                MessageBox.Show("No encontramos un cliente con los datos de búsqueda, verique que esten correctos o diligencie los datos para crear un nuevo cliente");                
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (_client == null)
            {
                clientEntityGet();
            }
            else
            {
                lstProducto.DataSource = _inventoryData.GetInventory(txtCodigoBarras.Text, txtNombreProducto.Text);
                lstProducto.DisplayMember = "Product";
                lstProducto.ValueMember = "Id";
            }
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
                        Discount = (inventoryItem.LastSalePrice * _client.DiscountPercent) / 100,
                        Total = 0,
                        UnitPrice = inventoryItem.LastSalePrice
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

                    billValuesCalculate();
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
                            Discount = (inventoryItem.LastSalePrice * _client.DiscountPercent) / 100,
                            Total = 0,
                            UnitPrice = inventoryItem.LastSalePrice
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
            if (dtgridCellEdit.OwningColumn.Name.Equals("Quantity") ||
                dtgridCellEdit.OwningColumn.Name.Equals("Discount") ||
                dtgridCellEdit.OwningColumn.Name.Equals("UnitPrice"))
            {
                BillDetailModel billDetailEditRow = (BillDetailModel)dtgridCellEdit.OwningRow.DataBoundItem;
                _billDetail.Find(x => x.Id == billDetailEditRow.Id).UnitPrice = billDetailEditRow.UnitPrice;
                _billDetail.Find(x => x.Id == billDetailEditRow.Id).Quantity = billDetailEditRow.Quantity;
                _billDetail.Find(x => x.Id == billDetailEditRow.Id).Discount = billDetailEditRow.Discount;
                _billDetail.Find(x => x.Id == billDetailEditRow.Id).Total =
                    ((billDetailEditRow.UnitPrice - billDetailEditRow.Discount) * billDetailEditRow.Quantity);
            }

            if (dtgridCellEdit.OwningColumn.Name.Equals("Total"))
            {
                BillDetailModel billDetailEditRow = (BillDetailModel)dtgridCellEdit.OwningRow.DataBoundItem;
                _billDetail.Find(x => x.Id == billDetailEditRow.Id).Total = billDetailEditRow.Total;
            }

            billValuesCalculate();

            this.BeginInvoke(new System.Action(() =>
            {
                dtgDetalleFactura.DataSource = new List<BillDetailModel>();
                dtgDetalleFactura.DataSource = _billDetail;
            }));
        }

        private void txtSubTotal_Leave(object sender, EventArgs e)
        {
            try
            {
                string decimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                Regex rex = new Regex(string.Concat("\\d+", decimalSeparator, "\\d+"));

                var isValid = rex.IsMatch(txtSubTotal.Text);
                var isValid2 = rex.IsMatch(txtDescuentoFinal.Text);

                if (isValid && isValid2)
                {
                    _bill.Total = 0;

                    decimal newTotalTemp = decimal.Parse(txtSubTotal.Text) - decimal.Parse(txtDescuentoFinal.Text);
                    _billTaxes.ForEach(x => x.Total = (x.PercentageValue * newTotalTemp) / 100);

                    dtgImpuestos.DataSource = new List<BillTaxesModel>();
                    dtgImpuestos.DataSource = _billTaxes;

                    try
                    {
                        _bill.IdClient = _client.Id;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No existen datos de cliente para facturar");
                        return;
                    }
                   

                    foreach (var item in _billTaxes)
                    {
                        _bill.Total += item.Total;
                    }
                    _bill.Total += newTotalTemp;

                    lblGranTotal.Text = _bill.Total.ToString("C", new System.Globalization.CultureInfo("es-EC"));
                }
                else
                {
                    MessageBox.Show("Al parecer hay un valor equivocado en la los datos de subtotal y descuento final, revise nuevamente");
                    txtSubTotal.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                return;
            }
        }

        private void txtDescuentoFinal_Leave(object sender, EventArgs e)
        {
            try
            {
                string decimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                Regex rex = new Regex(string.Concat("\\d+", decimalSeparator, "\\d+"));

                var isValid = rex.IsMatch(txtSubTotal.Text);
                var isValid2 = rex.IsMatch(txtDescuentoFinal.Text);

                if (isValid && isValid2)
                {
                    _bill.Total = 0;

                    decimal newTotalTemp = decimal.Parse(txtSubTotal.Text) - decimal.Parse(txtDescuentoFinal.Text);
                    _billTaxes.ForEach(x => x.Total = (x.PercentageValue * newTotalTemp) / 100);

                    dtgImpuestos.DataSource = new List<BillTaxesModel>();
                    dtgImpuestos.DataSource = _billTaxes;

                    try
                    {
                        _bill.IdClient = _client.Id;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No existen datos de cliente para facturar");
                        return;
                    }

                    foreach (var item in _billTaxes)
                    {
                        _bill.Total += item.Total;
                    }
                    _bill.Total += newTotalTemp;

                    lblGranTotal.Text = _bill.Total.ToString("C", new System.Globalization.CultureInfo("es-EC"));
                }
                else
                {
                    MessageBox.Show("Al parecer hay un valor equivocado en la los datos de subtotal y descuento final, revise nuevamente");
                    txtDescuentoFinal.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                return;
            }
        }

        private void txtDescuentoCliente_Leave(object sender, EventArgs e)
        {
            try
            {
                string decimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                Regex rex = new Regex(string.Concat("\\d+", decimalSeparator, "\\d+"));

                var isValid = rex.IsMatch(txtDescuentoCliente.Text);

                if (!isValid)
                {
                    MessageBox.Show("Al parecer hay un valor equivocado en la los datos del porcentaje de descuento del cliente, revise nuevamente");
                    txtDescuentoCliente.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                return;
            }
        }

        private void billValuesCalculate()
        {
            _bill.Total = 0;

            txtSubTotal.Text = string.Format("{0:0.00}", _billDetail.Sum(x => x.Total)); //_billDetail.Sum(x => x.Total).ToString();
            decimal newTotalTemp = decimal.Parse(txtSubTotal.Text) - decimal.Parse(txtDescuentoFinal.Text);
            _billTaxes.ForEach(x => x.Total = (x.PercentageValue * newTotalTemp) / 100);

            dtgImpuestos.DataSource = new List<BillTaxesModel>();
            dtgImpuestos.DataSource = _billTaxes;

            _bill.IdClient = _client.Id;
            foreach (var item in _billTaxes)
            {
                _bill.Total += item.Total;
            }
            _bill.Total += newTotalTemp;

            lblGranTotal.Text = _bill.Total.ToString("C", new System.Globalization.CultureInfo("es-EC"));
        }

        private bool clientEntityGet()
        {
            bool result = false;
            if (txtIdentificacionCliente.Text.Equals(string.Empty) || txtNombreCliente.Text.Equals(string.Empty))
            {
                MessageBox.Show("Faltan los datos del cliente para crear la factura, nombre y dirección");
            }
            else
            {
                result = true;
                _client = new ClientModel
                {
                    Id = Guid.NewGuid(),
                    Adress = txtDireccion.Text,
                    DiscountPercent = decimal.Parse(txtDescuentoCliente.Text),
                    Email = txtEmail.Text,
                    IdentificationNumber = txtIdentificacionCliente.Text,
                    IdIdentificationType = (Guid)cmbTipoIdentificacion.SelectedValue,
                    Name = txtNombreCliente.Text,
                    Phone = txtTelefono.Text
                };
            }
            return result;
        }       
    }
}