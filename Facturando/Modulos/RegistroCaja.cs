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

namespace Facturando.Modulos
{
    public partial class RegistroCaja : BaseForm
    {
        List<CashBoxTypeModel> _cashBoxTypeModel = new List<CashBoxTypeModel>();
        CashBoxSaveModel _cashBox = new CashBoxSaveModel();
        int _typeRegister = 0;
      
        public RegistroCaja()
        {
            InitializeComponent();
        }

        public RegistroCaja(CashBoxSaveModel cashBox, List<CashBoxTypeModel> cashBoxType, int typeRegister)
        {
            InitializeComponent();
            _cashBoxTypeModel = cashBoxType;
            _cashBox = cashBox;
            _typeRegister = typeRegister;
        }

        private void btnGuardarRegistroCaja_Click(object sender, EventArgs e)
        {
            decimal newTotalTemp = decimal.Parse(txtValorCaja.Text);
            _cashBox.CashBox.Total = newTotalTemp;
            if (_typeRegister == 1) {
                _cashBox.CashBox.Comments = txtComentarios.Text;
            }
            _cashBox.CashBoxDetail.FirstOrDefault().Comments = txtComentarios.Text;
            _cashBox.CashBoxDetail.FirstOrDefault().IdCashBoxType = (Guid)cmbTipoRegistro.SelectedValue;
            _cashBox.CashBoxDetail.FirstOrDefault().Total = newTotalTemp;
            
            IFormCashBox formInterface = Owner.Controls.Find("Caja", true).FirstOrDefault() as IFormCashBox;
            if (formInterface != null)
            {
                formInterface.NewCashBox(_cashBox, _typeRegister);
            }
            Close();
        }

        private void RegistroCaja_Load(object sender, EventArgs e)
        {
            cmbTipoRegistro.DataSource = _cashBoxTypeModel;
            cmbTipoRegistro.ValueMember = "Id";
            cmbTipoRegistro.DisplayMember = "Description";
            txtValorCaja.Text = string.Format("{0:0.00}", 0.00);
            lblFechaMovimiento.Text = DateTime.Now.ToShortDateString();
            if (_typeRegister == 1)// valor inicial - apertura caja
            {
                cmbTipoRegistro.SelectedItem = _cashBoxTypeModel.FirstOrDefault(x => x.Description.ToLower().Equals("valor inicial"));
                cmbTipoRegistro.Enabled = false;
            }           
        }

        private void txtValorCaja_Leave(object sender, EventArgs e)
        {
            try
            {
                string decimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                Regex rex = new Regex(string.Concat("\\d+", decimalSeparator, "\\d+"));

                var isValid = rex.IsMatch(txtValorCaja.Text);

                if (!isValid)
                {
                    MessageBox.Show("Al parecer hay un valor equivocado en la los datos del porcentaje de descuento del cliente, revise nuevamente");
                    txtValorCaja.Focus();
                    return;
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
