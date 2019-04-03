namespace Facturando.Modulos
{
    partial class Caja
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
            this.AbrirCaja = new System.Windows.Forms.Button();
            this.dtgCaja = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CashNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsClosed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IdUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditCashBox = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CloseCashBox = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtgCajaDetalle = new System.Windows.Forms.DataGridView();
            this.IdCashBoxDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCashBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovementDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CashBoxTypeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMovement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCashBoxType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentsCashBoxDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMediosPago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.lblTotalCaja = new System.Windows.Forms.Label();
            this.lblTotalRemisiones = new System.Windows.Forms.Label();
            this.lblTotalFacturas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCajaDetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AbrirCaja
            // 
            this.AbrirCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbrirCaja.Location = new System.Drawing.Point(12, 12);
            this.AbrirCaja.Name = "AbrirCaja";
            this.AbrirCaja.Size = new System.Drawing.Size(98, 35);
            this.AbrirCaja.TabIndex = 0;
            this.AbrirCaja.Text = "Abrir Caja";
            this.AbrirCaja.UseVisualStyleBackColor = true;
            this.AbrirCaja.Click += new System.EventHandler(this.AbrirCaja_Click);
            // 
            // dtgCaja
            // 
            this.dtgCaja.AllowUserToAddRows = false;
            this.dtgCaja.AllowUserToDeleteRows = false;
            this.dtgCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CashNumber,
            this.Total,
            this.OpenDate,
            this.CloseTotal,
            this.CloseDate,
            this.IsClosed,
            this.IdUser,
            this.Comments,
            this.EditCashBox,
            this.CloseCashBox});
            this.dtgCaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCaja.Location = new System.Drawing.Point(3, 16);
            this.dtgCaja.Name = "dtgCaja";
            this.dtgCaja.ReadOnly = true;
            this.dtgCaja.Size = new System.Drawing.Size(840, 228);
            this.dtgCaja.TabIndex = 4;
            this.dtgCaja.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCaja_CellContentClick);
            this.dtgCaja.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgCaja_RowHeaderMouseClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // CashNumber
            // 
            this.CashNumber.DataPropertyName = "CashNumber";
            this.CashNumber.HeaderText = "Caja";
            this.CashNumber.Name = "CashNumber";
            this.CashNumber.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Valor Apertura";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // OpenDate
            // 
            this.OpenDate.DataPropertyName = "OpenDate";
            this.OpenDate.HeaderText = "Fecha Apertura";
            this.OpenDate.Name = "OpenDate";
            this.OpenDate.ReadOnly = true;
            // 
            // CloseTotal
            // 
            this.CloseTotal.DataPropertyName = "CloseTotal";
            this.CloseTotal.HeaderText = "Valor Cierre";
            this.CloseTotal.Name = "CloseTotal";
            this.CloseTotal.ReadOnly = true;
            // 
            // CloseDate
            // 
            this.CloseDate.DataPropertyName = "CloseDate";
            this.CloseDate.HeaderText = "Fecha Cierre";
            this.CloseDate.Name = "CloseDate";
            this.CloseDate.ReadOnly = true;
            // 
            // IsClosed
            // 
            this.IsClosed.DataPropertyName = "IsClosed";
            this.IsClosed.FalseValue = "False";
            this.IsClosed.HeaderText = "Caja Cerrada";
            this.IsClosed.Name = "IsClosed";
            this.IsClosed.ReadOnly = true;
            this.IsClosed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsClosed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsClosed.TrueValue = "True";
            // 
            // IdUser
            // 
            this.IdUser.DataPropertyName = "IdUser";
            this.IdUser.HeaderText = "Usuario";
            this.IdUser.Name = "IdUser";
            this.IdUser.ReadOnly = true;
            this.IdUser.Visible = false;
            // 
            // Comments
            // 
            this.Comments.DataPropertyName = "Comments";
            this.Comments.HeaderText = "Comentarios";
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            // 
            // EditCashBox
            // 
            this.EditCashBox.DataPropertyName = "EditCashBox";
            this.EditCashBox.HeaderText = "";
            this.EditCashBox.Name = "EditCashBox";
            this.EditCashBox.ReadOnly = true;
            this.EditCashBox.Text = "Editar";
            this.EditCashBox.UseColumnTextForButtonValue = true;
            // 
            // CloseCashBox
            // 
            this.CloseCashBox.DataPropertyName = "CloseCashBox";
            this.CloseCashBox.HeaderText = "";
            this.CloseCashBox.Name = "CloseCashBox";
            this.CloseCashBox.ReadOnly = true;
            this.CloseCashBox.Text = "Cerrar";
            this.CloseCashBox.UseColumnTextForButtonValue = true;
            // 
            // dtgCajaDetalle
            // 
            this.dtgCajaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCajaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCashBoxDetail,
            this.IdCashBox,
            this.MovementDate,
            this.CashBoxTypeDescription,
            this.TotalMovement,
            this.IdCashBoxType,
            this.CommentsCashBoxDetail});
            this.dtgCajaDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCajaDetalle.Location = new System.Drawing.Point(3, 16);
            this.dtgCajaDetalle.Name = "dtgCajaDetalle";
            this.dtgCajaDetalle.Size = new System.Drawing.Size(437, 220);
            this.dtgCajaDetalle.TabIndex = 5;
            // 
            // IdCashBoxDetail
            // 
            this.IdCashBoxDetail.DataPropertyName = "Id";
            this.IdCashBoxDetail.HeaderText = "Id";
            this.IdCashBoxDetail.Name = "IdCashBoxDetail";
            this.IdCashBoxDetail.ReadOnly = true;
            this.IdCashBoxDetail.Visible = false;
            // 
            // IdCashBox
            // 
            this.IdCashBox.DataPropertyName = "IdCashBox";
            this.IdCashBox.HeaderText = "IdCashBox";
            this.IdCashBox.Name = "IdCashBox";
            this.IdCashBox.ReadOnly = true;
            this.IdCashBox.Visible = false;
            // 
            // MovementDate
            // 
            this.MovementDate.DataPropertyName = "MovementDate";
            this.MovementDate.HeaderText = "Fecha";
            this.MovementDate.Name = "MovementDate";
            this.MovementDate.ReadOnly = true;
            // 
            // CashBoxTypeDescription
            // 
            this.CashBoxTypeDescription.DataPropertyName = "CashBoxTypeDescription";
            this.CashBoxTypeDescription.HeaderText = "Tipo Movimiento";
            this.CashBoxTypeDescription.Name = "CashBoxTypeDescription";
            this.CashBoxTypeDescription.ReadOnly = true;
            // 
            // TotalMovement
            // 
            this.TotalMovement.DataPropertyName = "Total";
            this.TotalMovement.HeaderText = "Total";
            this.TotalMovement.Name = "TotalMovement";
            this.TotalMovement.ReadOnly = true;
            // 
            // IdCashBoxType
            // 
            this.IdCashBoxType.DataPropertyName = "IdCashBoxType";
            this.IdCashBoxType.HeaderText = "IdCashBoxType";
            this.IdCashBoxType.Name = "IdCashBoxType";
            this.IdCashBoxType.ReadOnly = true;
            this.IdCashBoxType.Visible = false;
            // 
            // CommentsCashBoxDetail
            // 
            this.CommentsCashBoxDetail.DataPropertyName = "Comments";
            this.CommentsCashBoxDetail.HeaderText = "Comentarios";
            this.CommentsCashBoxDetail.Name = "CommentsCashBoxDetail";
            this.CommentsCashBoxDetail.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtMediosPago);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCash);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.lblDiferencia);
            this.groupBox1.Controls.Add(this.lblTotalCaja);
            this.groupBox1.Controls.Add(this.lblTotalRemisiones);
            this.groupBox1.Controls.Add(this.lblTotalFacturas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(461, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 236);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONTROL CAJA";
            // 
            // txtMediosPago
            // 
            this.txtMediosPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediosPago.Location = new System.Drawing.Point(155, 129);
            this.txtMediosPago.Name = "txtMediosPago";
            this.txtMediosPago.Size = new System.Drawing.Size(224, 21);
            this.txtMediosPago.TabIndex = 12;
            this.txtMediosPago.Leave += new System.EventHandler(this.txtMediosPago_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Medios Pago:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(155, 104);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(224, 21);
            this.txtCash.TabIndex = 10;
            this.txtCash.Leave += new System.EventHandler(this.txtCash_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Efectivo:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtObservaciones.Location = new System.Drawing.Point(21, 196);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ReadOnly = true;
            this.txtObservaciones.Size = new System.Drawing.Size(358, 34);
            this.txtObservaciones.TabIndex = 8;
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.AutoSize = true;
            this.lblDiferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiferencia.Location = new System.Drawing.Point(152, 169);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(14, 15);
            this.lblDiferencia.TabIndex = 7;
            this.lblDiferencia.Text = "0";
            // 
            // lblTotalCaja
            // 
            this.lblTotalCaja.AutoSize = true;
            this.lblTotalCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCaja.Location = new System.Drawing.Point(152, 80);
            this.lblTotalCaja.Name = "lblTotalCaja";
            this.lblTotalCaja.Size = new System.Drawing.Size(41, 15);
            this.lblTotalCaja.TabIndex = 6;
            this.lblTotalCaja.Text = "label7";
            // 
            // lblTotalRemisiones
            // 
            this.lblTotalRemisiones.AutoSize = true;
            this.lblTotalRemisiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRemisiones.Location = new System.Drawing.Point(152, 47);
            this.lblTotalRemisiones.Name = "lblTotalRemisiones";
            this.lblTotalRemisiones.Size = new System.Drawing.Size(41, 15);
            this.lblTotalRemisiones.TabIndex = 5;
            this.lblTotalRemisiones.Text = "label6";
            // 
            // lblTotalFacturas
            // 
            this.lblTotalFacturas.AutoSize = true;
            this.lblTotalFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFacturas.Location = new System.Drawing.Point(152, 23);
            this.lblTotalFacturas.Name = "lblTotalFacturas";
            this.lblTotalFacturas.Size = new System.Drawing.Size(41, 15);
            this.lblTotalFacturas.TabIndex = 4;
            this.lblTotalFacturas.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "DIFERENCIA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Movimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Remisiones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Facturas:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgCaja);
            this.groupBox2.Location = new System.Drawing.Point(12, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 247);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CAJA";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgCajaDetalle);
            this.groupBox3.Location = new System.Drawing.Point(12, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 239);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DETALLE CAJA";
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(870, 557);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AbrirCaja);
            this.Name = "Caja";
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.Caja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCajaDetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AbrirCaja;
        private System.Windows.Forms.DataGridView dtgCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CashNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpenDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CloseTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CloseDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsClosed;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewButtonColumn EditCashBox;
        private System.Windows.Forms.DataGridViewButtonColumn CloseCashBox;
        private System.Windows.Forms.DataGridView dtgCajaDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCashBoxDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCashBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovementDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CashBoxTypeDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMovement;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCashBoxType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentsCashBoxDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDiferencia;
        private System.Windows.Forms.Label lblTotalCaja;
        private System.Windows.Forms.Label lblTotalRemisiones;
        private System.Windows.Forms.Label lblTotalFacturas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMediosPago;
    }
}