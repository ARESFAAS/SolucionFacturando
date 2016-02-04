namespace Facturando.Modulos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvwFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.billPrintModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billPrintModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.billPrintModelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.billPrintModelBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // rvwFactura
            // 
            reportDataSource1.Name = "BillDetail";
            reportDataSource1.Value = this.billPrintModelBindingSource2;
            reportDataSource2.Name = "Client";
            reportDataSource2.Value = this.billPrintModelBindingSource;
            reportDataSource3.Name = "Bill";
            reportDataSource3.Value = this.billPrintModelBindingSource1;
            reportDataSource4.Name = "BillTaxes";
            reportDataSource4.Value = this.billPrintModelBindingSource3;
            this.rvwFactura.LocalReport.DataSources.Add(reportDataSource1);
            this.rvwFactura.LocalReport.DataSources.Add(reportDataSource2);
            this.rvwFactura.LocalReport.DataSources.Add(reportDataSource3);
            this.rvwFactura.LocalReport.DataSources.Add(reportDataSource4);
            this.rvwFactura.LocalReport.ReportEmbeddedResource = "Facturando.Reportes.FacturaImpresa.rdlc";
            this.rvwFactura.Location = new System.Drawing.Point(13, 13);
            this.rvwFactura.Name = "rvwFactura";
            this.rvwFactura.Size = new System.Drawing.Size(706, 744);
            this.rvwFactura.TabIndex = 0;
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
            // billPrintModelBindingSource2
            // 
            this.billPrintModelBindingSource2.DataMember = "BillDetail";
            this.billPrintModelBindingSource2.DataSource = typeof(Facturando.Modelos.BillPrintModel);
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
            this.ClientSize = new System.Drawing.Size(731, 769);
            this.Controls.Add(this.rvwFactura);
            this.Name = "VisorFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisorFactura";
            this.Load += new System.EventHandler(this.VisorFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwFactura;
        private System.Windows.Forms.BindingSource billPrintModelBindingSource;
        private System.Windows.Forms.BindingSource billPrintModelBindingSource1;
        private System.Windows.Forms.BindingSource billPrintModelBindingSource2;
        private System.Windows.Forms.BindingSource billPrintModelBindingSource3;
    }
}