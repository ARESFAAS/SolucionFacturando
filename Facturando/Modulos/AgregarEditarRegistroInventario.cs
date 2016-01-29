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
    public partial class AgregarEditarRegistroInventario : Form
    {
        public InventorySaveModel Inventory { get; set; }
        public bool IsUpdate { get; set; }

        public AgregarEditarRegistroInventario()
        {
            InitializeComponent(); 
        }

        private void AgregarEditarRegistroInventario_Load(object sender, EventArgs e)
        {
            InventoryInterface data = new InventoryData();
            lstTipoMovimiento.DataSource = data.GetInventoryType();
            lstTipoMovimiento.DisplayMember = "Description";
            lstTipoMovimiento.ValueMember = "Id";
            lstClasificacion.DataSource = data.GetInventoryClassification();
            lstClasificacion.ValueMember = "Id";
            lstClasificacion.DisplayMember = "Description";
            lstLocalizacion.DataSource = data.GetyInventoryLocation();
            lstLocalizacion.ValueMember = "Id";
            lstLocalizacion.DisplayMember = "Description";
            lstProducto.DataSource = data.GetProduct();
            lstProducto.DisplayMember = "Description";
            lstProducto.ValueMember = "Id";

            txtCodigoBarras.Text = Inventory.InventoryDetail.BarCodeData;
            lstProducto.SelectedValue = Inventory.InventoryDetail.IdProduct;
            lstTipoMovimiento.SelectedValue = Inventory.InventoryDetail.IdInventoryType;
            txtFechaVencimiento.Text = Inventory.InventoryDetail.DueDate.ToShortDateString();
            txtFechaFabricacion.Text = Inventory.InventoryDetail.ConstructDate.ToShortDateString();
            txtFechaIngreso.Text = Inventory.InventoryDetail.EventDate.ToShortDateString();
            txtCantidad.Text = Inventory.InventoryDetail.Quantity.ToString();
            lstClasificacion.SelectedValue = Inventory.InventoryDetail.IdInventoryClassification;
            lstLocalizacion.SelectedValue = Inventory.InventoryDetail.IdInventoryLocalization;
            txtPrecioCompra.Text = Inventory.InventoryDetail.PurchasePrice.ToString();
            txtPrecioVenta.Text = Inventory.InventoryDetail.SalePrice.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InventoryInterface data = new InventoryData();

            Inventory.Inventory.IdProduct = (Guid)lstProducto.SelectedValue;
            Inventory.InventoryDetail.BarCodeData = txtCodigoBarras.Text;
            Inventory.InventoryDetail.IdProduct = (Guid)lstProducto.SelectedValue;
            Inventory.InventoryDetail.IdInventoryType = (Guid)lstTipoMovimiento.SelectedValue;
            Inventory.InventoryDetail.DueDate = DateTime.Parse(txtFechaVencimiento.Text);
            Inventory.InventoryDetail.ConstructDate = DateTime.Parse(txtFechaFabricacion.Text);
            Inventory.InventoryDetail.EventDate = DateTime.Parse(txtFechaIngreso.Text);
            Inventory.InventoryDetail.Quantity = int.Parse(txtCantidad.Text);
            Inventory.InventoryDetail.IdInventoryClassification = (Guid)lstClasificacion.SelectedValue;
            Inventory.InventoryDetail.IdInventoryLocalization = (Guid)lstLocalizacion.SelectedValue;
            try
            {
                Inventory.InventoryDetail.PurchasePrice = decimal.Parse(txtPrecioCompra.Text);
                Inventory.InventoryDetail.SalePrice = decimal.Parse(txtPrecioVenta.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Al parecer hay un valor equivocado en la los datos de valor de compra o venta, revise nuevamente");
            }            
            
            if (IsUpdate)
            {
                Inventory = data.UpdateInventory(Inventory);
            }
            else
            {
                Inventory = data.SaveInventory(Inventory);
            }
            IFormInventory formInterface = this.Owner.Controls.Find("Inventario", true).FirstOrDefault() as IFormInventory;

            if (formInterface != null)
                formInterface.UpdateInventoryInfo(Inventory);
            this.Close();
        }
    }
}
