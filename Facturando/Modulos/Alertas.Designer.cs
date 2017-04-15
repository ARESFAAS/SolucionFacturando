namespace Facturando
{
    partial class Alertas
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
            this.InventoryReportModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpvInventario = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryReportModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryReportModelBindingSource
            // 
            this.InventoryReportModelBindingSource.DataMember = "Inventory";
            this.InventoryReportModelBindingSource.DataSource = typeof(Facturando.Modelos.InventoryReportModel);
            // 
            // rpvInventario
            // 
            this.rpvInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Inventory";
            reportDataSource1.Value = this.InventoryReportModelBindingSource;
            this.rpvInventario.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvInventario.LocalReport.ReportEmbeddedResource = "Facturando.Reportes.Inventario.rdlc";
            this.rpvInventario.Location = new System.Drawing.Point(0, 0);
            this.rpvInventario.Name = "rpvInventario";
            this.rpvInventario.Size = new System.Drawing.Size(931, 741);
            this.rpvInventario.TabIndex = 0;
            // 
            // Alertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 741);
            this.Controls.Add(this.rpvInventario);
            this.Name = "Alertas";
            this.Text = "Alertas";
            this.Load += new System.EventHandler(this.Alertas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryReportModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvInventario;
        private System.Windows.Forms.BindingSource InventoryReportModelBindingSource;
    }
}