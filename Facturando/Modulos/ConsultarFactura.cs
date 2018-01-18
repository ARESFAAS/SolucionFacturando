using Facturando.Data;
using Facturando.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Facturando.Modulos
{
    public partial class ConsultarFactura : BaseForm
    {
        IBill _billData = new BillData();
        List<BillModel> _billModified = new List<BillModel>();
        
        public ConsultarFactura()
        {
            InitializeComponent();
        }

        private void ConsultarFactura_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<BillModel> listBill = null;
            _billModified = new List<BillModel>();
            if (!string.IsNullOrEmpty(txtFactura.Text))
            {
                var billNumberTemp = long.Parse(txtFactura.Text);
                listBill = _billData.GetBillList(billNumberTemp, string.Empty, null, null);
            }
            if (listBill == null && !string.IsNullOrEmpty(txtIdentificacion.Text))
            {
                listBill = _billData.GetBillList(0, txtIdentificacion.Text, null, null);
            }
            if (listBill == null)
            {
                listBill = _billData.GetBillList(0, string.Empty, dtpDesde.Value, dtpFin.Value);
            }
            if (listBill != null)
            {
                dtgFactura.DataSource = listBill;
            }
        }

        private void dtgFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var billTemp = ((List<BillModel>)senderGrid.DataSource)[e.RowIndex];
                ConverseNumberToText numberToTextInstance = new ConverseNumberToText();
                billTemp.TotalInLetters = numberToTextInstance.enletras(billTemp.Total.ToString());

                if (System.Configuration.ConfigurationSettings.AppSettings["PrintFormat"].ToString().ToUpper().Equals("CARTA"))
                {
                    VisorFactura visorFactura = new VisorFactura(_billData.GetBillData(billTemp), true);
                    visorFactura.Show(this);
                }
                else if (System.Configuration.ConfigurationSettings.AppSettings["PrintFormat"].ToString().ToUpper().Equals("MEDIACARTAVERTICAL"))
                {
                    VisorFacturaMediaCartaVertical visorFactura = new VisorFacturaMediaCartaVertical(_billData.GetBillData(billTemp), true);
                    visorFactura.Show(this);
                }
                else if (System.Configuration.ConfigurationSettings.AppSettings["PrintFormat"].ToString().ToUpper().Equals("A5VERTICAL"))
                {
                    VisorFacturaA5 visorFactura = new VisorFacturaA5(_billData.GetBillData(billTemp), true);
                    visorFactura.Show(this);
                }
                else
                {
                    VisorFacturaMediaCarta visorFactura = new VisorFacturaMediaCarta(_billData.GetBillData(billTemp), true);
                    visorFactura.Show(this);
                }
            }            
        }

        private void dtgFactura_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn &&
                e.RowIndex >= 0)
            {
                var billTemp = ((List<BillModel>)senderGrid.DataSource)[e.RowIndex];
                var billValidate = _billModified.Where(x => x.Id == billTemp.Id).FirstOrDefault();
                if (billValidate != null)
                {
                    _billModified.Where(x => x.Id == billTemp.Id).FirstOrDefault().IsCanceled = billTemp.IsCanceled;
                    _billModified.Where(x => x.Id == billTemp.Id).FirstOrDefault().IsPaid = billTemp.IsPaid;
                }
                else
                {
                    _billModified.Add(billTemp);
                }
            }
        }

        private void dtgFactura_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dtgFactura.DataSource = _billData.EditBill(_billModified);
            _billModified = new List<BillModel>();
        }

        private void txtFactura_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtFactura.Text))
                {
                    long billNumberTemp = 0;
                    var isValid = long.TryParse(txtFactura.Text, out billNumberTemp);

                    if (!isValid)
                    {
                        MessageBox.Show("Al parecer hay un valor equivocado en la los datos del número de factura, revise nuevamente");
                        txtFactura.Focus();
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                return;
            }
        }
    }
}
