﻿using Facturando.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturando.Modulos
{
    public partial class VisorRemisionMediaCarta : Form
    {
        RemissionPrintModel _remission = new RemissionPrintModel();
        public VisorRemisionMediaCarta()
        {
            InitializeComponent();
        }

        public VisorRemisionMediaCarta(RemissionSaveModel remission)
        {
            InitializeComponent();
            _remission.Client = new List<ClientModel>();
            _remission.Client.Add(remission.Client);
            _remission.Remission = new List<RemissionModel>();
            _remission.Remission.Add(remission.Remission);
            _remission.RemissionDetail = remission.RemissionDetail;
            _remission.RemissionText = new List<RemissionText>();
            _remission.RemissionText.Add(AppText.Instance.AppTextData.RemissionData);
        }

        public VisorRemisionMediaCarta(RemissionSaveModel remission, bool readOnly)
        {
            InitializeComponent();
            _remission.Client = new List<ClientModel>();
            _remission.Client.Add(remission.Client);
            _remission.Remission = new List<RemissionModel>();
            _remission.Remission.Add(remission.Remission);
            _remission.RemissionDetail = remission.RemissionDetail;
            _remission.RemissionText = new List<RemissionText>();
            _remission.RemissionText.Add(AppText.Instance.AppTextData.RemissionData);

            btnNuevaRemision.Enabled = false;
        }

        private void VisorRemisionMediaCarta_Load(object sender, EventArgs e)
        {                      
            remissionPrintModelBindingSource1.DataSource = _remission.Client;
            remissionPrintModelBindingSource2.DataSource = _remission.Remission;
            remissionPrintModelBindingSource3.DataSource = _remission.RemissionDetail;
            remissionPrintModelBindingSource.DataSource = _remission.RemissionText;
            rpwRemision.RefreshReport();
        }

        private void btnNuevaRemision_Click(object sender, EventArgs e)
        {
            IFormRemission formInterface = Owner.Controls.Find("Remision", true).FirstOrDefault() as IFormRemission;

            if (formInterface != null)
            {
                formInterface.NewRemission();
            }
            Close();
        }
    }
}
