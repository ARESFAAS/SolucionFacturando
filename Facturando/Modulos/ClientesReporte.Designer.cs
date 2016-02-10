namespace Facturando.Modulos
{
    partial class ClientesReporte
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
            this.rpvClientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClientReportModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ClientReportModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvClientes
            // 
            this.rpvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Clientes";
            reportDataSource1.Value = this.ClientReportModelBindingSource;
            this.rpvClientes.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvClientes.LocalReport.ReportEmbeddedResource = "Facturando.Reportes.Clientes.rdlc";
            this.rpvClientes.Location = new System.Drawing.Point(0, 0);
            this.rpvClientes.Name = "rpvClientes";
            this.rpvClientes.Size = new System.Drawing.Size(1127, 819);
            this.rpvClientes.TabIndex = 0;
            // 
            // ClientReportModelBindingSource
            // 
            this.ClientReportModelBindingSource.DataMember = "Client";
            this.ClientReportModelBindingSource.DataSource = typeof(Facturando.Modelos.ClientReportModel);
            // 
            // ClientesReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 819);
            this.Controls.Add(this.rpvClientes);
            this.Name = "ClientesReporte";
            this.Text = "ClientesReporte";
            this.Load += new System.EventHandler(this.ClientesReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientReportModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvClientes;
        private System.Windows.Forms.BindingSource ClientReportModelBindingSource;
    }
}