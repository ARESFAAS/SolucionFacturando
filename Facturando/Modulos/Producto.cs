using Facturando.Data;
using Facturando.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Facturando.Modulos
{
    public partial class Producto : BaseForm
    {
        IProduct _productData = new ProductData();
        IConfiguration _configurationData = new ConfigurationData();
        ProductModel _product = new ProductModel();

        public Producto()
        {
            InitializeComponent();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            lstUnidadMedida.DataSource = _configurationData.GetUnitMeasureList();
            lstUnidadMedida.ValueMember = "Id";
            lstUnidadMedida.DisplayMember = "Description";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dtgProducto.DataSource = _productData.GetProduct(new ProductModel { Description = txtNombreProducto.Text });
        }

        private void dtgProducto_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _product = (ProductModel)(((List<ProductModel>)dtgProducto.DataSource))[e.RowIndex];
            txtDescripción.Text = _product.Description;
            lstUnidadMedida.SelectedValue = _product.IdUnit;
            checkBox1.Checked = _product.FreeProduct;
            checkBox2.Checked = _product.Active;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_product.Id == Guid.Empty)
            {
                MessageBox.Show("No ha seleccionado un producto para editar");
            }
            else
            {
                _product.Description = txtDescripción.Text;
                _product.IdUnit = (Guid)lstUnidadMedida.SelectedValue;
                _product.DescriptionUnit = lstUnidadMedida.Text;
                _product.FreeProduct = checkBox1.Checked;
                _product.Active = checkBox2.Checked;
                dtgProducto.DataSource = _productData.SaveProduct(_product);
            }
            _product = new ProductModel();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescripción.Text))
            {
                if (lstUnidadMedida.Items.Count > 0)
                {
                    _product = new ProductModel
                    {
                        Id = Guid.NewGuid(),
                        Description = txtDescripción.Text,
                        IdUnit = (Guid)lstUnidadMedida.SelectedValue,
                        DescriptionUnit = lstUnidadMedida.Text,
                        FreeProduct = checkBox1.Checked,
                        Active = checkBox2.Checked
                    };
                    dtgProducto.DataSource = _productData.SaveProduct(_product);
                }
                else
                {
                    btnAgregar.Enabled = false;
                    MessageBox.Show("Error - revise la configuración del sistema");
                }
            }
            else {
                MessageBox.Show("No ha ingresado ningún dato en la descripción del producto");
            }
            _product = new ProductModel();
        }
    }
}
