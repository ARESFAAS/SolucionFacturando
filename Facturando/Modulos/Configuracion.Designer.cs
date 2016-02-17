namespace Facturando
{
    partial class Configuracion
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
            this.dtgConfiguracion = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiscalYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperationsInitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorizedBillingInit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorizedBillingEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrencyList = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CountryList = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IsNewRegister = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtgImpuestos = new System.Windows.Forms.DataGridView();
            this.IdTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercentageValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsNewRegisterTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgTiposIdentificacion = new System.Windows.Forms.DataGridView();
            this.IdIdentificationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionIdentificationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsNewRegisterTI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgLocalizacionInventario = new System.Windows.Forms.DataGridView();
            this.IdInventoryLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionInventoryLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsNewRegisterL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgUnidadesMedida = new System.Windows.Forms.DataGridView();
            this.DescriptionUnitMeasure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUnitMeasure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsNewRegisterUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConfiguracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgImpuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTiposIdentificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLocalizacionInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUnidadesMedida)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgConfiguracion
            // 
            this.dtgConfiguracion.AllowUserToDeleteRows = false;
            this.dtgConfiguracion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgConfiguracion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgConfiguracion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConfiguracion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FiscalYear,
            this.OperationsInitDate,
            this.AuthorizedBillingInit,
            this.AuthorizedBillingEnd,
            this.IdCountry,
            this.IdCurrency,
            this.CurrencyList,
            this.CountryList,
            this.IsNewRegister});
            this.dtgConfiguracion.Location = new System.Drawing.Point(42, 56);
            this.dtgConfiguracion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgConfiguracion.Name = "dtgConfiguracion";
            this.dtgConfiguracion.Size = new System.Drawing.Size(972, 182);
            this.dtgConfiguracion.TabIndex = 0;
            this.dtgConfiguracion.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtgConfiguracion_CellBeginEdit);
            this.dtgConfiguracion.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConfiguracion_CellEndEdit);
            this.dtgConfiguracion.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgConfiguracion_DataError);
            this.dtgConfiguracion.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dtgConfiguracion_UserAddedRow);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 48;
            // 
            // FiscalYear
            // 
            this.FiscalYear.DataPropertyName = "FiscalYear";
            this.FiscalYear.HeaderText = "Año Fiscal";
            this.FiscalYear.Name = "FiscalYear";
            this.FiscalYear.Width = 99;
            // 
            // OperationsInitDate
            // 
            this.OperationsInitDate.DataPropertyName = "OperationsInitDate";
            this.OperationsInitDate.HeaderText = "Fecha Inicio Operaciones";
            this.OperationsInitDate.Name = "OperationsInitDate";
            this.OperationsInitDate.Width = 195;
            // 
            // AuthorizedBillingInit
            // 
            this.AuthorizedBillingInit.DataPropertyName = "AuthorizedBillingInit";
            this.AuthorizedBillingInit.HeaderText = "Facturación Desde";
            this.AuthorizedBillingInit.Name = "AuthorizedBillingInit";
            this.AuthorizedBillingInit.Width = 154;
            // 
            // AuthorizedBillingEnd
            // 
            this.AuthorizedBillingEnd.DataPropertyName = "AuthorizedBillingEnd";
            this.AuthorizedBillingEnd.HeaderText = "Facturación Hasta";
            this.AuthorizedBillingEnd.Name = "AuthorizedBillingEnd";
            this.AuthorizedBillingEnd.Width = 150;
            // 
            // IdCountry
            // 
            this.IdCountry.DataPropertyName = "IdCountry";
            this.IdCountry.HeaderText = "IdCountry";
            this.IdCountry.Name = "IdCountry";
            this.IdCountry.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdCountry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdCountry.Visible = false;
            this.IdCountry.Width = 84;
            // 
            // IdCurrency
            // 
            this.IdCurrency.DataPropertyName = "IdCurrency";
            this.IdCurrency.HeaderText = "IdCurrency";
            this.IdCurrency.Name = "IdCurrency";
            this.IdCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdCurrency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdCurrency.Visible = false;
            this.IdCurrency.Width = 92;
            // 
            // CurrencyList
            // 
            this.CurrencyList.HeaderText = "Moneda";
            this.CurrencyList.Name = "CurrencyList";
            this.CurrencyList.Width = 73;
            // 
            // CountryList
            // 
            this.CountryList.HeaderText = "País";
            this.CountryList.Name = "CountryList";
            this.CountryList.Width = 45;
            // 
            // IsNewRegister
            // 
            this.IsNewRegister.DataPropertyName = "IsNewRegister";
            this.IsNewRegister.HeaderText = "IsNewRegister";
            this.IsNewRegister.Name = "IsNewRegister";
            this.IsNewRegister.Visible = false;
            this.IsNewRegister.Width = 138;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agrega un registro de configuración, el último ingresado será la configuración vi" +
    "gente del sistema";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(862, 646);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(152, 40);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtgImpuestos
            // 
            this.dtgImpuestos.AllowUserToDeleteRows = false;
            this.dtgImpuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgImpuestos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgImpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgImpuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTax,
            this.Description,
            this.PercentageValue,
            this.IsNewRegisterTax});
            this.dtgImpuestos.Location = new System.Drawing.Point(46, 275);
            this.dtgImpuestos.Name = "dtgImpuestos";
            this.dtgImpuestos.Size = new System.Drawing.Size(417, 150);
            this.dtgImpuestos.TabIndex = 3;
            this.dtgImpuestos.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtgImpuestos_CellBeginEdit);
            this.dtgImpuestos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgImpuestos_CellEndEdit);
            this.dtgImpuestos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgImpuestos_DataError);
            this.dtgImpuestos.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dtgImpuestos_UserAddedRow);
            // 
            // IdTax
            // 
            this.IdTax.DataPropertyName = "Id";
            this.IdTax.HeaderText = "IdTax";
            this.IdTax.Name = "IdTax";
            this.IdTax.Visible = false;
            this.IdTax.Width = 73;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Descripción";
            this.Description.Name = "Description";
            this.Description.Width = 117;
            // 
            // PercentageValue
            // 
            this.PercentageValue.DataPropertyName = "PercentageValue";
            this.PercentageValue.HeaderText = "Porcentaje";
            this.PercentageValue.Name = "PercentageValue";
            this.PercentageValue.Width = 110;
            // 
            // IsNewRegisterTax
            // 
            this.IsNewRegisterTax.DataPropertyName = "IsNewRegister";
            this.IsNewRegisterTax.HeaderText = "IsNewRegisterTax";
            this.IsNewRegisterTax.Name = "IsNewRegisterTax";
            this.IsNewRegisterTax.Visible = false;
            this.IsNewRegisterTax.Width = 163;
            // 
            // dtgTiposIdentificacion
            // 
            this.dtgTiposIdentificacion.AllowUserToDeleteRows = false;
            this.dtgTiposIdentificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgTiposIdentificacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgTiposIdentificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTiposIdentificacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdIdentificationType,
            this.DescriptionIdentificationType,
            this.IsNewRegisterTI});
            this.dtgTiposIdentificacion.Location = new System.Drawing.Point(583, 275);
            this.dtgTiposIdentificacion.Name = "dtgTiposIdentificacion";
            this.dtgTiposIdentificacion.Size = new System.Drawing.Size(431, 150);
            this.dtgTiposIdentificacion.TabIndex = 4;
            this.dtgTiposIdentificacion.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtgTiposIdentificacion_CellBeginEdit);
            this.dtgTiposIdentificacion.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTiposIdentificacion_CellEndEdit);
            this.dtgTiposIdentificacion.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgTiposIdentificacion_DataError);
            this.dtgTiposIdentificacion.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dtgTiposIdentificacion_UserAddedRow);
            // 
            // IdIdentificationType
            // 
            this.IdIdentificationType.DataPropertyName = "Id";
            this.IdIdentificationType.HeaderText = "IdIdentificationType";
            this.IdIdentificationType.Name = "IdIdentificationType";
            this.IdIdentificationType.Visible = false;
            this.IdIdentificationType.Width = 173;
            // 
            // DescriptionIdentificationType
            // 
            this.DescriptionIdentificationType.DataPropertyName = "Description";
            this.DescriptionIdentificationType.HeaderText = "Descripción";
            this.DescriptionIdentificationType.Name = "DescriptionIdentificationType";
            this.DescriptionIdentificationType.Width = 117;
            // 
            // IsNewRegisterTI
            // 
            this.IsNewRegisterTI.DataPropertyName = "IsNewRegister";
            this.IsNewRegisterTI.HeaderText = "IsNewRegisterTI";
            this.IsNewRegisterTI.Name = "IsNewRegisterTI";
            this.IsNewRegisterTI.Visible = false;
            this.IsNewRegisterTI.Width = 152;
            // 
            // dtgLocalizacionInventario
            // 
            this.dtgLocalizacionInventario.AllowUserToDeleteRows = false;
            this.dtgLocalizacionInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgLocalizacionInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgLocalizacionInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLocalizacionInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdInventoryLocation,
            this.DescriptionInventoryLocation,
            this.IsNewRegisterL});
            this.dtgLocalizacionInventario.Location = new System.Drawing.Point(583, 469);
            this.dtgLocalizacionInventario.Name = "dtgLocalizacionInventario";
            this.dtgLocalizacionInventario.Size = new System.Drawing.Size(431, 153);
            this.dtgLocalizacionInventario.TabIndex = 5;
            this.dtgLocalizacionInventario.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtgLocalizacionInventario_CellBeginEdit);
            this.dtgLocalizacionInventario.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLocalizacionInventario_CellEndEdit);
            this.dtgLocalizacionInventario.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgLocalizacionInventario_DataError);
            this.dtgLocalizacionInventario.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dtgLocalizacionInventario_UserAddedRow);
            // 
            // IdInventoryLocation
            // 
            this.IdInventoryLocation.DataPropertyName = "Id";
            this.IdInventoryLocation.HeaderText = "IdInventoryLocation";
            this.IdInventoryLocation.Name = "IdInventoryLocation";
            this.IdInventoryLocation.Visible = false;
            this.IdInventoryLocation.Width = 174;
            // 
            // DescriptionInventoryLocation
            // 
            this.DescriptionInventoryLocation.DataPropertyName = "Description";
            this.DescriptionInventoryLocation.HeaderText = "Descripción";
            this.DescriptionInventoryLocation.Name = "DescriptionInventoryLocation";
            this.DescriptionInventoryLocation.Width = 117;
            // 
            // IsNewRegisterL
            // 
            this.IsNewRegisterL.DataPropertyName = "IsNewRegister";
            this.IsNewRegisterL.HeaderText = "IsNewRegisterL";
            this.IsNewRegisterL.Name = "IsNewRegisterL";
            this.IsNewRegisterL.Visible = false;
            this.IsNewRegisterL.Width = 147;
            // 
            // dtgUnidadesMedida
            // 
            this.dtgUnidadesMedida.AllowUserToDeleteRows = false;
            this.dtgUnidadesMedida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgUnidadesMedida.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgUnidadesMedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUnidadesMedida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescriptionUnitMeasure,
            this.IdUnitMeasure,
            this.IsNewRegisterUM});
            this.dtgUnidadesMedida.Location = new System.Drawing.Point(42, 469);
            this.dtgUnidadesMedida.Name = "dtgUnidadesMedida";
            this.dtgUnidadesMedida.Size = new System.Drawing.Size(421, 153);
            this.dtgUnidadesMedida.TabIndex = 6;
            this.dtgUnidadesMedida.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtgUnidadesMedida_CellBeginEdit);
            this.dtgUnidadesMedida.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUnidadesMedida_CellEndEdit);
            this.dtgUnidadesMedida.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgUnidadesMedida_DataError);
            this.dtgUnidadesMedida.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dtgUnidadesMedida_UserAddedRow);
            // 
            // DescriptionUnitMeasure
            // 
            this.DescriptionUnitMeasure.DataPropertyName = "Description";
            this.DescriptionUnitMeasure.HeaderText = "Descripción";
            this.DescriptionUnitMeasure.Name = "DescriptionUnitMeasure";
            this.DescriptionUnitMeasure.Width = 117;
            // 
            // IdUnitMeasure
            // 
            this.IdUnitMeasure.DataPropertyName = "Id";
            this.IdUnitMeasure.HeaderText = "IdUnitMeasure";
            this.IdUnitMeasure.Name = "IdUnitMeasure";
            this.IdUnitMeasure.Visible = false;
            this.IdUnitMeasure.Width = 139;
            // 
            // IsNewRegisterUM
            // 
            this.IsNewRegisterUM.DataPropertyName = "IsNewRegister";
            this.IsNewRegisterUM.HeaderText = "IsNewRegisterUM";
            this.IsNewRegisterUM.Name = "IsNewRegisterUM";
            this.IsNewRegisterUM.Visible = false;
            this.IsNewRegisterUM.Width = 163;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Impuestos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipos Identificación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Unidades Medida (Inventario)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Localizaciones (Inventario)";
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 729);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgUnidadesMedida);
            this.Controls.Add(this.dtgLocalizacionInventario);
            this.Controls.Add(this.dtgTiposIdentificacion);
            this.Controls.Add(this.dtgImpuestos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgConfiguracion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConfiguracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgImpuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTiposIdentificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLocalizacionInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUnidadesMedida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgConfiguracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dtgImpuestos;
        private System.Windows.Forms.DataGridView dtgTiposIdentificacion;
        private System.Windows.Forms.DataGridView dtgLocalizacionInventario;
        private System.Windows.Forms.DataGridView dtgUnidadesMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FiscalYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperationsInitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorizedBillingInit;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorizedBillingEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCurrency;
        private System.Windows.Forms.DataGridViewComboBoxColumn CurrencyList;
        private System.Windows.Forms.DataGridViewComboBoxColumn CountryList;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsNewRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInventoryLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionInventoryLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsNewRegisterL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionUnitMeasure;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUnitMeasure;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsNewRegisterUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercentageValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsNewRegisterTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdIdentificationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionIdentificationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsNewRegisterTI;
    }
}