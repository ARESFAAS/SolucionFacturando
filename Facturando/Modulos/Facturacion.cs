using Facturando.Data;
using Facturando.Modelos;
using Facturando.Modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Facturando
{
    public partial class Facturacion : BaseForm, IFormBill
    {
        IBill _billData = new BillData();
        InventoryInterface _inventoryData = new InventoryData();
        ClientModel _client = null;
        List<BillDetailModel> _billDetail = new List<BillDetailModel>();
        BillModel _bill = new BillModel();
        List<BillTaxesModel> _billTaxes = new List<BillTaxesModel>();
        BillSaveModel _billSaveModel = new BillSaveModel();

        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            
            cmbTipoIdentificacion.DataSource = _billData.GetIdentificationType();
            cmbTipoIdentificacion.ValueMember = "Id";
            cmbTipoIdentificacion.DisplayMember = "Description";
            _bill = new BillModel {
                Id = Guid.NewGuid(),
                BillNumber = _billData.GetBillNumber(GetMacAddress()),
                DateEvent = DateTime.Now
            };

            if (_bill.BillNumber.Equals(0))
            {
                MessageBox.Show("No hay facturas disponibles. Debe configurar una nueva autorización", "Advertencia en configuración", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Enabled = false;
            }

            lblNumeroFactura.Text = _bill.BillNumber.ToString().PadLeft(8, '0');
            _billTaxes = _billData.GetBillTaxes();
            _billTaxes.ForEach(x => x.IdBill = _bill.Id);
            dtgImpuestos.DataSource = _billTaxes;
            lblGranTotal.Text = "$0,00";
            txtSubTotal.Text = string.Format("{0:0.00}", 0.00);
            txtDescuentoFinal.Text = string.Format("{0:0.00}", 0.00);
            txtDescuentoCliente.Text = string.Format("{0:0.00}", 0.00);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (cmbTipoIdentificacion.Items.Count > 0)
            {
                _client = _billData.GetClient(new ClientModel
                {
                    IdIdentificationType = (Guid)cmbTipoIdentificacion.SelectedValue,
                    IdentificationNumber = txtIdentificacionCliente.Text,
                    Name = txtNombreCliente.Text
                });

                if (_client != null)
                {
                    _bill.IdClient = _client.Id;
                    txtNombreCliente.Text = _client.Name;
                    txtDireccion.Text = _client.Adress;
                    txtEmail.Text = _client.Email;
                    txtDescuentoCliente.Text = _client.DiscountPercent.ToString();
                    txtTelefono.Text = _client.Phone;
                    txtIdentificacionCliente.Text = _client.IdentificationNumber;
                    cmbTipoIdentificacion.SelectedValue = _client.IdIdentificationType;
                    txtDiasLimite.Text = _client.CreditDaysNumber.ToString();
                    dtpFechaLimite.Value = DateTime.Now.AddDays(_client.CreditDaysNumber);
                }
                else
                {
                    MessageBox.Show("No encontramos un cliente con los datos de búsqueda, verique que esten correctos o diligencie los datos para crear un nuevo cliente");
                }
                btnBuscarProducto.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error - Revise la configuración del sistema");
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
                        Discount = (inventoryItem.LastSalePrice * (_client == null ? 0 : _client.DiscountPercent)) / 100,
                        Total = 0,
                        UnitPrice = inventoryItem.LastSalePrice,
                        FreeProduct = inventoryItem.FreeProduct
                    });

                    dtgDetalleFactura.DataSource = new List<BillDetailModel>();
                    dtgDetalleFactura.DataSource = _billDetail;
                }
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            PrintBill();
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
                            Discount = (inventoryItem.LastSalePrice * (_client == null ? 0 : _client.DiscountPercent)) / 100,
                            Total = 0,
                            UnitPrice = inventoryItem.LastSalePrice,
                            FreeProduct = inventoryItem.FreeProduct
                        });

                        dtgDetalleFactura.DataSource = new List<BillDetailModel>();
                        dtgDetalleFactura.DataSource = _billDetail;
                    }
                }
            }
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
                _billDetail.Find(x => x.Id == billDetailEditRow.Id).FreeProduct = billDetailEditRow.FreeProduct;
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

            btnFacturar.Enabled = true;

            ParentForm.Controls.Find("splitContainer1", true).FirstOrDefault().Controls[0].Enabled = true;
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
                    _billTaxes.ForEach(x => x.Total = (x.PercentageValue * _billDetail.Where(y => !y.FreeProduct).Sum(z => z.Total)) / 100);

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
                    _billTaxes.ForEach(x => x.Total = (x.PercentageValue * _billDetail.Where(y => !y.FreeProduct).Sum(z => z.Total)) / 100);

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

        private void dtgDetalleFactura_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Los datos que está intentando ingresar están errados.");
            return;
        }

        private void dtgDetalleFactura_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgDetalleFactura.Columns[e.ColumnIndex].Name.Equals("Total"))
            {
                decimal totalTemp = ((BillDetailModel)dtgDetalleFactura.Rows[e.RowIndex].DataBoundItem).Total;
                if (totalTemp <= 0)
                {
                    e.CellStyle.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    e.CellStyle.BackColor = System.Drawing.Color.White;
                }
            }
        }

        private void billValuesCalculate()
        {
            _bill.Total = 0;

            txtSubTotal.Text = string.Format("{0:0.00}", _billDetail.Sum(x => x.Total));
            decimal newTotalTemp = decimal.Parse(txtSubTotal.Text) - decimal.Parse(txtDescuentoFinal.Text);
            _billTaxes.ForEach(x => x.Total = (x.PercentageValue * _billDetail.Where(y => !y.FreeProduct).Sum(z => z.Total)) / 100);

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
                MessageBox.Show("Faltan los datos del cliente para crear la factura, identificación y nombre");
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
                    Phone = txtTelefono.Text,
                    IsNew = true,
                    CreditDaysNumber = !String.IsNullOrEmpty(txtDiasLimite.Text) ? int.Parse(txtDiasLimite.Text) : 0
                };
                _bill.IdClient = _client.Id;
                _bill.LimitDate = dtpFechaLimite.Value;                
            }
            return result;
        }

        private void SaveBill()
        {
            _bill.IsPaid = chkPagada.Checked;
            if (chkPagada.Checked) { _bill.PaidDate = DateTime.Now; } else { _bill.PaidDate = null; }
           _bill.Comments = txtObservaciones.Text;

            _billSaveModel.Client = _client;
            _billSaveModel.Bill = _bill;
            _billSaveModel.BillDetail = _billDetail;
            _billSaveModel.BillTaxes = _billTaxes;

            if (_billSaveModel.Bill.Id != null &&
                _bill.IdClient != null &&
                _billDetail.Count > 0 &&
                _billTaxes.Count > 0 &&
                _bill.Total > 0)
            {
                // Guarda los datos de la factura
                _billData.SaveBill(_billSaveModel, GetMacAddress());

                // Actualiza el inventario
                foreach (var item in _billSaveModel.BillDetail)
                {
                    InventoryModel inventoryTemp = _inventoryData.GetInventoryByProductId(item.IdProduct);
                    if (inventoryTemp == null)
                    {
                        inventoryTemp = new InventoryModel { IdProduct = item.IdProduct, LastSalePrice = 0, Quantity = item.Quantity };
                    }
                    inventoryTemp.Quantity = item.Quantity;
                    InventoryDetailModel inventoryDetailTemp = _inventoryData.GetLastInventoryDetailInByProductId(item.IdProduct);

                    inventoryDetailTemp.Quantity = item.Quantity;
                    inventoryDetailTemp.IdInventoryType = _inventoryData.GetInventoryType("-").Where(x => x.Description.ToLower().Equals("venta")).FirstOrDefault().Id;
                    inventoryDetailTemp.EventDate = DateTime.Now;

                    _inventoryData.SaveInventory(new InventorySaveModel
                    {
                        Inventory = inventoryTemp,
                        InventoryDetail = inventoryDetailTemp
                    });
                }                
            }
            else
            {
                MessageBox.Show("No hay datos para facturar");
            }
        }

        private void ClearControls()
        {
            _billData = new BillData();
            _inventoryData = new InventoryData();
            _client = null;
            _billDetail = new List<BillDetailModel>();
            _bill = new BillModel();
            _billTaxes = new List<BillTaxesModel>();
            _billSaveModel = new BillSaveModel();

            _bill = new BillModel
            {
                Id = Guid.NewGuid(),
                BillNumber = _billData.GetBillNumber(GetMacAddress()),
                DateEvent = DateTime.Now
            };
            lblNumeroFactura.Text = _bill.BillNumber.ToString().PadLeft(8, '0');
            _billTaxes = _billData.GetBillTaxes();
            _billTaxes.ForEach(x => x.IdBill = _bill.Id);
            dtgImpuestos.DataSource = _billTaxes;
            lblGranTotal.Text = "$0,00";
            txtSubTotal.Text = string.Format("{0:0.00}", 0.00);
            txtDescuentoFinal.Text = string.Format("{0:0.00}", 0.00);
            txtDescuentoCliente.Text = string.Format("{0:0.00}", 0.00);
            dtgDetalleFactura.DataSource = new List<BillDetailModel>();
            txtIdentificacionCliente.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCodigoBarras.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            lstProducto.DataSource = new List<InventoryModel>();
            btnBuscarProducto.Enabled = false;
            btnFacturar.Enabled = false;
            txtDiasLimite.Text = string.Empty;
            dtpFechaLimite.Value = DateTime.Now;
            chkPagada.Checked = true;
            txtObservaciones.Text = string.Empty;

            if (_bill.BillNumber.Equals(0))
            {
                Enabled = false;
            }
        }

        public void NewBill()
        {
            SaveBill();
            ClearControls();
        }

        private void PrintBill() {
            ConverseNumberToText numberToTextInstance = new ConverseNumberToText();
            _bill.TotalInLetters = numberToTextInstance.enletras(_bill.Total.ToString());
            _billSaveModel.Client = _client;
            _billSaveModel.Bill = _bill;
            _billSaveModel.BillDetail = _billDetail;
            _billSaveModel.BillTaxes = _billTaxes;

            if (System.Configuration.ConfigurationSettings.AppSettings["PrintFormat"].ToString().ToUpper().Equals("CARTA"))
            {
                VisorFactura visorFactura = new VisorFactura(_billSaveModel);
                visorFactura.Show(this);
            }
            else if (System.Configuration.ConfigurationSettings.AppSettings["PrintFormat"].ToString().ToUpper().Equals("MEDIACARTAVERTICAL"))
            {
                VisorFacturaMediaCartaVertical visorFactura = new VisorFacturaMediaCartaVertical(_billSaveModel);
                visorFactura.Show(this);
            }
            else
            {
                VisorFacturaMediaCarta visorFactura = new VisorFacturaMediaCarta(_billSaveModel);
                visorFactura.Show(this);
            }
        }

        private void dtgDetalleFactura_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            ParentForm.Controls.Find("splitContainer1", true).FirstOrDefault().Controls[0].Enabled = false;
        }

        private void txtDiasLimite_TextChanged(object sender, EventArgs e)
        {
            int limitDaysTemp = 0;
            if(!string.IsNullOrEmpty(txtDiasLimite.Text) && int.TryParse(txtDiasLimite.Text, out limitDaysTemp))
            {
                dtpFechaLimite.Value = DateTime.Now.AddDays(limitDaysTemp);
            }
            else
            {
                dtpFechaLimite.Value = DateTime.Now;
            }
            _bill.LimitDate = dtpFechaLimite.Value;
            if(_client != null)
            {
                _client.CreditDaysNumber = limitDaysTemp;
            }            
        }

        private void lstProducto_Format(object sender, ListControlConvertEventArgs e)
        {
            string productDescription = ((InventoryModel)e.ListItem).Product;
            string quantity = ((InventoryModel)e.ListItem).Quantity.ToString();
            e.Value = productDescription + " ---> " + quantity;
        }
    }
}