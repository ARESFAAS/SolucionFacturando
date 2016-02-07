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
    public partial class ConsultarFactura : Form
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
            if (listBill == null && string.IsNullOrEmpty(txtIdentificacion.Text))
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
                VisorFactura visorFactura = new VisorFactura(_billData.GetBillData(billTemp), true);
                visorFactura.Show();
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
            dtgFactura.DataSource = _billData.CancelBill(_billModified);
            _billModified = new List<BillModel>();
        }
    }
}
