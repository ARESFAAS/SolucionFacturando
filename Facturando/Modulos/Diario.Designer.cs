namespace Facturando.Modulos
{
    partial class Diario
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
            this.DailyReportModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpvDiario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaConsulta = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DailyReportModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DailyReportModelBindingSource
            // 
            this.DailyReportModelBindingSource.DataMember = "Daily";
            this.DailyReportModelBindingSource.DataSource = typeof(Facturando.Modelos.DailyReportModel);
            // 
            // rpvDiario
            // 
            reportDataSource1.Name = "Diario";
            reportDataSource1.Value = this.DailyReportModelBindingSource;
            this.rpvDiario.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvDiario.LocalReport.ReportEmbeddedResource = "Facturando.Reportes.Diario.rdlc";
            this.rpvDiario.Location = new System.Drawing.Point(0, 48);
            this.rpvDiario.Name = "rpvDiario";
            this.rpvDiario.Size = new System.Drawing.Size(1127, 685);
            this.rpvDiario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha Consulta: ";
            // 
            // dtpFechaConsulta
            // 
            this.dtpFechaConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaConsulta.Location = new System.Drawing.Point(106, 7);
            this.dtpFechaConsulta.Name = "dtpFechaConsulta";
            this.dtpFechaConsulta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaConsulta.TabIndex = 2;
            this.dtpFechaConsulta.ValueChanged += new System.EventHandler(this.dtpFechaConsulta_ValueChanged);
            // 
            // Diario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 733);
            this.Controls.Add(this.dtpFechaConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rpvDiario);
            this.Name = "Diario";
            this.Text = "Diario";
            this.Load += new System.EventHandler(this.Diario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DailyReportModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvDiario;
        private System.Windows.Forms.BindingSource DailyReportModelBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaConsulta;
    }
}