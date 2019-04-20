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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.InventoryReportModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpvInventario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductoBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.InventoryReportParamBS = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryReportModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryReportParamBS)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryReportModelBindingSource
            // 
            this.InventoryReportModelBindingSource.DataMember = "Inventory";
            this.InventoryReportModelBindingSource.DataSource = typeof(Facturando.Modelos.InventoryReportModel);
            // 
            // rpvInventario
            // 
            reportDataSource1.Name = "Inventory";
            reportDataSource1.Value = this.InventoryReportModelBindingSource;
            reportDataSource2.Name = "Parameters";
            reportDataSource2.Value = this.InventoryReportParamBS;
            this.rpvInventario.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvInventario.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvInventario.LocalReport.ReportEmbeddedResource = "Facturando.Reportes.Inventario.rdlc";
            this.rpvInventario.Location = new System.Drawing.Point(0, 51);
            this.rpvInventario.Name = "rpvInventario";
            this.rpvInventario.Size = new System.Drawing.Size(931, 690);
            this.rpvInventario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto a buscar:";
            // 
            // txtProductoBusqueda
            // 
            this.txtProductoBusqueda.Location = new System.Drawing.Point(116, 10);
            this.txtProductoBusqueda.Name = "txtProductoBusqueda";
            this.txtProductoBusqueda.Size = new System.Drawing.Size(274, 20);
            this.txtProductoBusqueda.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(411, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // InventoryReportParamBS
            // 
            this.InventoryReportParamBS.DataSource = typeof(Facturando.Modelos.InventoryReportParamsModel);
            // 
            // Alertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 741);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtProductoBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rpvInventario);
            this.Name = "Alertas";
            this.Text = "Alertas";
            this.Load += new System.EventHandler(this.Alertas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryReportModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryReportParamBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvInventario;
        private System.Windows.Forms.BindingSource InventoryReportModelBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductoBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource InventoryReportParamBS;
    }
}