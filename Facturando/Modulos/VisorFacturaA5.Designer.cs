namespace Facturando.Modulos
{
    partial class VisorFacturaA5
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.billPrintModelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.billPrintModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billPrintModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.billPrintModelBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.billPrintModelBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.rvwFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnNuevaFactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource4)).BeginInit();
            this.SuspendLayout();
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
            // billPrintModelBindingSource4
            // 
            this.billPrintModelBindingSource4.DataMember = "BillText";
            this.billPrintModelBindingSource4.DataSource = typeof(Facturando.Modelos.BillPrintModel);
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
            reportDataSource5.Name = "BillText";
            reportDataSource5.Value = this.billPrintModelBindingSource4;
            this.rvwFactura.LocalReport.DataSources.Add(reportDataSource1);
            this.rvwFactura.LocalReport.DataSources.Add(reportDataSource2);
            this.rvwFactura.LocalReport.DataSources.Add(reportDataSource3);
            this.rvwFactura.LocalReport.DataSources.Add(reportDataSource4);
            this.rvwFactura.LocalReport.DataSources.Add(reportDataSource5);
            this.rvwFactura.LocalReport.ReportEmbeddedResource = "Facturando.Reportes.FacturaImpresaA5.rdlc";
            this.rvwFactura.Location = new System.Drawing.Point(13, 13);
            this.rvwFactura.Name = "rvwFactura";
            this.rvwFactura.Size = new System.Drawing.Size(695, 603);
            this.rvwFactura.TabIndex = 0;
            this.rvwFactura.PrintingBegin += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.rvwFactura_PrintingBegin);
            // 
            // btnNuevaFactura
            // 
            this.btnNuevaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaFactura.Location = new System.Drawing.Point(386, 622);
            this.btnNuevaFactura.Name = "btnNuevaFactura";
            this.btnNuevaFactura.Size = new System.Drawing.Size(322, 35);
            this.btnNuevaFactura.TabIndex = 2;
            this.btnNuevaFactura.Text = "GUARDAR FACTURA";
            this.btnNuevaFactura.UseVisualStyleBackColor = true;
            this.btnNuevaFactura.Click += new System.EventHandler(this.btnNuevaFactura_Click);
            // 
            // VisorFacturaA5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 668);
            this.Controls.Add(this.btnNuevaFactura);
            this.Controls.Add(this.rvwFactura);
            this.Name = "VisorFacturaA5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisorFacturaA5";
            this.Load += new System.EventHandler(this.VisorFacturaA5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPrintModelBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwFactura;
        private System.Windows.Forms.BindingSource billPrintModelBindingSource;
        private System.Windows.Forms.Button btnNuevaFactura;
        private System.Windows.Forms.BindingSource billPrintModelBindingSource1;
        private System.Windows.Forms.BindingSource billPrintModelBindingSource2;
        private System.Windows.Forms.BindingSource billPrintModelBindingSource3;
        private System.Windows.Forms.BindingSource billPrintModelBindingSource4;
    }
}