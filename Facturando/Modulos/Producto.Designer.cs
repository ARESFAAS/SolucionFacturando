namespace Facturando.Modulos
{
    partial class Producto
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstUnidadMedida = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripción = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dtgProducto = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreeProduct = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(203, 666);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 24);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Exento";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "los datos y haga click en el botón Agregar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(856, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Haga click en el encabezado de la fila y click en el botón editar para modificar " +
    "los datos, para agregar un registro ingrese ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(570, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ingrese la descripción el producto o parte de ella y haga click en el botón busca" +
    "r";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(632, 559);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 38);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstUnidadMedida
            // 
            this.lstUnidadMedida.FormattingEnabled = true;
            this.lstUnidadMedida.ItemHeight = 20;
            this.lstUnidadMedida.Location = new System.Drawing.Point(203, 427);
            this.lstUnidadMedida.Name = "lstUnidadMedida";
            this.lstUnidadMedida.Size = new System.Drawing.Size(362, 224);
            this.lstUnidadMedida.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Unidad de Medida";
            // 
            // txtDescripción
            // 
            this.txtDescripción.Location = new System.Drawing.Point(203, 384);
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.Size = new System.Drawing.Size(362, 26);
            this.txtDescripción.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripción";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(632, 615);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 36);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dtgProducto
            // 
            this.dtgProducto.AllowUserToAddRows = false;
            this.dtgProducto.AllowUserToDeleteRows = false;
            this.dtgProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Description,
            this.IdUnit,
            this.DescriptionUnit,
            this.FreeProduct});
            this.dtgProducto.Location = new System.Drawing.Point(45, 173);
            this.dtgProducto.Name = "dtgProducto";
            this.dtgProducto.ReadOnly = true;
            this.dtgProducto.Size = new System.Drawing.Size(834, 190);
            this.dtgProducto.TabIndex = 3;
            this.dtgProducto.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgProducto_RowHeaderMouseClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 48;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Descripción";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 117;
            // 
            // IdUnit
            // 
            this.IdUnit.DataPropertyName = "IdUnit";
            this.IdUnit.HeaderText = "IdUnit";
            this.IdUnit.Name = "IdUnit";
            this.IdUnit.ReadOnly = true;
            this.IdUnit.Visible = false;
            this.IdUnit.Width = 77;
            // 
            // DescriptionUnit
            // 
            this.DescriptionUnit.DataPropertyName = "DescriptionUnit";
            this.DescriptionUnit.HeaderText = "Unidad de Medida";
            this.DescriptionUnit.Name = "DescriptionUnit";
            this.DescriptionUnit.ReadOnly = true;
            this.DescriptionUnit.Width = 149;
            // 
            // FreeProduct
            // 
            this.FreeProduct.DataPropertyName = "FreeProduct";
            this.FreeProduct.HeaderText = "Exento";
            this.FreeProduct.Name = "FreeProduct";
            this.FreeProduct.ReadOnly = true;
            this.FreeProduct.Width = 65;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(633, 54);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 35);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(228, 63);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(351, 26);
            this.txtNombreProducto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion Producto";
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(1101, 706);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstUnidadMedida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripción);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dtgProducto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Producto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dtgProducto;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripción;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstUnidadMedida;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionUnit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FreeProduct;
    }
}