using Facturando.Data;
using Facturando.Modelos;
using Facturando.Modulos;
using System;
using System.Collections.Generic;
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
            List<InventoryTypeModel> listTypeTemp = new List<InventoryTypeModel>();
            listTypeTemp.Add(new InventoryTypeModel {
                Id = Guid.NewGuid(),
                Description = "Entrada",
                Sign = "+"
            });
            listTypeTemp.Add(new InventoryTypeModel
            {
                Id = Guid.NewGuid(),
                Description = "Salida",
                Sign = "-"
            });

            lstTipoMovimiento.DataSource = listTypeTemp;
            lstTipoMovimiento.ValueMember = "Sign";
            lstTipoMovimiento.DisplayMember = "Description";
            lstTipoMovimiento.SelectedIndex = 0;
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {            
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView2.SelectedRows[0];
                _inventoryModelTemp = (InventoryModel)row.DataBoundItem;
                if (!string.IsNullOrEmpty(txtDesde.Text) && !string.IsNullOrEmpty(txtHasta.Text))
                {
                    DateTime initDate;
                    DateTime endDate;
                    if (DateTime.TryParse(txtDesde.Text, out initDate) && DateTime.TryParse(txtHasta.Text, out endDate))
                    {
                        dataGridView1.DataSource = _inventory.GetInventoryDetail(_inventoryModelTemp.IdProduct, initDate, endDate, lstTipoMovimiento.SelectedValue.ToString());
                    }
                    else
                    {
                        dataGridView1.DataSource = _inventory.GetInventoryDetail(_inventoryModelTemp.IdProduct);
                    }
                }
                else
                {
                    dataGridView1.DataSource = _inventory.GetInventoryDetail(_inventoryModelTemp.IdProduct);
                }                
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

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            txtDesde.Text = dtpDesde.Value.ToString();
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            txtHasta.Text = dtpHasta.Value.ToString();
        }
    }
}
