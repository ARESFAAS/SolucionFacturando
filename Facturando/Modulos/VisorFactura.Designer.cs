﻿namespace Facturando.Modulos
{
    partial class VisorFactura
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvwFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnNuevaFactura = new System.Windows.Forms.Button();
            this.billPrintModelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.billPrintModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billPrintModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.billPrintModelBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // rvwFactura
            // 
            reportDataSource5.Name = "BillDetail";
            reportDataSource5.Value = this.billPrintModelBindingSource2;
            reportDataSource6.Name = "Client";
            reportDataSource6.Value = this.billPrintModelBindingSource;
            reportDataSource7.Name = "Bill";
            reportDataSource7.Value = this.billPrintModelBindingSource1;
            reportDataSource8.Name = "BillTaxes";
            reportDataSource8.Value = this.billPrintModelBindingSource3;
            this.rvwFactura.LocalReport.DataSources.Add(reportDataSource5);
            this.rvwFactura.LocalReport.DataSources.Add(reportDataSource6);
            this.rvwFactura.LocalReport.DataSources.Add(reportDataSource7);
            this.rvwFactura.LocalReport.DataSources.Add(reportDataSource8);
            this.rvwFactura.LocalReport.ReportEmbeddedResource = "Facturando.Reportes.FacturaImpresa.rdlc";
            this.rvwFactura.Location = new System.Drawing.Point(13, 13);
            this.rvwFactura.Name = "rvwFactura";
            this.rvwFactura.Size = new System.Drawing.Size(706, 744);
            this.rvwFactura.TabIndex = 0;
            // 
            // btnNuevaFactura
            // 
            this.btnNuevaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaFactura.Location = new System.Drawing.Point(397, 763);
            this.btnNuevaFactura.Name = "btnNuevaFactura";
            this.btnNuevaFactura.Size = new System.Drawing.Size(322, 35);
            this.btnNuevaFactura.TabIndex = 1;
            this.btnNuevaFactura.Text = "GUARDAR FACTURA";
            this.btnNuevaFactura.UseVisualStyleBackColor = true;
            this.btnNuevaFactura.Click += new System.EventHandler(this.btnNuevaFactura_Click);
            // 
            // billPrintModelBindingSource2
            // 
            this.billPrintModelBindingSource2.DataMember = "BillDetail";
            this.billPrintModelBindingSource2.DataSource = typeof(Facturando.Modelos.BillPrintModel);
            // 
            // billPrintModelBindingSource
            // 
            this.billPrintModelBindingSource.DataMember = "Client";
            this.billPrintModelBindingSource.DataSource = typeof(Facturando.Modelos.BillPrintModel);
            // 
            // billPrintModelBindingSource1
            // 
            this.billPrintModelBindingSource1.DataMember = "Bill";
            this.billPrintModelBindingSource1.DataSource = typeof(Facturando.Modelos.BillPrintModel);
            // 
            // billPrintModelBindingSource3
            // 
            this.billPrintModelBindingSource3.DataMember = "BillTaxes";
            this.billPrintModelBindingSource3.DataSource = typeof(Facturando.Modelos.BillPrintModel);
            // 
            // VisorFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 810);
            this.Controls.Add(this.btnNuevaFactura);
            this.Controls.Add(this.rvwFactura);
            this.Name = "VisorFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisorFactura";
            this.Load += new System.EventHandler(this.VisorFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwFactura;
        private System.Windows.Forms.BindingSource billPrintModelBindingSource;
        private System.Windows.Forms.BindingSource billPrintModelBindingSource1;
        private System.Windows.Forms.BindingSource billPrintModelBindingSource2;
        private System.Windows.Forms.BindingSource billPrintModelBindingSource3;
        private System.Windows.Forms.Button btnNuevaFactura;
    }
}