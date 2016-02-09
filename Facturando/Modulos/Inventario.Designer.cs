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
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.Sign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.MaskedTextBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.lstTipoMovimiento = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(21, 73);
            this.txtCodigoBarras.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(321, 23);
            this.txtCodigoBarras.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 181);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkOrange;
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
            this.SalePrice,
            this.Sign});
            this.dataGridView1.Location = new System.Drawing.Point(21, 349);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1586, 578);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
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
            this.ProductDetail.Width = 90;
            // 
            // InventoryDescription
            // 
            this.InventoryDescription.DataPropertyName = "InventoryDescription";
            this.InventoryDescription.HeaderText = "Descripcion";
            this.InventoryDescription.Name = "InventoryDescription";
            this.InventoryDescription.ReadOnly = true;
            this.InventoryDescription.Width = 107;
            // 
            // QuantityDescription
            // 
            this.QuantityDescription.DataPropertyName = "Quantity";
            this.QuantityDescription.HeaderText = "Cantidad";
            this.QuantityDescription.Name = "QuantityDescription";
            this.QuantityDescription.ReadOnly = true;
            this.QuantityDescription.Width = 89;
            // 
            // EventDate
            // 
            this.EventDate.DataPropertyName = "EventDate";
            this.EventDate.HeaderText = "Fecha Ingreso";
            this.EventDate.Name = "EventDate";
            this.EventDate.ReadOnly = true;
            this.EventDate.Width = 113;
            // 
            // ConstructDate
            // 
            this.ConstructDate.DataPropertyName = "ConstructDate";
            this.ConstructDate.HeaderText = "Fecha Fabricación";
            this.ConstructDate.Name = "ConstructDate";
            this.ConstructDate.ReadOnly = true;
            this.ConstructDate.Width = 136;
            // 
            // DueDate
            // 
            this.DueDate.DataPropertyName = "DueDate";
            this.DueDate.HeaderText = "Fecha Vencimiento";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            this.DueDate.Width = 140;
            // 
            // BarCodeData
            // 
            this.BarCodeData.DataPropertyName = "BarCodeData";
            this.BarCodeData.HeaderText = "Codigo Barras";
            this.BarCodeData.Name = "BarCodeData";
            this.BarCodeData.ReadOnly = true;
            this.BarCodeData.Width = 113;
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
            this.ClassificationDescription.Width = 111;
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
            this.LocalizationDescription.Width = 111;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.DataPropertyName = "PurchasePrice";
            this.PurchasePrice.HeaderText = "Precio Unitario Compra";
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
            this.PurchasePrice.Width = 163;
            // 
            // SalePrice
            // 
            this.SalePrice.DataPropertyName = "SalePrice";
            this.SalePrice.HeaderText = "Precio Unitario Venta";
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.ReadOnly = true;
            this.SalePrice.Width = 152;
            // 
            // Sign
            // 
            this.Sign.DataPropertyName = "Sign";
            this.Sign.HeaderText = "Signo";
            this.Sign.Name = "Sign";
            this.Sign.ReadOnly = true;
            this.Sign.Width = 69;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Id,
            this.IdProduct,
            this.Quantity,
            this.LastSalePrice});
            this.dataGridView2.Location = new System.Drawing.Point(353, 72);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(684, 135);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick);
            // 
            // Product
            // 
            this.Product.DataPropertyName = "Product";
            this.Product.HeaderText = "Producto";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 90;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 44;
            // 
            // IdProduct
            // 
            this.IdProduct.DataPropertyName = "IdProduct";
            this.IdProduct.HeaderText = "IdProduct";
            this.IdProduct.Name = "IdProduct";
            this.IdProduct.ReadOnly = true;
            this.IdProduct.Visible = false;
            this.IdProduct.Width = 93;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Cantidad";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 89;
            // 
            // LastSalePrice
            // 
            this.LastSalePrice.DataPropertyName = "LastSalePrice";
            this.LastSalePrice.HeaderText = "Precio Venta";
            this.LastSalePrice.Name = "LastSalePrice";
            this.LastSalePrice.ReadOnly = true;
            this.LastSalePrice.Width = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingrese el codigo de barras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ingrese el código de barras o deje el campo en blanco";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 282);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(345, 23);
            this.textBox2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ingrese Nombre de Producto:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(21, 127);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(321, 23);
            this.txtNombreProducto.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(593, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Existencias Actuales (haga click en el encabezado de cada registro para consultar" +
    " el detalle)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 328);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(715, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Detalle de movimientos (últimos 50 registros) (haga doble click en el encabezado " +
    "de cada registro para editarlo)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEntrada
            // 
            this.btnEntrada.Location = new System.Drawing.Point(391, 277);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(157, 28);
            this.btnEntrada.TabIndex = 8;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.Location = new System.Drawing.Point(565, 277);
            this.btnSalida.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(156, 28);
            this.btnSalida.TabIndex = 9;
            this.btnSalida.Text = "Salida";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1064, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Desde";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(1067, 73);
            this.txtDesde.Mask = "00/00/0000";
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(147, 23);
            this.txtDesde.TabIndex = 15;
            this.txtDesde.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1067, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hasta";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(1070, 129);
            this.txtHasta.Mask = "00/00/0000";
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(144, 23);
            this.txtHasta.TabIndex = 17;
            this.txtHasta.ValidatingType = typeof(System.DateTime);
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "dd/MM/yyyy";
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(1226, 72);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 23);
            this.dtpDesde.TabIndex = 3;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // dtpHasta
            // 
            this.dtpHasta.CustomFormat = "dd/MM/yyyy";
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(1226, 129);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 23);
            this.dtpHasta.TabIndex = 4;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1070, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tipo Movimiento";
            // 
            // lstTipoMovimiento
            // 
            this.lstTipoMovimiento.FormattingEnabled = true;
            this.lstTipoMovimiento.ItemHeight = 16;
            this.lstTipoMovimiento.Location = new System.Drawing.Point(1226, 181);
            this.lstTipoMovimiento.Name = "lstTipoMovimiento";
            this.lstTipoMovimiento.Size = new System.Drawing.Size(120, 52);
            this.lstTipoMovimiento.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1181, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ingrese código de barras o nombre del producto o parte de el y haga click en Busc" +
    "ar, luego puede ver el detalle y puede filtrar ese detalle con un rango de fecha" +
    "s y el tipo de movimiento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "y haga click en el botón Entrada";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(566, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(471, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Para crear una salida debe seleccionar un registro de detalle con signo +";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1620, 991);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstTipoMovimiento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCodigoBarras);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSalida;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Sign;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastSalePrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtDesde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstTipoMovimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}