﻿using Facturando.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturando
{
    public partial class Alertas : BaseForm
    {
        public Alertas()
        {
            InitializeComponent();
        }

        private void Alertas_Load(object sender, EventArgs e)
        {
            IReport report = new ReportData();
            InventoryReportModelBindingSource.DataSource = report.GetInventory();
            this.rpvInventario.RefreshReport();
        }
    }
}
