namespace Facturando
{
    partial class Inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.IdDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdInventoryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProductDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConstructDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCodeData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdInventoryClassification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassificationDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdInventoryLocalization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalizationDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Agregar Registro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDetalle,
            this.IdInventory,
            this.IdInventoryType,
            this.IdProductDetail,
            this.ProductDetail,
            this.InventoryDescription,
            this.QuantityDescription,
            this.EventDate,
            this.ConstructDate,
            this.DueDate,
            this.BarCodeData,
            this.IdInventoryClassification,
            this.ClassificationDescription,
            this.IdInventoryLocalization,
            this.LocalizationDescription,
            this.PurchasePrice,
            this.SalePrice});
            this.dataGridView1.Location = new System.Drawing.Point(12, 299);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1297, 493);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Id,
            this.IdProduct,
            this.Quantity});
            this.dataGridView2.Location = new System.Drawing.Point(330, 39);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(979, 140);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese el codigo de barras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese el código de barras o deje el campo en blanco:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 242);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 20);
            this.textBox2.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1234, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ingrese Nombre de Producto:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(242, 20);
            this.textBox3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Existencias Actuales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Detalle de movimientos";
            // 
            // Product
            // 
            this.Product.DataPropertyName = "Product";
            this.Product.HeaderText = "Producto";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // IdProduct
            // 
            this.IdProduct.DataPropertyName = "IdProduct";
            this.IdProduct.HeaderText = "IdProduct";
            this.IdProduct.Name = "IdProduct";
            this.IdProduct.ReadOnly = true;
            this.IdProduct.Visible = false;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Cantidad";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(330, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Agregar Registro";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button2_Click);
            // 
            // IdDetalle
            // 
            this.IdDetalle.DataPropertyName = "Id";
            this.IdDetalle.HeaderText = "IdDetalle";
            this.IdDetalle.Name = "IdDetalle";
            this.IdDetalle.ReadOnly = true;
            this.IdDetalle.Visible = false;
            // 
            // IdInventory
            // 
            this.IdInventory.DataPropertyName = "IdInventory";
            this.IdInventory.HeaderText = "IdInventory";
            this.IdInventory.Name = "IdInventory";
            this.IdInventory.ReadOnly = true;
            this.IdInventory.Visible = false;
            // 
            // IdInventoryType
            // 
            this.IdInventoryType.DataPropertyName = "IdInventoryType";
            this.IdInventoryType.HeaderText = "IdInventoryType";
            this.IdInventoryType.Name = "IdInventoryType";
            this.IdInventoryType.ReadOnly = true;
            this.IdInventoryType.Visible = false;
            // 
            // IdProductDetail
            // 
            this.IdProductDetail.DataPropertyName = "IdProduct";
            this.IdProductDetail.HeaderText = "IdProductDetail";
            this.IdProductDetail.Name = "IdProductDetail";
            this.IdProductDetail.ReadOnly = true;
            this.IdProductDetail.Visible = false;
            // 
            // ProductDetail
            // 
            this.ProductDetail.DataPropertyName = "Product";
            this.ProductDetail.HeaderText = "Producto";
            this.ProductDetail.Name = "ProductDetail";
            this.ProductDetail.ReadOnly = true;
            // 
            // InventoryDescription
            // 
            this.InventoryDescription.DataPropertyName = "InventoryDescription";
            this.InventoryDescription.HeaderText = "Descripcion";
            this.InventoryDescription.Name = "InventoryDescription";
            this.InventoryDescription.ReadOnly = true;
            // 
            // QuantityDescription
            // 
            this.QuantityDescription.DataPropertyName = "Quantity";
            this.QuantityDescription.HeaderText = "Cantidad";
            this.QuantityDescription.Name = "QuantityDescription";
            this.QuantityDescription.ReadOnly = true;
            // 
            // EventDate
            // 
            this.EventDate.DataPropertyName = "EventDate";
            this.EventDate.HeaderText = "Fecha Ingreso";
            this.EventDate.Name = "EventDate";
            this.EventDate.ReadOnly = true;
            // 
            // ConstructDate
            // 
            this.ConstructDate.DataPropertyName = "ConstructDate";
            this.ConstructDate.HeaderText = "Fecha Fabricación";
            this.ConstructDate.Name = "ConstructDate";
            this.ConstructDate.ReadOnly = true;
            // 
            // DueDate
            // 
            this.DueDate.DataPropertyName = "DueDate";
            this.DueDate.HeaderText = "Fecha Vencimiento";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            // 
            // BarCodeData
            // 
            this.BarCodeData.DataPropertyName = "BarCodeData";
            this.BarCodeData.HeaderText = "Codigo Barras";
            this.BarCodeData.Name = "BarCodeData";
            this.BarCodeData.ReadOnly = true;
            // 
            // IdInventoryClassification
            // 
            this.IdInventoryClassification.DataPropertyName = "IdInventoryClassification";
            this.IdInventoryClassification.HeaderText = "IdInventoryClassification";
            this.IdInventoryClassification.Name = "IdInventoryClassification";
            this.IdInventoryClassification.ReadOnly = true;
            this.IdInventoryClassification.Visible = false;
            // 
            // ClassificationDescription
            // 
            this.ClassificationDescription.DataPropertyName = "ClassificationDescription";
            this.ClassificationDescription.HeaderText = "Clasificacion";
            this.ClassificationDescription.Name = "ClassificationDescription";
            this.ClassificationDescription.ReadOnly = true;
            // 
            // IdInventoryLocalization
            // 
            this.IdInventoryLocalization.DataPropertyName = "IdInventoryLocalization";
            this.IdInventoryLocalization.HeaderText = "IdInventoryLocation";
            this.IdInventoryLocalization.Name = "IdInventoryLocalization";
            this.IdInventoryLocalization.ReadOnly = true;
            this.IdInventoryLocalization.Visible = false;
            // 
            // LocalizationDescription
            // 
            this.LocalizationDescription.DataPropertyName = "LocalizationDescription";
            this.LocalizationDescription.HeaderText = "Localización";
            this.LocalizationDescription.Name = "LocalizationDescription";
            this.LocalizationDescription.ReadOnly = true;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.DataPropertyName = "PurchasePrice";
            this.PurchasePrice.HeaderText = "Precio Unitario Compra";
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
            // 
            // SalePrice
            // 
            this.SalePrice.DataPropertyName = "SalePrice";
            this.SalePrice.HeaderText = "Precio Unitario Venta";
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.ReadOnly = true;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 804);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInventoryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProductDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConstructDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCodeData;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInventoryClassification;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassificationDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInventoryLocalization;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalizationDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
    }
}