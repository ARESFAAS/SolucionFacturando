using Facturando.Data;
using Facturando.Modelos;
using Facturando.Modulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturando
{
    public partial class Inventario : Form, IFormInventory
    {
        InventoryInterface _inventory = new InventoryData();
        InventoryDetailModel _inventoryDetailTemp = new InventoryDetailModel();
        InventoryModel _inventoryModelTemp = new InventoryModel();

        public Inventario()
        {
            InitializeComponent();            
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = _inventory.GetInventory();            
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.DataSource = _inventory.GetInventoryDetail();
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView2.SelectedRows[0];
                _inventoryModelTemp = (InventoryModel)row.DataBoundItem;
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _inventoryDetailTemp = new InventoryDetailModel();
            _inventoryDetailTemp.BarCodeData = textBox2.Text;
            _inventoryDetailTemp.ConstructDate = DateTime.Now;
            _inventoryDetailTemp.DueDate = DateTime.Now;
            _inventoryDetailTemp.EventDate = DateTime.Now;
            AgregarEditarRegistroInventario detalleInventario = new AgregarEditarRegistroInventario();
            detalleInventario.IsUpdate = false;            
            detalleInventario.Inventory = new InventorySaveModel
            {
                Inventory = _inventoryModelTemp,
                InventoryDetail = _inventoryDetailTemp
            };
            detalleInventario.Text = "Agregar Registro de Inventario";
            detalleInventario.Show(this);
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                _inventoryDetailTemp = (InventoryDetailModel)row.DataBoundItem;
                AgregarEditarRegistroInventario detalleInventario = new AgregarEditarRegistroInventario();
                detalleInventario.IsUpdate = true;
                detalleInventario.Inventory.InventoryDetail = _inventoryDetailTemp;
                detalleInventario.Text = "Editar Registro de Inventario";
                detalleInventario.Show();
            }
        }

        public void UpdateInventoryInfo(InventorySaveModel inventory)
        {
            dataGridView1.DataSource = _inventory.GetInventoryDetail();
            dataGridView2.DataSource = _inventory.GetInventory();
        }
    }
}
