namespace Facturando.Modulos
{
    partial class ConsultarRemision
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
            this.dtgRemision = new System.Windows.Forms.DataGridView();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemision = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemissionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentificationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalInLetters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WatchRemission = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRemision)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgRemision
            // 
            this.dtgRemision.AllowUserToAddRows = false;
            this.dtgRemision.AllowUserToDeleteRows = false;
            this.dtgRemision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgRemision.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgRemision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRemision.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.RemissionNumber,
            this.DateEvent,
            this.Total,
            this.NameClient,
            this.IdentificationNumber,
            this.TotalInLetters,
            this.IdClient,
            this.WatchRemission});
            this.dtgRemision.Location = new System.Drawing.Point(13, 77);
            this.dtgRemision.Name = "dtgRemision";
            this.dtgRemision.ReadOnly = true;
            this.dtgRemision.Size = new System.Drawing.Size(1076, 665);
            this.dtgRemision.TabIndex = 0;
            this.dtgRemision.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRemision_CellContentClick);
            this.dtgRemision.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgRemision_DataError);
            // 
            // dtpFin
            // 
            this.dtpFin.CustomFormat = "dd/MM/yyyy";
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFin.Location = new System.Drawing.Point(962, 27);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(118, 26);
            this.dtpFin.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(882, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Hasta";
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "dd/MM/yyyy";
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(740, 27);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(118, 26);
            this.dtpDesde.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(658, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Desde";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(412, 24);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(214, 26);
            this.txtIdentificacion.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Identificación";
            // 
            // txtRemision
            // 
            this.txtRemision.Location = new System.Drawing.Point(102, 24);
            this.txtRemision.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRemision.Name = "txtRemision";
            this.txtRemision.Size = new System.Drawing.Size(182, 26);
            this.txtRemision.TabIndex = 9;
            this.txtRemision.Leave += new System.EventHandler(this.txtRemision_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Remisión";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(13, 769);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(108, 35);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
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
            // RemissionNumber
            // 
            this.RemissionNumber.DataPropertyName = "RemissionNumber";
            this.RemissionNumber.HeaderText = "Número Remisión";
            this.RemissionNumber.Name = "RemissionNumber";
            this.RemissionNumber.ReadOnly = true;
            this.RemissionNumber.Width = 146;
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
            this.NameClient.HeaderText = "Client";
            this.NameClient.Name = "NameClient";
            this.NameClient.ReadOnly = true;
            this.NameClient.Width = 74;
            // 
            // IdentificationNumber
            // 
            this.IdentificationNumber.DataPropertyName = "IdentificationNumber";
            this.IdentificationNumber.HeaderText = "Identificación";
            this.IdentificationNumber.Name = "IdentificationNumber";
            this.IdentificationNumber.ReadOnly = true;
            this.IdentificationNumber.Width = 128;
            // 
            // TotalInLetters
            // 
            this.TotalInLetters.DataPropertyName = "TotalInLetters";
            this.TotalInLetters.HeaderText = "TotalInLetters";
            this.TotalInLetters.Name = "TotalInLetters";
            this.TotalInLetters.ReadOnly = true;
            this.TotalInLetters.Visible = false;
            this.TotalInLetters.Width = 133;
            // 
            // IdClient
            // 
            this.IdClient.DataPropertyName = "IdClient";
            this.IdClient.HeaderText = "IdClient";
            this.IdClient.Name = "IdClient";
            this.IdClient.ReadOnly = true;
            this.IdClient.Visible = false;
            this.IdClient.Width = 88;
            // 
            // WatchRemission
            // 
            this.WatchRemission.DataPropertyName = "WatchRemission";
            this.WatchRemission.HeaderText = "";
            this.WatchRemission.Name = "WatchRemission";
            this.WatchRemission.ReadOnly = true;
            this.WatchRemission.Text = "Ver";
            this.WatchRemission.UseColumnTextForButtonValue = true;
            this.WatchRemission.Width = 5;
            // 
            // ConsultarRemision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 816);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRemision);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgRemision);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsultarRemision";
            this.Text = "ConsultarRemision";
            this.Load += new System.EventHandler(this.ConsultarRemision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRemision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgRemision;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemissionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentificationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalInLetters;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClient;
        private System.Windows.Forms.DataGridViewButtonColumn WatchRemission;
    }
}