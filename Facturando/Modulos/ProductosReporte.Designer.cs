namespace Facturando.Modulos
{
    partial class ProductosReporte
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
            this.rpvProducto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProductReportModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProductReportModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvProducto
            // 
            this.rpvProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Productos";
            reportDataSource1.Value = this.ProductReportModelBindingSource;
            this.rpvProducto.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvProducto.LocalReport.ReportEmbeddedResource = "Facturando.Reportes.Productos.rdlc";
            this.rpvProducto.Location = new System.Drawing.Point(0, 0);
            this.rpvProducto.Name = "rpvProducto";
            this.rpvProducto.Size = new System.Drawing.Size(980, 800);
            this.rpvProducto.TabIndex = 0;
            // 
            // ProductReportModelBindingSource
            // 
            this.ProductReportModelBindingSource.DataMember = "Product";
            this.ProductReportModelBindingSource.DataSource = typeof(Facturando.Modelos.ProductReportModel);
            // 
            // ProductosReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 800);
            this.Controls.Add(this.rpvProducto);
            this.Name = "ProductosReporte";
            this.Text = "ProductosReporte";
            this.Load += new System.EventHandler(this.ProductosReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductReportModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvProducto;
        private System.Windows.Forms.BindingSource ProductReportModelBindingSource;
    }
}