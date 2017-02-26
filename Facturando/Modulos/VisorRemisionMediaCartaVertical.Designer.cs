namespace Facturando.Modulos
{
    partial class VisorRemisionMediaCartaVertical
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
            this.remissionPrintModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.remissionPrintModelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.remissionPrintModelBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.remissionPrintModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnNuevaRemision = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.remissionPrintModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remissionPrintModelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remissionPrintModelBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remissionPrintModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // remissionPrintModelBindingSource1
            // 
            this.remissionPrintModelBindingSource1.DataSource = typeof(Facturando.Modelos.RemissionPrintModel);
            // 
            // remissionPrintModelBindingSource2
            // 
            this.remissionPrintModelBindingSource2.DataSource = typeof(Facturando.Modelos.RemissionPrintModel);
            // 
            // remissionPrintModelBindingSource3
            // 
            this.remissionPrintModelBindingSource3.DataSource = typeof(Facturando.Modelos.RemissionPrintModel);
            // 
            // remissionPrintModelBindingSource
            // 
            this.remissionPrintModelBindingSource.DataSource = typeof(Facturando.Modelos.RemissionPrintModel);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Client";
            reportDataSource1.Value = this.remissionPrintModelBindingSource1;
            reportDataSource2.Name = "Remission";
            reportDataSource2.Value = this.remissionPrintModelBindingSource2;
            reportDataSource3.Name = "RemissionDetail";
            reportDataSource3.Value = this.remissionPrintModelBindingSource3;
            reportDataSource4.Name = "RemissionText";
            reportDataSource4.Value = this.remissionPrintModelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Facturando.Reportes.RemisionImpresaMediaCartaVertical.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(860, 593);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.PrintingBegin += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.reportViewer1_PrintingBegin);
            // 
            // btnNuevaRemision
            // 
            this.btnNuevaRemision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaRemision.Location = new System.Drawing.Point(550, 621);
            this.btnNuevaRemision.Name = "btnNuevaRemision";
            this.btnNuevaRemision.Size = new System.Drawing.Size(322, 35);
            this.btnNuevaRemision.TabIndex = 1;
            this.btnNuevaRemision.Text = "GUARDAR REMISION";
            this.btnNuevaRemision.UseVisualStyleBackColor = true;
            this.btnNuevaRemision.Click += new System.EventHandler(this.btnNuevaRemision_Click);
            // 
            // VisorRemisionMediaCartaVertical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 668);
            this.Controls.Add(this.btnNuevaRemision);
            this.Controls.Add(this.reportViewer1);
            this.Name = "VisorRemisionMediaCartaVertical";
            this.Text = "VisorRemisionMediaCartaVertical";
            this.Load += new System.EventHandler(this.VisorRemisionMediaCartaVertical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.remissionPrintModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remissionPrintModelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remissionPrintModelBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remissionPrintModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnNuevaRemision;
        private System.Windows.Forms.BindingSource remissionPrintModelBindingSource1;
        private System.Windows.Forms.BindingSource remissionPrintModelBindingSource2;
        private System.Windows.Forms.BindingSource remissionPrintModelBindingSource3;
        private System.Windows.Forms.BindingSource remissionPrintModelBindingSource;
    }
}