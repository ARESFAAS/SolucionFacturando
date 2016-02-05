namespace Facturando
{
    partial class Facturacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtDescuentoCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdentificacionCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoIdentificacion = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.lstProducto = new System.Windows.Forms.ListBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.dtgImpuestos = new System.Windows.Forms.DataGridView();
            this.IdBillTaxes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBill2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercentageValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDescuentoFinal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtgDetalleFactura = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.lblGranTotal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgImpuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleFactura)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.txtDescuentoCliente);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtIdentificacionCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbTipoIdentificacion);
            this.groupBox1.Location = new System.Drawing.Point(13, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(758, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLIENTE";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(581, 56);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(140, 41);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtDescuentoCliente
            // 
            this.txtDescuentoCliente.Location = new System.Drawing.Point(541, 301);
            this.txtDescuentoCliente.Name = "txtDescuentoCliente";
            this.txtDescuentoCliente.Size = new System.Drawing.Size(191, 24);
            this.txtDescuentoCliente.TabIndex = 7;
            this.txtDescuentoCliente.Leave += new System.EventHandler(this.txtDescuentoCliente_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(570, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 18);
            this.label11.TabIndex = 14;
            this.label11.Text = "DESCUENTO (%)";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(35, 301);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(490, 24);
            this.txtEmail.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "EMAIL";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(541, 223);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(191, 24);
            this.txtTelefono.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(35, 223);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(490, 24);
            this.txtDireccion.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(578, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "TELÉFONO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "DIRECCIÓN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "NOMBRE";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(34, 137);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(698, 24);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "IDENTIFICACIÓN";
            // 
            // txtIdentificacionCliente
            // 
            this.txtIdentificacionCliente.Location = new System.Drawing.Point(270, 64);
            this.txtIdentificacionCliente.Name = "txtIdentificacionCliente";
            this.txtIdentificacionCliente.Size = new System.Drawing.Size(287, 24);
            this.txtIdentificacionCliente.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "TIPO ID";
            // 
            // cmbTipoIdentificacion
            // 
            this.cmbTipoIdentificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoIdentificacion.FormattingEnabled = true;
            this.cmbTipoIdentificacion.Location = new System.Drawing.Point(35, 64);
            this.cmbTipoIdentificacion.Name = "cmbTipoIdentificacion";
            this.cmbTipoIdentificacion.Size = new System.Drawing.Size(220, 26);
            this.cmbTipoIdentificacion.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscarProducto);
            this.groupBox3.Controls.Add(this.lstProducto);
            this.groupBox3.Controls.Add(this.txtNombreProducto);
            this.groupBox3.Controls.Add(this.txtCodigoBarras);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(13, 428);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(758, 550);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PRODUCTO";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Enabled = false;
            this.btnBuscarProducto.Location = new System.Drawing.Point(581, 53);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(140, 40);
            this.btnBuscarProducto.TabIndex = 2;
            this.btnBuscarProducto.Text = "Buscar Producto";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // lstProducto
            // 
            this.lstProducto.FormattingEnabled = true;
            this.lstProducto.ItemHeight = 18;
            this.lstProducto.Location = new System.Drawing.Point(23, 122);
            this.lstProducto.Name = "lstProducto";
            this.lstProducto.Size = new System.Drawing.Size(709, 400);
            this.lstProducto.TabIndex = 3;
            this.lstProducto.Click += new System.EventHandler(this.lstProducto_Click);
            this.lstProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstProducto_KeyDown);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(270, 61);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(287, 24);
            this.txtNombreProducto.TabIndex = 1;
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(23, 61);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(232, 24);
            this.txtCodigoBarras.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(331, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 18);
            this.label13.TabIndex = 5;
            this.label13.Text = "NOMBRE PRODUCTO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 18);
            this.label12.TabIndex = 4;
            this.label12.Text = "CÓDIGO BARRAS";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnFacturar);
            this.groupBox4.Controls.Add(this.dtgImpuestos);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtDescuentoFinal);
            this.groupBox4.Controls.Add(this.txtDescuento);
            this.groupBox4.Controls.Add(this.txtSubTotal);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.dtgDetalleFactura);
            this.groupBox4.Location = new System.Drawing.Point(779, 306);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(828, 672);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DETALLE FACTURA";
            // 
            // btnFacturar
            // 
            this.btnFacturar.Enabled = false;
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(19, 592);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(117, 52);
            this.btnFacturar.TabIndex = 4;
            this.btnFacturar.Text = "VISTA PREVIA";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // dtgImpuestos
            // 
            this.dtgImpuestos.AllowUserToAddRows = false;
            this.dtgImpuestos.AllowUserToDeleteRows = false;
            this.dtgImpuestos.BackgroundColor = System.Drawing.Color.White;
            this.dtgImpuestos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgImpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgImpuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBillTaxes,
            this.IdTax,
            this.IdBill2,
            this.Description,
            this.PercentageValue,
            this.Total2});
            this.dtgImpuestos.Location = new System.Drawing.Point(450, 527);
            this.dtgImpuestos.MultiSelect = false;
            this.dtgImpuestos.Name = "dtgImpuestos";
            this.dtgImpuestos.ReadOnly = true;
            this.dtgImpuestos.Size = new System.Drawing.Size(355, 117);
            this.dtgImpuestos.TabIndex = 3;
            // 
            // IdBillTaxes
            // 
            this.IdBillTaxes.DataPropertyName = "Id";
            this.IdBillTaxes.HeaderText = "IdBillTaxes";
            this.IdBillTaxes.Name = "IdBillTaxes";
            this.IdBillTaxes.ReadOnly = true;
            this.IdBillTaxes.Visible = false;
            // 
            // IdTax
            // 
            this.IdTax.DataPropertyName = "IdTax";
            this.IdTax.HeaderText = "IdTax";
            this.IdTax.Name = "IdTax";
            this.IdTax.ReadOnly = true;
            this.IdTax.Visible = false;
            // 
            // IdBill2
            // 
            this.IdBill2.DataPropertyName = "IdBill";
            this.IdBill2.HeaderText = "IdBill2";
            this.IdBill2.Name = "IdBill2";
            this.IdBill2.ReadOnly = true;
            this.IdBill2.Visible = false;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Descripción";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // PercentageValue
            // 
            this.PercentageValue.DataPropertyName = "PercentageValue";
            this.PercentageValue.HeaderText = "%";
            this.PercentageValue.Name = "PercentageValue";
            this.PercentageValue.ReadOnly = true;
            // 
            // Total2
            // 
            this.Total2.DataPropertyName = "Total";
            this.Total2.HeaderText = "Total";
            this.Total2.Name = "Total2";
            this.Total2.ReadOnly = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(162, 559);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(282, 39);
            this.label16.TabIndex = 7;
            this.label16.Text = "IMPUESTOS ($)";
            // 
            // txtDescuentoFinal
            // 
            this.txtDescuentoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuentoFinal.Location = new System.Drawing.Point(450, 465);
            this.txtDescuentoFinal.Name = "txtDescuentoFinal";
            this.txtDescuentoFinal.Size = new System.Drawing.Size(355, 53);
            this.txtDescuentoFinal.TabIndex = 2;
            this.txtDescuentoFinal.Leave += new System.EventHandler(this.txtDescuentoFinal_Leave);
            // 
            // txtDescuento
            // 
            this.txtDescuento.AutoSize = true;
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(35, 474);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(409, 39);
            this.txtDescuento.TabIndex = 6;
            this.txtDescuento.Text = "DESCUENTO FINAL ($)";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(450, 403);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(355, 53);
            this.txtSubTotal.TabIndex = 1;
            this.txtSubTotal.Leave += new System.EventHandler(this.txtSubTotal_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(187, 410);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(260, 39);
            this.label14.TabIndex = 5;
            this.label14.Text = "SUBTOTAL ($)";
            // 
            // dtgDetalleFactura
            // 
            this.dtgDetalleFactura.AllowUserToAddRows = false;
            this.dtgDetalleFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgDetalleFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdBill,
            this.IdProduct,
            this.Product,
            this.UnitPrice,
            this.Discount,
            this.Quantity,
            this.Total});
            this.dtgDetalleFactura.Location = new System.Drawing.Point(19, 31);
            this.dtgDetalleFactura.Name = "dtgDetalleFactura";
            this.dtgDetalleFactura.Size = new System.Drawing.Size(786, 344);
            this.dtgDetalleFactura.TabIndex = 0;
            this.dtgDetalleFactura.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDetalleFactura_CellEndEdit);
            this.dtgDetalleFactura.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgDetalleFactura_CellFormatting);
            this.dtgDetalleFactura.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgDetalleFactura_DataError);
            this.dtgDetalleFactura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgDetalleFactura_KeyDown);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 44;
            // 
            // IdBill
            // 
            this.IdBill.DataPropertyName = "IdBill";
            this.IdBill.HeaderText = "IdBill";
            this.IdBill.Name = "IdBill";
            this.IdBill.Visible = false;
            this.IdBill.Width = 63;
            // 
            // IdProduct
            // 
            this.IdProduct.DataPropertyName = "IdProduct";
            this.IdProduct.HeaderText = "IdProduct";
            this.IdProduct.Name = "IdProduct";
            this.IdProduct.Visible = false;
            this.IdProduct.Width = 96;
            // 
            // Product
            // 
            this.Product.DataPropertyName = "Product";
            this.Product.HeaderText = "Producto";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 94;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Precio Unitario ($)";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 123;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Descuento Precio Unitario ($)";
            this.Discount.Name = "Discount";
            this.Discount.Width = 188;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Cantidad";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 91;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "SubTotal ($)";
            this.Total.Name = "Total";
            this.Total.Width = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(855, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "FACTURA DE VENTA NO.";
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFactura.Location = new System.Drawing.Point(1471, 27);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(134, 31);
            this.lblNumeroFactura.TabIndex = 6;
            this.lblNumeroFactura.Text = "00000000";
            // 
            // lblGranTotal
            // 
            this.lblGranTotal.AutoSize = true;
            this.lblGranTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblGranTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGranTotal.Location = new System.Drawing.Point(-1, 48);
            this.lblGranTotal.Name = "lblGranTotal";
            this.lblGranTotal.Size = new System.Drawing.Size(111, 120);
            this.lblGranTotal.TabIndex = 0;
            this.lblGranTotal.Text = "0";
            this.lblGranTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lblGranTotal);
            this.groupBox2.Location = new System.Drawing.Point(779, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(826, 213);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TOTAL";
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1620, 991);
            this.Controls.Add(this.lblNumeroFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgImpuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleFactura)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.Label lblGranTotal;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdentificacionCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoIdentificacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtDescuentoCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lstProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.DataGridView dtgDetalleFactura;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDescuentoFinal;
        private System.Windows.Forms.Label txtDescuento;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dtgImpuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBillTaxes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBill2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercentageValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}