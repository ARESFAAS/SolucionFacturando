using Facturando.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturando.Modelos;
using System.Text.RegularExpressions;
using System.Threading;

namespace Facturando.Modulos
{
    public partial class Caja : BaseForm, IFormCashBox
    {
        ICashBox _cashBoxData = new CashBoxData();
        IBill _billData = new BillData();
        IRemission _remissionData = new RemissionData();
        CashBoxModel _cashBox = new CashBoxModel();
        List<CashBoxDetailModel> _cashBoxDetail = new List<CashBoxDetailModel>();
        CashBoxSaveModel _cashBoxSaveModel = new CashBoxSaveModel();
        List<CashBoxTypeModel> _cashBoxType = new List<CashBoxTypeModel>();
        List<CashBoxModel> _cashBoxList = new List<CashBoxModel>();

        public Caja()
        {
            InitializeComponent();
        }

        public Caja(UserModel user)
        {
            InitializeComponent();
            base.User = user;
        }

        private void Caja_Load(object sender, EventArgs e)
        {
            _cashBoxType = _cashBoxData.GetCashBoxType();
            _cashBoxList = _cashBoxData.GetCashBoxList();
            dtgCaja.DataSource = _cashBoxList;
            _cashBox = _cashBoxList.Where(x => !x.IsClosed).FirstOrDefault();
            if (_cashBox != null)
            {
                if (_cashBox.OpenDate.HasValue)
                {
                    _cashBoxDetail = _cashBoxData.GetCashBoxDetailList(_cashBox);
                    dtgCajaDetalle.DataSource = _cashBoxDetail;
                    LoadCurrentCashBoxValues(DateTime.Now);
                    LoadCashBalance();
                }
            }
            else
            {
                lblDiferencia.Text = string.Format("{0:0.00}", 0.00);
                lblTotalFacturas.Text = string.Format("{0:0.00}", 0.00);
                lblTotalRemisiones.Text = string.Format("{0:0.00}", 0.00);
                lblTotalCaja.Text = string.Format("{0:0.00}", 0.00);
                txtCash.Text = string.Format("{0:0.00}", 0.00);
                txtMediosPago.Text = string.Format("{0:0.00}", 0.00);
            }
        }

        private void AbrirCaja_Click(object sender, EventArgs e)
        {
            _cashBox = new CashBoxModel
            {
                Id = Guid.NewGuid(),
                OpenDate = DateTime.Now,
                CloseDate = null,
                IsClosed = false,
                Total = 0,
                Comments = string.Empty,
                IdUser = base.User.Id
            };
            _cashBoxDetail = new List<CashBoxDetailModel>();
            _cashBoxDetail.Add(new CashBoxDetailModel
            {
                Id = Guid.NewGuid(),
                IdCashBox = _cashBox.Id,
                MovementDate = DateTime.Now,
                Total = 0
            });
            _cashBoxSaveModel = new CashBoxSaveModel
            {
                CashBox = _cashBox,
                CashBoxDetail = _cashBoxDetail
            };
            RegistroCaja registroCaja = new RegistroCaja(_cashBoxSaveModel, _cashBoxType, 1);
            registroCaja.Show(this);
        }

        public void NewCashBox(CashBoxSaveModel cashBox, int typeRegister)
        {
            if (typeRegister == 1) //valor inicial - apertura
            {
                bool validateCashBox = _cashBoxData.CashBoxExistsValidate(base.User);
                if (!validateCashBox)
                {
                    SaveCashBox(cashBox);
                    //ClearControls();
                }
                else {
                    MessageBox.Show("!!No puede abrir una nueva caja hasta que no cierre la anterior!!!");                   
                    return;
                }
            }
            if (typeRegister == 2) //mover caja
            {
                if (!cashBox.CashBox.IsClosed)
                {
                    SaveCashBox(cashBox);
                    //ClearControls();
                }
                else
                {
                    MessageBox.Show("!!No puede mover esta caja porque ya está cerrada!!!");
                    return;
                }
            }
        }

        private void SaveCashBox(CashBoxSaveModel cashBox) {
            _cashBoxData.SaveCashBox(cashBox);
            _cashBoxList = _cashBoxData.GetCashBoxList();
            dtgCaja.DataSource = _cashBoxList;
            _cashBoxDetail = _cashBoxData.GetCashBoxDetailList(cashBox.CashBox);
            dtgCajaDetalle.DataSource = _cashBoxDetail;
            LoadCurrentCashBoxValues(cashBox.CashBox.OpenDate.Value);
            LoadCashBalance();
        }

        private void ClearControls() {
            _cashBoxDetail = new List<CashBoxDetailModel>();
            dtgCajaDetalle.DataSource = _cashBoxDetail;
            lblDiferencia.Text = string.Format("{0:0.00}", 0.00);
            lblTotalFacturas.Text = string.Format("{0:0.00}", 0.00);
            lblTotalRemisiones.Text = string.Format("{0:0.00}", 0.00);
            lblTotalCaja.Text = string.Format("{0:0.00}", 0.00);
            txtCash.Text = string.Format("{0:0.00}", 0.00);
            txtMediosPago.Text = string.Format("{0:0.00}", 0.00);
        }

        private void dtgCaja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            var senderGrid = (DataGridView)sender;
            var cashBoxTemp = ((List<CashBoxModel>)senderGrid.DataSource)[e.RowIndex];
            if (!cashBoxTemp.IsClosed)
            {
                LoadCashBalance();

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Name.Equals("EditCashBox"))
                {
                    var cashBoxDetailTemp = new List<CashBoxDetailModel>();
                    var cashBoxTypeTemp = _cashBoxType.Where(x => !x.Description.ToLower().Equals("valor inicial")).ToList();
                    cashBoxDetailTemp.Add(new CashBoxDetailModel
                    {
                        Id = Guid.NewGuid(),
                        IdCashBox = cashBoxTemp.Id,
                        MovementDate = DateTime.Now,
                        Total = 0
                    });
                    var cashBoxSaveTemp = new CashBoxSaveModel
                    {
                        CashBox = cashBoxTemp,
                        CashBoxDetail = cashBoxDetailTemp
                    };
                    RegistroCaja registroCaja = new RegistroCaja(cashBoxSaveTemp, cashBoxTypeTemp, 2);
                    registroCaja.Show(this);
                }
                else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Name.Equals("CloseCashBox"))
                {
                    _cashBoxDetail = _cashBoxData.GetCashBoxDetailList(cashBoxTemp);
                    dtgCajaDetalle.DataSource = _cashBoxDetail;
                    LoadCurrentCashBoxValues(cashBoxTemp.OpenDate.Value);
                    LoadCashBalance();
                    if (decimal.Parse(lblDiferencia.Text.Replace("$", "")) > 0 || decimal.Parse(lblDiferencia.Text.Replace("$", "")) < 0)
                    {
                        DialogResult resultValidation = MessageBox.
                            Show("Esta seguro ?, La casilla diferencia debe ser 0.00, revise los movimentos de caja, factura y el total de efectivo y otros pagos", string.Empty, MessageBoxButtons.OKCancel);
                        if (resultValidation == DialogResult.OK)
                        {
                            DialogResult resultValidation2 = MessageBox.Show("Está seguro, los datos se guardarán?", string.Empty, MessageBoxButtons.OKCancel);
                            if (resultValidation2 == DialogResult.OK)
                            {
                                cashBoxTemp.CloseTotal = decimal.Parse(txtCash.Text);
                                _cashBoxData.CloseCashBox(cashBoxTemp);
                                ClearControls();
                                _cashBoxList = _cashBoxData.GetCashBoxList();
                                dtgCaja.DataSource = _cashBoxList;
                            }
                        }
                    }
                    else
                    {
                        DialogResult resultValidation3 = MessageBox.Show("Está seguro, los datos se guardarán?", string.Empty, MessageBoxButtons.OKCancel);
                        if (resultValidation3 == DialogResult.OK)
                        {
                            cashBoxTemp.CloseTotal = decimal.Parse(txtCash.Text);
                            _cashBoxData.CloseCashBox(cashBoxTemp);
                            ClearControls();
                            _cashBoxList = _cashBoxData.GetCashBoxList();
                            dtgCaja.DataSource = _cashBoxList;
                        }
                    }
                }
            }
            else {
                MessageBox.Show("No puede cargar estos datos, esta caja ya está cerrada");
            }            
        }

        private void dtgCaja_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtgCaja.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgCaja.SelectedRows[0];
                _cashBox = (CashBoxModel)row.DataBoundItem;
                if (!_cashBox.IsClosed)
                {
                    _cashBoxDetail = _cashBoxData.GetCashBoxDetailList(_cashBox);
                    dtgCajaDetalle.DataSource = _cashBoxDetail;
                    LoadCurrentCashBoxValues(_cashBox.OpenDate.Value);
                    LoadCashBalance();
                }
                else {
                    MessageBox.Show("No puede cargar estos datos, esta caja ya está cerrada");
                }
                //if (!string.IsNullOrEmpty(txtDesde.Text) && !string.IsNullOrEmpty(txtHasta.Text))
                //{
                //    DateTime initDate;
                //    DateTime endDate;
                //    if (DateTime.TryParse(txtDesde.Text, out initDate) && DateTime.TryParse(txtHasta.Text, out endDate))
                //    {
                //        dataGridView1.DataSource = _inventory.GetInventoryDetail(_inventoryModelTemp.IdProduct, initDate, endDate, lstTipoMovimiento.SelectedValue.ToString());
                //    }
                //    else
                //    {
                //        dataGridView1.DataSource = _inventory.GetInventoryDetail(_inventoryModelTemp.IdProduct);
                //    }
                //}
                //else
                //{
                //    dataGridView1.DataSource = _inventory.GetInventoryDetail(_inventoryModelTemp.IdProduct);
                //}
            }
        }       

        private void txtCash_Leave(object sender, EventArgs e)
        {
            try
            {
                string decimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                Regex rex = new Regex(string.Concat("\\d+", decimalSeparator, "\\d+"));

                var isValid = rex.IsMatch(txtCash.Text);

                if (!isValid)
                {
                    MessageBox.Show("Al parecer hay un valor equivocado en el valor de efectivo, revise nuevamente");
                    txtCash.Focus();
                    return;
                }
                else {
                    LoadCashBalance();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                return;
            }
        }        

        private void txtMediosPago_Leave(object sender, EventArgs e)
        {
            try
            {
                string decimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                Regex rex = new Regex(string.Concat("\\d+", decimalSeparator, "\\d+"));

                var isValid = rex.IsMatch(txtMediosPago.Text);

                if (!isValid)
                {
                    MessageBox.Show("Al parecer hay un valor equivocado en el valor total de otros medios de pago, revise nuevamente");
                    txtMediosPago.Focus();
                    return;
                }
                else
                {
                    LoadCashBalance();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                return;
            }
        }

        private void LoadCurrentCashBoxValues(DateTime dateToValidate)
        {
            decimal totalBill = _billData.GetBillTotal(base.User.Id, dateToValidate);
            decimal totalRemission = _remissionData.GetRemisionTotal(base.User.Id, dateToValidate);
            decimal totalMovement = 0;
            lblTotalFacturas.Text = string.Format("{0:0.00}", totalBill);
            lblTotalRemisiones.Text = string.Format("{0:0.00}", totalRemission);
            foreach (var item in _cashBoxDetail)
            {
                if (item.Sign.Equals("+"))
                {
                    totalMovement += item.Total;
                }
                else
                {
                    totalMovement -= item.Total;
                }
            }
            lblTotalCaja.Text = string.Format("{0:0.00}", totalMovement);
        }

        private void LoadCashBalance()
        {
            decimal balance = 0;
            decimal totalBill = 0;
            decimal totalRemission = 0;
            decimal totalSales = 0;
            decimal.TryParse(lblTotalFacturas.Text, out totalBill);
            decimal.TryParse(lblTotalRemisiones.Text, out totalRemission);
            decimal totalMovement = 0;
            decimal.TryParse(lblTotalCaja.Text, out totalMovement);
            decimal totalCash = 0;
            decimal.TryParse(txtCash.Text, out totalCash);
            decimal totalOtherPayments = 0;
            decimal.TryParse(txtMediosPago.Text, out totalOtherPayments);
            totalSales = totalBill + totalRemission;
            //balance = totalSales - (totalCash + totalOtherPayments - totalMovement);
            balance = (totalCash + totalOtherPayments - totalMovement) - totalSales;
            //lblDiferencia.Text = balance.ToString("C", new System.Globalization.CultureInfo("es-EC"));
            lblDiferencia.Text = string.Format("{0:0.00}", balance);
            if (decimal.Parse(lblDiferencia.Text.Replace("$", "")) > 0 || decimal.Parse(lblDiferencia.Text.Replace("$", "")) < 0)
            {
                txtObservaciones.Text = "La casilla diferencia debe ser 0.00, revise los movimentos de caja, factura y el total de efectivo y otros pagos";
            }
            else {
                txtObservaciones.Text = string.Empty;
            }
        }
    }
}
