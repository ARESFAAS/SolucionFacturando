using Facturando.Data;
using Facturando.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Facturando.Modulos
{
    public partial class AgregarEditarRegistroInventario : Form
    {
        InventoryInterface _data = new InventoryData();
        public InventorySaveModel Inventory { get; set; }
        public string Operation { get; set; }

        public AgregarEditarRegistroInventario()
        {
            InitializeComponent(); 
        }

        private void AgregarEditarRegistroInventario_Load(object sender, EventArgs e)
        {
            if (Operation.Equals("ENTRADA"))
            {
                lstTipoMovimiento.DataSource = _data.GetInventoryType("+");
            }
            else if (Operation.Equals("SALIDA"))
            {
                lstTipoMovimiento.DataSource = _data.GetInventoryType("-");
            }
            else
            {
                lstTipoMovimiento.DataSource = _data.GetInventoryType();
            }

            lstTipoMovimiento.DisplayMember = "Description";
            lstTipoMovimiento.ValueMember = "Id";
            lstClasificacion.DataSource = _data.GetInventoryClassification();
            lstClasificacion.ValueMember = "Id";
            lstClasificacion.DisplayMember = "Description";
            lstLocalizacion.DataSource = _data.GetyInventoryLocation();
            lstLocalizacion.ValueMember = "Id";
            lstLocalizacion.DisplayMember = "Description";
            lstProducto.DataSource = _data.GetProduct();
            lstProducto.DisplayMember = "Description";
            lstProducto.ValueMember = "Id";

            if (Operation.Equals("ENTRADA"))
            {
                lstTipoMovimiento.SelectedIndex = 0;
                lstClasificacion.SelectedIndex = 0;
                lstLocalizacion.SelectedIndex = 0;
                lstProducto.SelectedIndex = 0;
            }
            else
            {
                lstClasificacion.SelectedValue = Inventory.InventoryDetail.IdInventoryClassification;
                lstLocalizacion.SelectedValue = Inventory.InventoryDetail.IdInventoryLocalization;
                lstProducto.SelectedValue = Inventory.InventoryDetail.IdProduct;
                if (Operation.Equals("SALIDA"))
                {
                    Inventory.InventoryDetail.IdInventoryType = ((List<InventoryTypeModel>)lstTipoMovimiento.DataSource).FirstOrDefault().Id;
                    
                }
                lstTipoMovimiento.SelectedValue = Inventory.InventoryDetail.IdInventoryType;
                
            }

            if (Operation.Equals("SALIDA") || Operation.Equals("EDICION"))
            {
                lstProducto.Enabled = false;
            }
            
            txtCodigoBarras.Text = Inventory.InventoryDetail.BarCodeData;
            txtFechaVencimiento.Text = Inventory.InventoryDetail.DueDate.ToShortDateString();
            txtFechaFabricacion.Text = Inventory.InventoryDetail.ConstructDate.ToShortDateString();
            txtFechaIngreso.Text = Inventory.InventoryDetail.EventDate.ToShortDateString();
            txtCantidad.Text = Inventory.InventoryDetail.Quantity.ToString();
            txtPrecioCompra.Text = Inventory.InventoryDetail.PurchasePrice.ToString();
            txtPrecioVenta.Text = Inventory.InventoryDetail.SalePrice.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Inventory.Inventory.IdProduct = (Guid)lstProducto.SelectedValue;
            Inventory.InventoryDetail.BarCodeData = txtCodigoBarras.Text;
            Inventory.InventoryDetail.IdProduct = (Guid)lstProducto.SelectedValue;
            Inventory.InventoryDetail.IdInventoryType = (Guid)lstTipoMovimiento.SelectedValue;

            try
            {
                Inventory.InventoryDetail.DueDate = DateTime.Parse(txtFechaVencimiento.Text);
                Inventory.InventoryDetail.ConstructDate = DateTime.Parse(txtFechaFabricacion.Text);
                Inventory.InventoryDetail.EventDate = DateTime.Parse(txtFechaIngreso.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Al parecer hay un valor equivocado en la los datos de fechas, revise nuevamente");
                return;
            }

            try
            {
                Inventory.InventoryDetail.Quantity = int.Parse(txtCantidad.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Al parecer hay un valor equivocado en la los datos de la cantidad, revise nuevamente");
                return;
            }

            Inventory.InventoryDetail.IdInventoryClassification = (Guid)lstClasificacion.SelectedValue;
            Inventory.InventoryDetail.IdInventoryLocalization = (Guid)lstLocalizacion.SelectedValue;

            try
            {
                string decimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                Regex rex = new Regex(string.Concat("\\d+",decimalSeparator,"\\d+"));

                var isValid = rex.IsMatch(txtPrecioCompra.Text);
                var isValid2 = rex.IsMatch(txtPrecioVenta.Text);

                if (isValid && isValid2)
                {
                    Inventory.InventoryDetail.PurchasePrice = decimal.Parse(txtPrecioCompra.Text);
                    Inventory.InventoryDetail.SalePrice = decimal.Parse(txtPrecioVenta.Text);
                }
                else
                {
                    MessageBox.Show("Al parecer hay un valor equivocado en la los datos de valor de compra o venta, revise nuevamente");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Al parecer hay un valor equivocado en la los datos de valor de compra o venta, revise nuevamente");
                return;
            }        
            
            if (Operation.Equals("EDICION"))
            {
                Inventory = _data.UpdateInventory(Inventory);
            }
            else
            {
                Inventory = _data.SaveInventory(Inventory);
            }
            IFormInventory formInterface = this.Owner.Controls.Find("Inventario", true).FirstOrDefault() as IFormInventory;

            if (formInterface != null)
            {
                formInterface.UpdateInventoryInfo(Inventory);
            }
            this.Close();
        }
    }
}