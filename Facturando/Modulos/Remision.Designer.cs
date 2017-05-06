namespace Facturando
{
    partial class Remision
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.lstProducto = new System.Windows.Forms.ListBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRemitir = new System.Windows.Forms.Button();
            this.txtDescuentoFinal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtgDetalleRemision = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRemission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNumeroRemision = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblGranTotal = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.chkPagada = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleRemision)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLIENTE";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(385, 40);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(93, 30);
            this.btnBuscarCliente.TabIndex = 17;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtDescuentoCliente
            // 
            this.txtDescuentoCliente.Location = new System.Drawing.Point(358, 217);
            this.txtDescuentoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescuentoCliente.Name = "txtDescuentoCliente";
            this.txtDescuentoCliente.Size = new System.Drawing.Size(129, 20);
            this.txtDescuentoCliente.TabIndex = 22;
            this.txtDescuentoCliente.Leave += new System.EventHandler(this.txtDescuentoCliente_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(377, 194);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "DESCUENTO (%)";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(21, 217);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(328, 20);
            this.txtEmail.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(167, 194);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "EMAIL";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(358, 161);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(129, 20);
            this.txtTelefono.TabIndex = 20;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(21, 161);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(328, 20);
            this.txtDireccion.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(383, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "TELÉFONO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(153, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "DIRECCIÓN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(225, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "NOMBRE";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(20, 99);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(467, 20);
            this.txtNombreCliente.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(233, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "IDENTIFICACIÓN";
            // 
            // txtIdentificacionCliente
            // 
            this.txtIdentificacionCliente.Location = new System.Drawing.Point(177, 46);
            this.txtIdentificacionCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdentificacionCliente.Name = "txtIdentificacionCliente";
            this.txtIdentificacionCliente.Size = new System.Drawing.Size(193, 20);
            this.txtIdentificacionCliente.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(73, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "TIPO ID";
            // 
            // cmbTipoIdentificacion
            // 
            this.cmbTipoIdentificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoIdentificacion.FormattingEnabled = true;
            this.cmbTipoIdentificacion.Location = new System.Drawing.Point(21, 46);
            this.cmbTipoIdentificacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoIdentificacion.Name = "cmbTipoIdentificacion";
            this.cmbTipoIdentificacion.Size = new System.Drawing.Size(148, 21);
            this.cmbTipoIdentificacion.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarProducto);
            this.groupBox2.Controls.Add(this.lstProducto);
            this.groupBox2.Controls.Add(this.txtNombreProducto);
            this.groupBox2.Controls.Add(this.txtCodigoBarras);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(13, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PRODUCTO";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(389, 38);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(93, 29);
            this.btnBuscarProducto.TabIndex = 8;
            this.btnBuscarProducto.Text = "Buscar Producto";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // lstProducto
            // 
            this.lstProducto.FormattingEnabled = true;
            this.lstProducto.Location = new System.Drawing.Point(17, 74);
            this.lstProducto.Margin = new System.Windows.Forms.Padding(2);
            this.lstProducto.Name = "lstProducto";
            this.lstProducto.Size = new System.Drawing.Size(474, 186);
            this.lstProducto.TabIndex = 9;
            this.lstProducto.Click += new System.EventHandler(this.lstProducto_Click);
            this.lstProducto.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lstProducto_Format);
            this.lstProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstProducto_KeyDown);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(181, 43);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(193, 20);
            this.txtNombreProducto.TabIndex = 7;
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(17, 43);
            this.txtCodigoBarras.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(156, 20);
            this.txtCodigoBarras.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(222, 21);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "NOMBRE PRODUCTO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(48, 21);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "CÓDIGO BARRAS";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRemitir);
            this.groupBox3.Controls.Add(this.txtDescuentoFinal);
            this.groupBox3.Controls.Add(this.txtDescuento);
            this.groupBox3.Controls.Add(this.txtSubTotal);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.dtgDetalleRemision);
            this.groupBox3.Location = new System.Drawing.Point(523, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(611, 458);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DETALLE REMISIÓN";
            // 
            // btnRemitir
            // 
            this.btnRemitir.Enabled = false;
            this.btnRemitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemitir.Location = new System.Drawing.Point(14, 371);
            this.btnRemitir.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemitir.Name = "btnRemitir";
            this.btnRemitir.Size = new System.Drawing.Size(70, 39);
            this.btnRemitir.TabIndex = 9;
            this.btnRemitir.Text = "VISTA PREVIA";
            this.btnRemitir.UseVisualStyleBackColor = true;
            this.btnRemitir.Click += new System.EventHandler(this.btnRemitir_Click);
            // 
            // txtDescuentoFinal
            // 
            this.txtDescuentoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuentoFinal.Location = new System.Drawing.Point(301, 412);
            this.txtDescuentoFinal.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescuentoFinal.Name = "txtDescuentoFinal";
            this.txtDescuentoFinal.Size = new System.Drawing.Size(294, 35);
            this.txtDescuentoFinal.TabIndex = 8;
            this.txtDescuentoFinal.Leave += new System.EventHandler(this.txtDescuentoFinal_Leave);
            // 
            // txtDescuento
            // 
            this.txtDescuento.AutoSize = true;
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.ForeColor = System.Drawing.Color.White;
            this.txtDescuento.Location = new System.Drawing.Point(65, 419);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(232, 24);
            this.txtDescuento.TabIndex = 11;
            this.txtDescuento.Text = "DESCUENTO FINAL ($)";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(301, 372);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(294, 35);
            this.txtSubTotal.TabIndex = 7;
            this.txtSubTotal.Leave += new System.EventHandler(this.txtSubTotal_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(149, 379);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 24);
            this.label14.TabIndex = 10;
            this.label14.Text = "SUBTOTAL ($)";
            // 
            // dtgDetalleRemision
            // 
            this.dtgDetalleRemision.AllowUserToAddRows = false;
            this.dtgDetalleRemision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgDetalleRemision.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgDetalleRemision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalleRemision.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdRemission,
            this.IdProduct,
            this.Product,
            this.UnitPrice,
            this.Discount,
            this.Quantity,
            this.Total});
            this.dtgDetalleRemision.Location = new System.Drawing.Point(14, 19);
            this.dtgDetalleRemision.Margin = new System.Windows.Forms.Padding(2);
            this.dtgDetalleRemision.Name = "dtgDetalleRemision";
            this.dtgDetalleRemision.Size = new System.Drawing.Size(580, 348);
            this.dtgDetalleRemision.TabIndex = 1;
            this.dtgDetalleRemision.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtgDetalleRemision_CellBeginEdit);
            this.dtgDetalleRemision.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDetalleRemision_CellEndEdit);
            this.dtgDetalleRemision.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgDetalleRemision_CellFormatting);
            this.dtgDetalleRemision.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgDetalleRemision_DataError);
            this.dtgDetalleRemision.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgDetalleRemision_KeyDown);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 44;
            // 
            // IdRemission
            // 
            this.IdRemission.DataPropertyName = "IdRemission";
            this.IdRemission.HeaderText = "IdRemission";
            this.IdRemission.Name = "IdRemission";
            this.IdRemission.Visible = false;
            this.IdRemission.Width = 115;
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
            this.Product.Width = 81;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Precio Unitario ($)";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 106;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Descuento Precio Unitario ($)";
            this.Discount.Name = "Discount";
            this.Discount.Width = 159;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Cantidad";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 81;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "SubTotal ($)";
            this.Total.Name = "Total";
            this.Total.Width = 91;
            // 
            // lblNumeroRemision
            // 
            this.lblNumeroRemision.AutoSize = true;
            this.lblNumeroRemision.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRemision.ForeColor = System.Drawing.Color.White;
            this.lblNumeroRemision.Location = new System.Drawing.Point(1000, 18);
            this.lblNumeroRemision.Name = "lblNumeroRemision";
            this.lblNumeroRemision.Size = new System.Drawing.Size(134, 31);
            this.lblNumeroRemision.TabIndex = 8;
            this.lblNumeroRemision.Text = "00000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(523, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "REMISIÓN NO.";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.lblGranTotal);
            this.groupBox4.Location = new System.Drawing.Point(523, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(610, 154);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TOTAL";
            // 
            // lblGranTotal
            // 
            this.lblGranTotal.AutoSize = true;
            this.lblGranTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblGranTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGranTotal.Location = new System.Drawing.Point(-1, 36);
            this.lblGranTotal.Name = "lblGranTotal";
            this.lblGranTotal.Size = new System.Drawing.Size(79, 85);
            this.lblGranTotal.TabIndex = 0;
            this.lblGranTotal.Text = "0";
            this.lblGranTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtObservaciones);
            this.groupBox5.Controls.Add(this.chkPagada);
            this.groupBox5.Location = new System.Drawing.Point(12, 589);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(508, 87);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "OBSERVACIONES";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(17, 20);
            this.txtObservaciones.MaxLength = 255;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(397, 47);
            this.txtObservaciones.TabIndex = 3;
            // 
            // chkPagada
            // 
            this.chkPagada.AutoSize = true;
            this.chkPagada.Checked = true;
            this.chkPagada.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPagada.Location = new System.Drawing.Point(423, 40);
            this.chkPagada.Name = "chkPagada";
            this.chkPagada.Size = new System.Drawing.Size(69, 19);
            this.chkPagada.TabIndex = 2;
            this.chkPagada.Text = "Pagada";
            this.chkPagada.UseVisualStyleBackColor = true;
            // 
            // Remision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1146, 688);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblNumeroRemision);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Remision";
            this.Text = "Remision";
            this.Load += new System.EventHandler(this.Remision_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleRemision)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblNumeroRemision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblGranTotal;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtDescuentoCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdentificacionCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoIdentificacion;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.ListBox lstProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dtgDetalleRemision;
        private System.Windows.Forms.Button btnRemitir;
        private System.Windows.Forms.TextBox txtDescuentoFinal;
        private System.Windows.Forms.Label txtDescuento;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRemission;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.CheckBox chkPagada;
    }
}