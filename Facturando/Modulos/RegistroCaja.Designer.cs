namespace Facturando.Modulos
{
    partial class RegistroCaja
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
            this.txtValorCaja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFechaMovimiento = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardarRegistroCaja = new System.Windows.Forms.Button();
            this.cmbTipoRegistro = new System.Windows.Forms.ComboBox();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            // 
            // txtValorCaja
            // 
            this.txtValorCaja.Location = new System.Drawing.Point(118, 94);
            this.txtValorCaja.Name = "txtValorCaja";
            this.txtValorCaja.Size = new System.Drawing.Size(219, 20);
            this.txtValorCaja.TabIndex = 1;
            this.txtValorCaja.Leave += new System.EventHandler(this.txtValorCaja_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Movimiento:";
            // 
            // lblFechaMovimiento
            // 
            this.lblFechaMovimiento.AutoSize = true;
            this.lblFechaMovimiento.Location = new System.Drawing.Point(115, 28);
            this.lblFechaMovimiento.Name = "lblFechaMovimiento";
            this.lblFechaMovimiento.Size = new System.Drawing.Size(101, 13);
            this.lblFechaMovimiento.TabIndex = 3;
            this.lblFechaMovimiento.Text = "lblFechaMovimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo Registro:";
            // 
            // btnGuardarRegistroCaja
            // 
            this.btnGuardarRegistroCaja.Location = new System.Drawing.Point(262, 221);
            this.btnGuardarRegistroCaja.Name = "btnGuardarRegistroCaja";
            this.btnGuardarRegistroCaja.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarRegistroCaja.TabIndex = 5;
            this.btnGuardarRegistroCaja.Text = "Guardar";
            this.btnGuardarRegistroCaja.UseVisualStyleBackColor = true;
            this.btnGuardarRegistroCaja.Click += new System.EventHandler(this.btnGuardarRegistroCaja_Click);
            // 
            // cmbTipoRegistro
            // 
            this.cmbTipoRegistro.FormattingEnabled = true;
            this.cmbTipoRegistro.Location = new System.Drawing.Point(118, 59);
            this.cmbTipoRegistro.Name = "cmbTipoRegistro";
            this.cmbTipoRegistro.Size = new System.Drawing.Size(219, 21);
            this.cmbTipoRegistro.TabIndex = 6;
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(118, 132);
            this.txtComentarios.MaxLength = 255;
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(219, 67);
            this.txtComentarios.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Comentarios:";
            // 
            // RegistroCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 265);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.cmbTipoRegistro);
            this.Controls.Add(this.btnGuardarRegistroCaja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFechaMovimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorCaja);
            this.Controls.Add(this.label1);
            this.Name = "RegistroCaja";
            this.Text = "RegistroCaja";
            this.Load += new System.EventHandler(this.RegistroCaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorCaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFechaMovimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardarRegistroCaja;
        private System.Windows.Forms.ComboBox cmbTipoRegistro;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label label3;
    }
}