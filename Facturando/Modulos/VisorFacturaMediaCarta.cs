﻿using Facturando.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturando.Modulos
{
    public partial class VisorFacturaMediaCarta : BaseForm
    {
        BillPrintModel _bill = new BillPrintModel();

        public VisorFacturaMediaCarta()
        {
            InitializeComponent();
        }

        public VisorFacturaMediaCarta(BillSaveModel bill)
        {
            InitializeComponent();
            _bill.Client = new List<ClientModel>();
            _bill.Client.Add(bill.Client);
            _bill.Bill = new List<BillModel>();
            _bill.Bill.Add(bill.Bill);
            _bill.BillDetail = bill.BillDetail;
            _bill.BillTaxes = bill.BillTaxes;
            _bill.BillText = new List<BillText>();
            _bill.BillText.Add(AppText.Instance.AppTextData.BillData);
        }

        public VisorFacturaMediaCarta(BillSaveModel bill, bool readOnly)
        {
            InitializeComponent();
            _bill.Client = new List<ClientModel>();
            _bill.Client.Add(bill.Client);
            _bill.Bill = new List<BillModel>();
            _bill.Bill.Add(bill.Bill);
            _bill.BillDetail = bill.BillDetail;
            _bill.BillTaxes = bill.BillTaxes;
            _bill.BillText = new List<BillText>();
            _bill.BillText.Add(AppText.Instance.AppTextData.BillData);

            btnNuevaFactura.Enabled = false;
        }

        private void VisorFacturaMediaCarta_Load(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
            billPrintModelBindingSource.DataSource = _bill.Client;
            billPrintModelBindingSource1.DataSource = _bill.Bill;
            billPrintModelBindingSource2.DataSource = _bill.BillDetail;
            billPrintModelBindingSource3.DataSource = _bill.BillTaxes;
            billPrintModelBindingSource4.DataSource = _bill.BillText;
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            IFormBill formInterface = Owner.Controls.Find("Facturacion", true).FirstOrDefault() as IFormBill;

            if (formInterface != null)
            {
                formInterface.NewBill();
            }
            Close();
        }
    }
}