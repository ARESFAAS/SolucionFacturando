namespace Facturando.Modulos
{
    partial class AgregarEditarRegistroInventario
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.txtFechaVencimiento = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaFabricacion = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaIngreso = new System.Windows.Forms.MaskedTextBox();
            this.txtCantidad = new System.Windows.Forms.MaskedTextBox();
            this.txtPrecioCompra = new System.Windows.Forms.MaskedTextBox();
            this.txtPrecioVenta = new System.Windows.Forms.MaskedTextBox();
            this.lstProducto = new System.Windows.Forms.ListBox();
            this.lstTipoMovimiento = new System.Windows.Forms.ListBox();
            this.lstClasificacion = new System.Windows.Forms.ListBox();
            this.lstLocalizacion = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tipo Movimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Fecha Ingreso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fecha Fabricación";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Fecha Vencimiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Codigo Barras";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Clasificación";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(96, 491);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Localización";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(96, 567);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Precio Unitario de Compra";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(96, 605);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Precio Unitario de Venta";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(244, 11);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(167, 20);
            this.txtCodigoBarras.TabIndex = 0;
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Location = new System.Drawing.Point(244, 388);
            this.txtFechaVencimiento.Mask = "00/00/0000";
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(167, 20);
            this.txtFechaVencimiento.TabIndex = 6;
            this.txtFechaVencimiento.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaFabricacion
            // 
            this.txtFechaFabricacion.Location = new System.Drawing.Point(244, 347);
            this.txtFechaFabricacion.Mask = "00/00/0000";
            this.txtFechaFabricacion.Name = "txtFechaFabricacion";
            this.txtFechaFabricacion.Size = new System.Drawing.Size(167, 20);
            this.txtFechaFabricacion.TabIndex = 5;
            this.txtFechaFabricacion.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Location = new System.Drawing.Point(244, 305);
            this.txtFechaIngreso.Mask = "00/00/0000";
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(167, 20);
            this.txtFechaIngreso.TabIndex = 4;
            this.txtFechaIngreso.ValidatingType = typeof(System.DateTime);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(244, 266);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(167, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(244, 565);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(167, 20);
            this.txtPrecioCompra.TabIndex = 9;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(244, 602);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(167, 20);
            this.txtPrecioVenta.TabIndex = 10;
            // 
            // lstProducto
            // 
            this.lstProducto.FormattingEnabled = true;
            this.lstProducto.Location = new System.Drawing.Point(244, 45);
            this.lstProducto.Name = "lstProducto";
            this.lstProducto.Size = new System.Drawing.Size(188, 134);
            this.lstProducto.TabIndex = 1;
            this.lstProducto.SelectedIndexChanged += new System.EventHandler(this.lstProducto_SelectedIndexChanged);
            // 
            // lstTipoMovimiento
            // 
            this.lstTipoMovimiento.FormattingEnabled = true;
            this.lstTipoMovimiento.Location = new System.Drawing.Point(244, 194);
            this.lstTipoMovimiento.Name = "lstTipoMovimiento";
            this.lstTipoMovimiento.Size = new System.Drawing.Size(188, 56);
            this.lstTipoMovimiento.TabIndex = 2;
            // 
            // lstClasificacion
            // 
            this.lstClasificacion.FormattingEnabled = true;
            this.lstClasificacion.Location = new System.Drawing.Point(244, 421);
            this.lstClasificacion.Name = "lstClasificacion";
            this.lstClasificacion.Size = new System.Drawing.Size(188, 56);
            this.lstClasificacion.TabIndex = 7;
            // 
            // lstLocalizacion
            // 
            this.lstLocalizacion.FormattingEnabled = true;
            this.lstLocalizacion.Location = new System.Drawing.Point(244, 491);
            this.lstLocalizacion.Name = "lstLocalizacion";
            this.lstLocalizacion.Size = new System.Drawing.Size(188, 56);
            this.lstLocalizacion.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(357, 646);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // AgregarEditarRegistroInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 682);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lstLocalizacion);
            this.Controls.Add(this.lstClasificacion);
            this.Controls.Add(this.lstTipoMovimiento);
            this.Controls.Add(this.lstProducto);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtFechaIngreso);
            this.Controls.Add(this.txtFechaFabricacion);
            this.Controls.Add(this.txtFechaVencimiento);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "AgregarEditarRegistroInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarEditarRegistroInventario";
            this.Load += new System.EventHandler(this.AgregarEditarRegistroInventario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.MaskedTextBox txtFechaVencimiento;
        private System.Windows.Forms.MaskedTextBox txtFechaFabricacion;
        private System.Windows.Forms.MaskedTextBox txtFechaIngreso;
        private System.Windows.Forms.MaskedTextBox txtCantidad;
        private System.Windows.Forms.MaskedTextBox txtPrecioCompra;
        private System.Windows.Forms.MaskedTextBox txtPrecioVenta;
        private System.Windows.Forms.ListBox lstProducto;
        private System.Windows.Forms.ListBox lstTipoMovimiento;
        private System.Windows.Forms.ListBox lstClasificacion;
        private System.Windows.Forms.ListBox lstLocalizacion;
        private System.Windows.Forms.Button btnGuardar;
    }
}