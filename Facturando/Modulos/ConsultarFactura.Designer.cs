namespace Facturando.Modulos
{
    partial class ConsultarFactura
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtgFactura = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentificationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalInLetters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCanceled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CancelDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WatchBill = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factura";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(85, 23);
            this.txtFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(182, 26);
            this.txtFactura.TabIndex = 1;
            this.txtFactura.Leave += new System.EventHandler(this.txtFactura_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificación";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(395, 23);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(214, 26);
            this.txtIdentificacion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Desde";
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "dd/MM/yyyy";
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(723, 26);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(118, 26);
            this.dtpDesde.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(865, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hasta";
            // 
            // dtpFin
            // 
            this.dtpFin.CustomFormat = "dd/MM/yyyy";
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFin.Location = new System.Drawing.Point(945, 26);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(118, 26);
            this.dtpFin.TabIndex = 7;
            // 
            // dtgFactura
            // 
            this.dtgFactura.AllowUserToAddRows = false;
            this.dtgFactura.AllowUserToDeleteRows = false;
            this.dtgFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BillNumber,
            this.DateEvent,
            this.Total,
            this.NameClient,
            this.IdentificationNumber,
            this.IdClient,
            this.TotalInLetters,
            this.IsCanceled,
            this.CancelDate,
            this.WatchBill});
            this.dtgFactura.Location = new System.Drawing.Point(13, 77);
            this.dtgFactura.Name = "dtgFactura";
            this.dtgFactura.Size = new System.Drawing.Size(1071, 660);
            this.dtgFactura.TabIndex = 8;
            this.dtgFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFactura_CellContentClick);
            this.dtgFactura.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFactura_CellValueChanged);
            this.dtgFactura.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgFactura_DataError);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // BillNumber
            // 
            this.BillNumber.DataPropertyName = "BillNumber";
            this.BillNumber.HeaderText = "Número Factura";
            this.BillNumber.Name = "BillNumber";
            this.BillNumber.ReadOnly = true;
            this.BillNumber.Width = 136;
            // 
            // DateEvent
            // 
            this.DateEvent.DataPropertyName = "DateEvent";
            this.DateEvent.HeaderText = "Fecha Creación";
            this.DateEvent.Name = "DateEvent";
            this.DateEvent.ReadOnly = true;
            this.DateEvent.Width = 133;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 69;
            // 
            // NameClient
            // 
            this.NameClient.DataPropertyName = "Name";
            this.NameClient.HeaderText = "Cliente";
            this.NameClient.Name = "NameClient";
            this.NameClient.ReadOnly = true;
            this.NameClient.Width = 83;
            // 
            // IdentificationNumber
            // 
            this.IdentificationNumber.DataPropertyName = "IdentificationNumber";
            this.IdentificationNumber.HeaderText = "Identificación";
            this.IdentificationNumber.Name = "IdentificationNumber";
            this.IdentificationNumber.ReadOnly = true;
            this.IdentificationNumber.Width = 128;
            // 
            // IdClient
            // 
            this.IdClient.DataPropertyName = "IdClient";
            this.IdClient.HeaderText = "IdClient";
            this.IdClient.Name = "IdClient";
            this.IdClient.Visible = false;
            // 
            // TotalInLetters
            // 
            this.TotalInLetters.DataPropertyName = "TotalInLetters";
            this.TotalInLetters.HeaderText = "Total en letras";
            this.TotalInLetters.Name = "TotalInLetters";
            this.TotalInLetters.Visible = false;
            // 
            // IsCanceled
            // 
            this.IsCanceled.DataPropertyName = "IsCanceled";
            this.IsCanceled.FalseValue = "false";
            this.IsCanceled.HeaderText = "Anulada";
            this.IsCanceled.IndeterminateValue = "false";
            this.IsCanceled.Name = "IsCanceled";
            this.IsCanceled.TrueValue = "true";
            this.IsCanceled.Width = 74;
            // 
            // CancelDate
            // 
            this.CancelDate.DataPropertyName = "CancelDate";
            this.CancelDate.HeaderText = "Fecha de Anulación";
            this.CancelDate.Name = "CancelDate";
            this.CancelDate.ReadOnly = true;
            this.CancelDate.Width = 159;
            // 
            // WatchBill
            // 
            this.WatchBill.DataPropertyName = "WatchBill";
            this.WatchBill.HeaderText = "";
            this.WatchBill.Name = "WatchBill";
            this.WatchBill.Text = "Ver";
            this.WatchBill.UseColumnTextForButtonValue = true;
            this.WatchBill.Width = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(984, 757);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 36);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(17, 757);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(108, 35);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // ConsultarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 816);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtgFactura);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsultarFactura";
            this.Text = "Consultar Factura";
            this.Load += new System.EventHandler(this.ConsultarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DataGridView dtgFactura;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentificationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalInLetters;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsCanceled;
        private System.Windows.Forms.DataGridViewTextBoxColumn CancelDate;
        private System.Windows.Forms.DataGridViewButtonColumn WatchBill;
    }
}