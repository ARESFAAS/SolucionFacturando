using Facturando.Data;
using Facturando.Helper;
using Facturando.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturando.Modulos
{
    public partial class CargarInventario : BaseForm
    {
        public CargarInventario()
        {
            InitializeComponent();
        }

        private void CargarInventario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                button2.Enabled = true;
                button1.Enabled = false;
                progressBar1.Value = 0;
                progressBar1.Refresh();             
            }
        }
               
        private void button2_Click(object sender, EventArgs e)
        {            
            this.backgroundWorker1.RunWorkerAsync(textBox1.Text);
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {           
            textBox2.Text = string.Format(@"C:\Facturando-files\PlantillaCargaMasivaInventario_{0}.txt", DateTime.Now.ToString("yyyyMMddHHmmss") );
            ExternalFileHelper.CreateTabularFile(textBox2.Text);
            this.backgroundWorker2.RunWorkerAsync(textBox2.Text);
            button1.Enabled = true;
            button3.Enabled = false;                       
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Do not access the form's BackgroundWorker reference directly.
            // Instead, use the reference provided by the sender parameter.
            BackgroundWorker bw = sender as BackgroundWorker;

            // Extract the argument.
            string arg = (string)e.Argument;

            // Start the time-consuming operation.
            //e.Result = TimeConsumingOperation(bw, arg);
            string[] fileLines = ExternalFileHelper.ReadTabularFile(arg);
            char[] separator = new char[1];
            separator[0] = Convert.ToChar(9);
            List<InventoryModel> inventoryModelTemp = new List<InventoryModel>();
            Guid productKeyTemp = Guid.NewGuid();
            int indexTemp = 0;

            int percentageTemp = Convert.ToInt32((fileLines.LongLength * 3) / 100);

            foreach (var line in fileLines)
            {
                if (indexTemp > 0)
                {
                    string[] registerTemp = line.Split(separator);
                    inventoryModelTemp.Add(new InventoryModel
                    {
                        IdProduct = !string.IsNullOrEmpty(registerTemp[0]) ? Guid.Parse(registerTemp[0]) : productKeyTemp,
                        Product = registerTemp[1].Trim(),
                        Quantity = !string.IsNullOrEmpty(registerTemp[2]) ? int.Parse(registerTemp[2].Trim()) : 0,
                        LastPurchasePrice = !string.IsNullOrEmpty(registerTemp[3]) ? decimal.Parse(registerTemp[3].Trim()) : 0,
                        LastSalePrice = !string.IsNullOrEmpty(registerTemp[4]) ? decimal.Parse(registerTemp[4].Trim()) : 0,
                        FreeProduct = registerTemp[5].Trim().ToLower().Equals("si") ? true : false,
                    });
                }
                if ((indexTemp > percentageTemp) && percentageTemp < 100)
                {
                    backgroundWorker1.ReportProgress(percentageTemp);
                    percentageTemp = percentageTemp + indexTemp;
                }
                else
                {
                    backgroundWorker1.ReportProgress(100);
                }
                indexTemp++;
            }


            InventoryInterface inventoryData = new InventoryData();
            bool resultadoCarga = inventoryData.LoadInventoryTemp(inventoryModelTemp);

            // If the operation was canceled by the user, 
            // set the DoWorkEventArgs.Cancel property to true.
            if (bw.CancellationPending || !resultadoCarga)
            {
                e.Cancel = true;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // The user canceled the operation.
                MessageBox.Show("Operation was canceled");
            }
            else if (e.Error != null)
            {
                // There was an error during the operation.
                string msg = String.Format("An error occurred: {0}", e.Error.Message);
                MessageBox.Show(msg);
            }
            else
            {
                // The operation completed normally.
                //string msg = String.Format("Resultado = {0}", e.Result);
                MessageBox.Show("!!!Se actualizó el inventario!!!");
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            progressBar1.Value = e.ProgressPercentage;
        }
        
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            // Do not access the form's BackgroundWorker reference directly.
            // Instead, use the reference provided by the sender parameter.
            BackgroundWorker bw = sender as BackgroundWorker;

            // Extract the argument.
            string arg = (string)e.Argument;

            // Start the time-consuming operation.
            char[] separator = new char[1];
            separator[0] = Convert.ToChar(9);
            List<InventoryModel> inventoryModelTemp = new List<InventoryModel>();
            int indexTemp = 0;

            InventoryInterface inventoryData = new InventoryData();
            List<InventoryModel> inventoryTemp = inventoryData.GetInventoryForBatchUpdate(null);
            int percentageTemp = Convert.ToInt32((inventoryTemp.Count * 3) / 100);            

            string[] lineTemp = new string[6];
            lineTemp[0] = "IdSistema";
            lineTemp[1] = "Producto";
            lineTemp[2] = "Cantidad";
            lineTemp[3] = "PrecioCompra";
            lineTemp[4] = "PrecioVenta";
            lineTemp[5] = "Exento";
            string lineTemplate = string.Join(separator[0].ToString(), lineTemp);

            using (StreamWriter file = new StreamWriter(arg, true))
            {
                file.WriteLine(lineTemplate);
                foreach (var item in inventoryTemp)
                {
                    lineTemp = new string[6];
                    lineTemp[0] = item.IdProduct.ToString();
                    lineTemp[1] = item.Product;
                    lineTemp[2] = item.Quantity.ToString();
                    lineTemp[3] = item.LastPurchasePrice.ToString();
                    lineTemp[4] = item.LastSalePrice.ToString();
                    lineTemp[5] = item.FreeProduct ? "SI" : "NO";

                    file.WriteLine(string.Join(separator[0].ToString(), lineTemp));

                    if ((indexTemp > percentageTemp) && percentageTemp < 100)
                    {
                        backgroundWorker2.ReportProgress(percentageTemp);
                        percentageTemp = percentageTemp + indexTemp;
                    }
                    else
                    {
                        backgroundWorker2.ReportProgress(100);
                    }

                    indexTemp++;
                }
            }            

            // If the operation was canceled by the user, 
            // set the DoWorkEventArgs.Cancel property to true.
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // The user canceled the operation.
                MessageBox.Show("Operation was canceled");
            }
            else if (e.Error != null)
            {
                // There was an error during the operation.
                string msg = String.Format("An error occurred: {0}", e.Error.Message);
                MessageBox.Show(msg);
            }
            else
            {
                // The operation completed normally.
                //string msg = String.Format("Resultado = {0}", e.Result);
                MessageBox.Show("!!!Se descargó el inventario!!!");
            }
        }
    }
}
