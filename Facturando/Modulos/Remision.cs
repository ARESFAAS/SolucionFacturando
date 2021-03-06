﻿using Facturando.Data;
using Facturando.Helper;
using Facturando.Modelos;
using Facturando.Modulos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Facturando
{
    public partial class Remision : BaseForm, IFormRemission
    {
        IBill _billData = new BillData();
        IRemission _remissionData = new RemissionData();
        RemissionModel _remission = new RemissionModel();
        List<RemissionDetailModel> _remissionDetail = new List<RemissionDetailModel>();
        ClientModel _client = null;
        InventoryInterface _inventoryData = new InventoryData();
        RemissionSaveModel _remissionSaveModel = new RemissionSaveModel();
        bool _marketMode = false;

        public Remision()
        {
            InitializeComponent();
        }

        public Remision(UserModel user)
        {
            InitializeComponent();
            base.User = user;
        }

        private void Remision_Load(object sender, EventArgs e)
        {
            cmbTipoIdentificacion.DataSource = _billData.GetIdentificationType();
            cmbTipoIdentificacion.ValueMember = "Id";
            cmbTipoIdentificacion.DisplayMember = "Description";
            _remission = new RemissionModel
            {
                Id = Guid.NewGuid(),
                RemissionNumber = _remissionData.GetRemissionNumber(GetMacAddress()),
                Total = 0,
                DateEvent = DateTime.Now
            };
            lblNumeroRemision.Text = _remission.RemissionNumber.ToString().PadLeft(8, '0');
            lblGranTotal.Text = "$0,00";
            txtSubTotal.Text = string.Format("{0:0.00}", 0.00);
            txtDescuentoFinal.Text = string.Format("{0:0.00}", 0.00);
            txtDescuentoCliente.Text = string.Format("{0:0.00}", 0.00);

            _marketMode = bool.Parse(System.Configuration.ConfigurationManager.AppSettings["MarketMode"].ToString());

            if (_marketMode)
            {
                MarketModeConfig();
            }
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
                    _remission.IdClient = _client.Id;
                    txtNombreCliente.Text = _client.Name;
                    txtDireccion.Text = _client.Adress;
                    txtEmail.Text = _client.Email;
                    txtDescuentoCliente.Text = _client.DiscountPercent.ToString();
                    txtTelefono.Text = _client.Phone;
                    txtIdentificacionCliente.Text = _client.IdentificationNumber;
                    cmbTipoIdentificacion.SelectedValue = _client.IdIdentificationType;

                    txtCodigoBarras.Focus();
                }
                else
                {
                    MessageBox.Show("No encontramos un cliente con los datos de búsqueda, verique que esten correctos o diligencie los datos para crear un nuevo cliente");
                }
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
                clientEntityGetNew();
            }
            else
            {
                lstProducto.DataSource = _inventoryData.GetInventory(txtCodigoBarras.Text, txtNombreProducto.Text);
                lstProducto.DisplayMember = "Product";
                lstProducto.ValueMember = "Id";
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
                    decimal newTotalTemp = decimal.Parse(txtSubTotal.Text) - decimal.Parse(txtDescuentoFinal.Text);
                    _remission.Total = newTotalTemp;

                    try
                    {
                        _remission.IdClient = _client.Id;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No existen datos de cliente para hacer la remisión");
                        return;
                    }

                    lblGranTotal.Text = _remission.Total.ToString("C", new System.Globalization.CultureInfo("es-EC"));
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
                    decimal newTotalTemp = decimal.Parse(txtSubTotal.Text) - decimal.Parse(txtDescuentoFinal.Text);
                    _remission.Total = newTotalTemp;

                    try
                    {
                        _remission.IdClient = _client.Id;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No existen datos de cliente para hacer la remisión");
                        return;
                    }

                    lblGranTotal.Text = _remission.Total.ToString("C", new System.Globalization.CultureInfo("es-EC"));
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

        private void lstProducto_Click(object sender, EventArgs e)
        {
            ListBox lstBox = (ListBox)sender;
            InventoryModel inventoryItem = (InventoryModel)lstBox.SelectedItem;

            if ((List<InventoryModel>)lstBox.DataSource != null)
            {
                if (((List<InventoryModel>)lstBox.DataSource).Count > 0)
                {
                    RemissionDetailModel remissionDetailItem = new RemissionDetailModel
                    {
                        Id = Guid.NewGuid(),
                        IdRemission = _remission.Id,
                        IdProduct = inventoryItem.IdProduct,
                        Product = inventoryItem.Product,
                        Quantity = 1,
                        Discount = (inventoryItem.LastSalePrice * (_client == null ? 0 : _client.DiscountPercent)) / 100,
                        Total = 0,
                        UnitPrice = inventoryItem.LastSalePrice
                    };

                    remissionDetailItem.Total = ((remissionDetailItem.UnitPrice - remissionDetailItem.Discount) * remissionDetailItem.Quantity);

                    _remissionDetail.Add(remissionDetailItem);

                    remissionValuesCalculate();

                    dtgDetalleRemision.DataSource = new List<RemissionDetailModel>();
                    dtgDetalleRemision.DataSource = _remissionDetail;

                    btnRemitir.Enabled = false;
                    btnTermica.Enabled = true;

                    ParentForm.Controls.Find("splitContainer1", true).FirstOrDefault().Controls[0].Enabled = true;

                    txtCodigoBarras.Focus();
                    txtCodigoBarras.Text = string.Empty;
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

                        RemissionDetailModel remissionDetailItem = new RemissionDetailModel
                        {
                            Id = Guid.NewGuid(),
                            IdRemission = _remission.Id,
                            IdProduct = inventoryItem.IdProduct,
                            Product = inventoryItem.Product,
                            Quantity = 1,
                            Discount = (inventoryItem.LastSalePrice * (_client == null ? 0 : _client.DiscountPercent)) / 100,
                            Total = 0,
                            UnitPrice = inventoryItem.LastSalePrice
                        };

                        remissionDetailItem.Total = ((remissionDetailItem.UnitPrice - remissionDetailItem.Discount) * remissionDetailItem.Quantity);

                        _remissionDetail.Add(remissionDetailItem);

                        remissionValuesCalculate();

                        dtgDetalleRemision.DataSource = new List<RemissionDetailModel>();
                        dtgDetalleRemision.DataSource = _remissionDetail;

                        btnRemitir.Enabled = false;
                        btnTermica.Enabled = true;

                        ParentForm.Controls.Find("splitContainer1", true).FirstOrDefault().Controls[0].Enabled = true;

                        txtCodigoBarras.Focus();
                        txtCodigoBarras.Text = string.Empty;
                    }
                }
            }
        }

        private void btnRemitir_Click(object sender, EventArgs e)
        {
            PrintRemission();
        }

        private void dtgDetalleRemision_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (_remissionDetail.Count > 0)
                {
                    e.Handled = true;
                    _remissionDetail.Remove((RemissionDetailModel)((DataGridView)sender).CurrentRow.DataBoundItem);
                    dtgDetalleRemision.DataSource = new List<RemissionDetailModel>();
                    dtgDetalleRemision.DataSource = _remissionDetail;

                    remissionValuesCalculate();
                }
            }
        }

        private void dtgDetalleRemision_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell dtgridCellEdit = ((DataGridView)sender).CurrentCell;
            if (dtgridCellEdit.OwningColumn.Name.Equals("Quantity") ||
                dtgridCellEdit.OwningColumn.Name.Equals("Discount") ||
                dtgridCellEdit.OwningColumn.Name.Equals("UnitPrice"))
            {
                RemissionDetailModel remissionDetailEditRow = (RemissionDetailModel)dtgridCellEdit.OwningRow.DataBoundItem;
                _remissionDetail.Find(x => x.Id == remissionDetailEditRow.Id).UnitPrice = remissionDetailEditRow.UnitPrice;
                _remissionDetail.Find(x => x.Id == remissionDetailEditRow.Id).Quantity = remissionDetailEditRow.Quantity;
                _remissionDetail.Find(x => x.Id == remissionDetailEditRow.Id).Discount = remissionDetailEditRow.Discount;
                _remissionDetail.Find(x => x.Id == remissionDetailEditRow.Id).Total =
                    ((remissionDetailEditRow.UnitPrice - remissionDetailEditRow.Discount) * remissionDetailEditRow.Quantity);
            }

            if (dtgridCellEdit.OwningColumn.Name.Equals("Total"))
            {
                RemissionDetailModel remissionDetailEditRow = (RemissionDetailModel)dtgridCellEdit.OwningRow.DataBoundItem;
                _remissionDetail.Find(x => x.Id == remissionDetailEditRow.Id).Total = remissionDetailEditRow.Total;
            }

            remissionValuesCalculate();

            this.BeginInvoke(new System.Action(() =>
            {
                dtgDetalleRemision.DataSource = new List<RemissionDetailModel>();
                dtgDetalleRemision.DataSource = _remissionDetail;
            }));

            btnRemitir.Enabled = true;
            btnTermica.Enabled = true;

            ParentForm.Controls.Find("splitContainer1", true).FirstOrDefault().Controls[0].Enabled = true;
        }

        private void dtgDetalleRemision_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Los datos que está intentando ingresar están errados.");
            return;
        }

        private void dtgDetalleRemision_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgDetalleRemision.Columns[e.ColumnIndex].Name.Equals("Total"))
            {
                decimal totalTemp = ((RemissionDetailModel)dtgDetalleRemision.Rows[e.RowIndex].DataBoundItem).Total;
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

        private void btnTermica_Click(object sender, EventArgs e)
        {
            DialogResult resultValidatePrintRemission = MessageBox.Show("Seguro, los datos se guardarán", "Imprimir", MessageBoxButtons.OKCancel);
            if (resultValidatePrintRemission == DialogResult.OK)
            {
                PrintThermalRemission();
            }
        }

        private void txtCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_marketMode)
                {
                    lstProducto.DataSource = _inventoryData.GetInventory(txtCodigoBarras.Text, txtNombreProducto.Text);
                    lstProducto.DisplayMember = "Product";
                    lstProducto.ValueMember = "Id";

                    if ((List<InventoryModel>)lstProducto.DataSource != null)
                    {
                        if (((List<InventoryModel>)lstProducto.DataSource).Count > 0)
                        {
                            lstProducto.SelectedIndex = 0;
                            InventoryModel inventoryItem = (InventoryModel)lstProducto.SelectedItem;

                            RemissionDetailModel remissionDetailItem = new RemissionDetailModel
                            {
                                Id = Guid.NewGuid(),
                                IdRemission = _remission.Id,
                                IdProduct = inventoryItem.IdProduct,
                                Product = inventoryItem.Product,
                                Quantity = 1,
                                Discount = (inventoryItem.LastSalePrice * (_client == null ? 0 : _client.DiscountPercent)) / 100,
                                Total = 0,
                                UnitPrice = inventoryItem.LastSalePrice
                            };

                            remissionDetailItem.Total = ((remissionDetailItem.UnitPrice - remissionDetailItem.Discount) * remissionDetailItem.Quantity);

                            _remissionDetail.Add(remissionDetailItem);

                            remissionValuesCalculate();

                            dtgDetalleRemision.DataSource = new List<RemissionDetailModel>();
                            dtgDetalleRemision.DataSource = _remissionDetail;

                            btnRemitir.Enabled = false;
                            btnTermica.Enabled = true;

                            ParentForm.Controls.Find("splitContainer1", true).FirstOrDefault().Controls[0].Enabled = true;

                            txtCodigoBarras.Focus();
                            txtCodigoBarras.Text = string.Empty;
                        }
                    }
                }
            }
        }

        private void txtIdentificacionCliente_Enter(object sender, EventArgs e)
        {
            txtNombreCliente.Text = string.Empty;
        }

        private void dtgDetalleRemision_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            ParentForm.Controls.Find("splitContainer1", true).FirstOrDefault().Controls[0].Enabled = false;
        }

        private void lstProducto_Format(object sender, ListControlConvertEventArgs e)
        {
            string productDescription = ((InventoryModel)e.ListItem).Product;
            string quantity = ((InventoryModel)e.ListItem).Quantity.ToString();
            e.Value = productDescription + " ---> " + quantity;
        }

        private void clientEntityGet()
        {
            if (!string.IsNullOrEmpty(txtIdentificacionCliente.Text) && !string.IsNullOrEmpty(txtNombreCliente.Text))
            {
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
                    IsNew = true
                };

                _remission.IdClient = _client.Id;
            }
            else
            {
                if (cmbTipoIdentificacion.Items.Count > 0)
                {
                    _client = new ClientModel
                    {
                        Adress = txtDireccion.Text,
                        DiscountPercent = decimal.Parse(txtDescuentoCliente.Text),
                        Email = txtEmail.Text,
                        IdentificationNumber = txtIdentificacionCliente.Text,
                        IdIdentificationType = (Guid)cmbTipoIdentificacion.SelectedValue,
                        Name = txtNombreCliente.Text,
                        Phone = txtTelefono.Text,
                    };
                }
                else
                {
                    MessageBox.Show("Error - revise la configuración del sistema");
                }
            }
        }

        private bool clientEntityGetNew()
        {
            bool result = false;
            if (txtIdentificacionCliente.Text.Equals(string.Empty) || txtNombreCliente.Text.Equals(string.Empty))
            {
                MessageBox.Show("Faltan los datos del cliente para crear la remision, identificación y nombre");
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
                    IsNew = true
                };

                _remission.IdClient = _client.Id;
            }
            return result;
        }

        private void remissionValuesCalculate()
        {
            _remission.Total = 0;
            txtSubTotal.Text = string.Format("{0:0.00}", _remissionDetail.Sum(x => x.Total));
            decimal newTotalTemp = decimal.Parse(txtSubTotal.Text) - decimal.Parse(txtDescuentoFinal.Text);

            _remission.IdClient = _client.Id;

            _remission.Total = newTotalTemp;
            lblGranTotal.Text = _remission.Total.ToString("C", new System.Globalization.CultureInfo("es-EC"));
        }

        private void SaveRemission()
        {
            _remission.IsPaid = chkPagada.Checked;
            if (chkPagada.Checked) { _remission.PaidDate = DateTime.Now; } else { _remission.PaidDate = null; }
            _remission.Comments = txtObservaciones.Text;
            _remission.IdUser = base.User.Id;

            _remissionSaveModel.Client = _client;
            _remissionSaveModel.Remission = _remission;
            _remissionSaveModel.RemissionDetail = _remissionDetail;
            
            if (_remissionSaveModel.Remission.Id != null &&
                _remission.IdClient != null &&
                _remissionDetail.Count > 0 &&
                _remission.Total > 0)
            {
                // Guarda los datos de la remisión
                _remissionData.SaveRemission(_remissionSaveModel, GetMacAddress());

                // Actualiza el inventario
                foreach (var item in _remissionSaveModel.RemissionDetail)
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
                MessageBox.Show("No hay datos para hacer la remisión");
            }
        }

        private void ClearControls()
        {
            _billData = new BillData();
            _inventoryData = new InventoryData();
            _client = null;
            _remissionDetail = new List<RemissionDetailModel>();
            _remissionSaveModel = new RemissionSaveModel();

            _remission = new RemissionModel
            {
                Id = Guid.NewGuid(),
                RemissionNumber = _remissionData.GetRemissionNumber(GetMacAddress()),
                DateEvent = DateTime.Now
            };
            lblNumeroRemision.Text = _remission.RemissionNumber.ToString().PadLeft(8, '0');
            lblGranTotal.Text = "$0,00";
            txtSubTotal.Text = string.Format("{0:0.00}", 0.00);
            txtDescuentoFinal.Text = string.Format("{0:0.00}", 0.00);
            txtDescuentoCliente.Text = string.Format("{0:0.00}", 0.00);
            dtgDetalleRemision.DataSource = new List<RemissionDetailModel>();
            txtIdentificacionCliente.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCodigoBarras.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            lstProducto.DataSource = new List<InventoryModel>();           
            btnRemitir.Enabled = false;
            btnTermica.Enabled = false;
            chkPagada.Checked = true;
            txtObservaciones.Text = string.Empty;
        }

        public void NewRemission()
        {
            SaveRemission();
            ClearControls();
            if (_marketMode)
            {
                MarketModeConfig();
            }
        }

        private void PrintRemission()
        {
            ConverseNumberToText numberToTextInstance = new ConverseNumberToText();
            _remission.TotalInLetters = numberToTextInstance.enletras(_remission.Total.ToString());
            _remissionSaveModel.Client = _client;
            _remissionSaveModel.Remission = _remission;
            _remissionSaveModel.RemissionDetail = _remissionDetail;

            if (System.Configuration.ConfigurationSettings.AppSettings["PrintFormat"].ToString().ToUpper().Equals("CARTA"))
            {
                VisorRemision visorRemision = new VisorRemision(_remissionSaveModel);
                visorRemision.Show(this);
            }
            else if (System.Configuration.ConfigurationSettings.AppSettings["PrintFormat"].ToString().ToUpper().Equals("MEDIACARTAVERTICAL"))
            {
                VisorRemisionMediaCartaVertical visorFactura = new VisorRemisionMediaCartaVertical(_remissionSaveModel);
                visorFactura.Show(this);
            }
            else
            {
                VisorRemisionMediaCarta visorRemision = new VisorRemisionMediaCarta(_remissionSaveModel);
                visorRemision.Show(this);
            }
        }

        private void PrintThermalRemission()
        {
            ConverseNumberToText numberToTextInstance = new ConverseNumberToText();
            _remission.TotalInLetters = numberToTextInstance.enletras(_remission.Total.ToString());
            _remissionSaveModel.Client = _client;
            //Sum(Fields!Total.Value, "Bill") - Sum(Fields!Total.Value, "BillTaxes")
            //_bill.SubTotal = _bill.Total - _billTaxes.Sum(x => x.Total);
            _remissionSaveModel.Remission = _remission;
            _remissionSaveModel.RemissionDetail = _remissionDetail;
            //_remissionSaveModel.BillTaxes = _billTaxes;
            string fileTemplatePath = "ThermalPrinterRemissionTemplate.txt";
            string printerName = System.Configuration.ConfigurationSettings.AppSettings["ThermalPrinterName"].ToString();
            ThermalPrinterHelper thermalPrinter = new ThermalPrinterHelper(printerName, fileTemplatePath);
            thermalPrinter.printRemission(_remissionSaveModel);
            NewRemission();
        }

        private void MarketModeConfig()
        {
            if (cmbTipoIdentificacion.Items.Count > 0)
            {
                IdentificationTypeModel idTemp = _billData.GetIdentificationType().Find(x => x.Description.ToUpper().Equals("CC"));
                cmbTipoIdentificacion.SelectedValue = idTemp.Id;
                txtIdentificacionCliente.Text = "0";
                _client = _billData.GetClient(new ClientModel
                {
                    IdIdentificationType = (Guid)cmbTipoIdentificacion.SelectedValue,
                    IdentificationNumber = txtIdentificacionCliente.Text,
                    Name = txtNombreCliente.Text
                });

                if (_client != null)
                {
                    _remission.IdClient = _client.Id;
                    txtNombreCliente.Text = _client.Name;
                    txtDireccion.Text = _client.Adress;
                    txtEmail.Text = _client.Email;
                    txtDescuentoCliente.Text = _client.DiscountPercent.ToString();
                    txtTelefono.Text = _client.Phone;
                    txtIdentificacionCliente.Text = _client.IdentificationNumber;
                    cmbTipoIdentificacion.SelectedValue = _client.IdIdentificationType;
                }
                else
                {
                    MessageBox.Show("No encontramos un cliente con los datos de búsqueda, verique que esten correctos o diligencie los datos para crear un nuevo cliente");
                }
            }
            else
            {
                MessageBox.Show("Error - Revise la configuración del sistema");
            }

            txtCodigoBarras.Focus();
        }

        private void txtCodigoBarras_Enter(object sender, EventArgs e)
        {
            txtNombreProducto.Text = string.Empty;
        }
        
        private void txtNombreProducto_Enter(object sender, EventArgs e)
        {
            txtCodigoBarras.Text = string.Empty;
        }
    }
}