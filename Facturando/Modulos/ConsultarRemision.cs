using Facturando.Data;
using Facturando.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Facturando.Modulos
{
    public partial class ConsultarRemision : BaseForm
    {
        IRemission _remissionData = new RemissionData();
        List<RemissionModel> _remissionModified = new List<RemissionModel>();

        public ConsultarRemision()
        {
            InitializeComponent();
        }

        private void ConsultarRemision_Load(object sender, EventArgs e)
        {

        }

        private void txtRemision_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtRemision.Text))
                {
                    long billNumberTemp = 0;
                    var isValid = long.TryParse(txtRemision.Text, out billNumberTemp);

                    if (!isValid)
                    {
                        MessageBox.Show("Al parecer hay un valor equivocado en la los datos del número de remisión, revise nuevamente");
                        txtRemision.Focus();
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<RemissionModel> listRemission = null;
            _remissionModified = new List<RemissionModel>();
            if (!string.IsNullOrEmpty(txtRemision.Text))
            {
                var remissionNumberTemp = long.Parse(txtRemision.Text);
                listRemission = _remissionData.GetRemissionList(remissionNumberTemp, string.Empty, null, null);
            }
            if (listRemission == null && !string.IsNullOrEmpty(txtIdentificacion.Text))
            {
                listRemission = _remissionData.GetRemissionList(0, txtIdentificacion.Text, null, null);
            }
            if (listRemission == null)
            {
                listRemission = _remissionData.GetRemissionList(0, string.Empty, dtpDesde.Value, dtpFin.Value);
            }
            if (listRemission != null)
            {
                dtgRemision.DataSource = listRemission;
            }
        }

        private void dtgRemision_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var remissionTemp = ((List<RemissionModel>)senderGrid.DataSource)[e.RowIndex];
                ConverseNumberToText numberToTextInstance = new ConverseNumberToText();
                remissionTemp.TotalInLetters = numberToTextInstance.enletras(remissionTemp.Total.ToString());
               
                if (System.Configuration.ConfigurationSettings.AppSettings["PrintFormat"].ToString().ToUpper().Equals("CARTA"))
                {
                    VisorRemision visorRemision = new VisorRemision(_remissionData.GetRemissionData(remissionTemp), true);
                    visorRemision.Show(this);
                }
                else if (System.Configuration.ConfigurationSettings.AppSettings["PrintFormat"].ToString().ToUpper().Equals("MEDIACARTAVERTICAL"))
                {
                    VisorRemisionMediaCartaVertical visorFactura = new VisorRemisionMediaCartaVertical(_remissionData.GetRemissionData(remissionTemp), true);
                    visorFactura.Show(this);
                }
                else
                {
                    VisorRemisionMediaCarta visorRemision = new VisorRemisionMediaCarta(_remissionData.GetRemissionData(remissionTemp), true);
                    visorRemision.Show(this);
                }
            }
        }

        private void dtgRemision_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dtgRemision_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn &&
                e.RowIndex >= 0)
            {
                var remissionTemp = ((List<RemissionModel>)senderGrid.DataSource)[e.RowIndex];
                var remissionValidate = _remissionModified.Where(x => x.Id == remissionTemp.Id).FirstOrDefault();
                if (remissionValidate != null)
                {
                    _remissionModified.Where(x => x.Id == remissionTemp.Id).FirstOrDefault().IsPaid = remissionTemp.IsPaid;
                }
                else
                {
                    _remissionModified.Add(remissionTemp);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dtgRemision.DataSource = _remissionData.EditRemission(_remissionModified);
            _remissionModified = new List<RemissionModel>();
        }
    }
}
