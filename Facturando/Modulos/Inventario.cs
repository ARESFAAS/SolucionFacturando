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
            
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {            
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView2.SelectedRows[0];
                _inventoryModelTemp = (InventoryModel)row.DataBoundItem;
                dataGridView1.DataSource = _inventory.GetInventoryDetail(_inventoryModelTemp.IdProduct);
            }

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                _inventoryDetailTemp = (InventoryDetailModel)row.DataBoundItem;
            }
            else {
                _inventoryDetailTemp = null;                
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                _inventoryDetailTemp = (InventoryDetailModel)row.DataBoundItem;
                AgregarEditarRegistroInventario detalleInventario = new AgregarEditarRegistroInventario();
                detalleInventario.Operation = "EDICION";
                detalleInventario.Inventory = new InventorySaveModel
                {
                    Inventory = _inventoryModelTemp,
                    InventoryDetail = _inventoryDetailTemp
                };
                detalleInventario.Text = "Editar Registro de Inventario";
                detalleInventario.Show(this);
            }
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            _inventoryDetailTemp = new InventoryDetailModel();
            _inventoryDetailTemp.BarCodeData = textBox2.Text;
            _inventoryDetailTemp.ConstructDate = DateTime.Now;
            _inventoryDetailTemp.DueDate = DateTime.Now;
            _inventoryDetailTemp.EventDate = DateTime.Now;
            AgregarEditarRegistroInventario detalleInventario = new AgregarEditarRegistroInventario();
            detalleInventario.Operation = "ENTRADA";
            detalleInventario.Inventory = new InventorySaveModel
            {
                Inventory = _inventoryModelTemp,
                InventoryDetail = _inventoryDetailTemp
            };
            detalleInventario.Text = "Agregar Registro de Inventario";
            detalleInventario.Show(this);
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (_inventoryDetailTemp == null)
            {
                MessageBox.Show("No ha seleccionado ningun registro del detalle del inventario, seleccione un registro para grabar una salida");
            }
            else
            {
                if (!string.IsNullOrEmpty(_inventoryDetailTemp.Sign) && _inventoryDetailTemp.Sign.Equals("+"))
                {
                    AgregarEditarRegistroInventario detalleInventario = new AgregarEditarRegistroInventario();
                    detalleInventario.Operation = "SALIDA";
                    detalleInventario.Inventory = new InventorySaveModel
                    {
                        Inventory = _inventoryModelTemp,
                        InventoryDetail = _inventoryDetailTemp
                    };
                    detalleInventario.Text = "Agregar Registro de Inventario";
                    detalleInventario.Show(this);
                }
                else
                {
                    MessageBox.Show("seleccione un registro del inventario con signo + para poder grabar una salida");
                }
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = _inventory.GetInventory(txtCodigoBarras.Text, txtNombreProducto.Text);
            dataGridView1.DataSource = new List<InventoryDetailModel>();
        }

        public void UpdateInventoryInfo(InventorySaveModel inventory)
        {
            dataGridView1.DataSource = _inventory.GetInventoryDetail(inventory.InventoryDetail.Id, true);
            dataGridView2.DataSource = _inventory.GetInventory(inventory.Inventory.Id);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
