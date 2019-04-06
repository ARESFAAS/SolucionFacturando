using Facturando.Modelos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturando.Helper
{
    public class ThermalPrinterHelper
    {
        private static string _printerName = string.Empty;
        private static string _docTemplatePath = string.Empty;
        public ThermalPrinterHelper(string printerName, string docTemplatePath)
        {
            _printerName = printerName;
            _docTemplatePath = docTemplatePath;          
        }

        public void printBill(BillSaveModel bill) {

            var printDocument = new PrintDocument();
            printDocument.PrinterSettings.PrinterName = _printerName;
            //printDocument.PrinterSettings.PrinterName = "Microsoft XPS Document Writer";
            //printDocument.PrinterSettings.PrinterName = "SAT SAT38TUSE";
            //printDocument.PrinterSettings.DefaultPageSettings.Margins.Left = 0;
            //printDocument.PrinterSettings.DefaultPageSettings.Margins.Top = 0;
            //printDocument.PrinterSettings.DefaultPageSettings.Margins.Right = 0;
            //printDocument.PrinterSettings.DefaultPageSettings.Margins.Bottom = 0;
            //sprintDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 595, 842);
            //printDocument.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            try
            {
                // This sample assumes that you have a folder named "c:\temp" on your computer.
                string filePath = _docTemplatePath;
                string stringToPrint = string.Empty;
                string specifierFormat = "0,0.000";
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (sr.Peek() >= 0)
                    {
                        string lineTemp = sr.ReadLine();
                        if (lineTemp.Contains("{444444444444}"))
                        {
                            string lineDetailTemplate = lineTemp;
                            string lineDetailAux = lineDetailTemplate;
                            foreach (var item in bill.BillDetail)
                            {
                                lineDetailAux = lineDetailAux
                                .Replace("{444444444444}", item.Product.Substring(0, item.Product.Length < 14 ? item.Product.Length : 14)
                                .PadLeft(14 - item.Product.Substring(0, item.Product.Length < 14 ? item.Product.Length : 14).Length, ' ')); //product
                                lineDetailAux = lineDetailAux
                                .Replace("{5}", item.Quantity.ToString().Substring(0, item.Quantity.ToString().Length < 3 ? item.Quantity.ToString().Length : 3)
                                .PadLeft(3 - item.Quantity.ToString().Substring(0, item.Quantity.ToString().Length < 3 ? item.Quantity.ToString().Length : 3).Length, ' ')); //quantity
                                lineDetailAux = lineDetailAux
                                .Replace("{6666666666}", item.UnitPrice.ToString(specifierFormat).Substring(0, item.UnitPrice.ToString(specifierFormat).Length < 12 ? item.UnitPrice.ToString(specifierFormat).Length : 12)
                                .PadLeft(12 - item.UnitPrice.ToString(specifierFormat).Substring(0, item.UnitPrice.ToString(specifierFormat).Length < 12 ? item.UnitPrice.ToString(specifierFormat).Length : 12).Length, ' ')); //unit value
                                lineDetailAux = lineDetailAux
                                .Replace("{7777777777}", item.Total.ToString(specifierFormat).Substring(0, item.Total.ToString(specifierFormat).Length < 12 ? item.Total.ToString(specifierFormat).Length : 12)
                                .PadLeft(12 - item.Total.ToString(specifierFormat).Substring(0, item.Total.ToString(specifierFormat).Length < 12 ? item.Total.ToString(specifierFormat).Length : 12).Length, ' ')); //total
                                                               
                                stringToPrint += lineDetailAux;
                                stringToPrint += Environment.NewLine;
                                lineDetailAux = lineDetailTemplate;
                            }
                        }
                        else if (lineTemp.Contains("{9}"))
                        {
                            string lineDetailTemplate = lineTemp;
                            string lineDetailAux = lineDetailTemplate;
                            foreach (var item in bill.BillTaxes)
                            {
                                lineDetailAux = lineDetailAux                               
                                .Replace("{9}", item.PercentageValue.ToString().Substring(0, item.PercentageValue.ToString().Length < 3 ? item.PercentageValue.ToString().Length : 3)
                                .PadLeft(3 - item.PercentageValue.ToString().Substring(0, 2).Length, ' ')); //tax percent
                                lineDetailAux = lineDetailAux
                                .Replace("{aaaaaaaaaa}", item.Total.ToString(specifierFormat).Substring(0, item.Total.ToString(specifierFormat).Length < 12 ? item.Total.ToString(specifierFormat).Length : 12)
                                .PadLeft(12 - item.Total.ToString(specifierFormat).Substring(0, item.Total.ToString(specifierFormat).Length < 12 ? item.Total.ToString(specifierFormat).Length : 12).Length, ' ')); //tax value                                

                                stringToPrint += lineDetailAux;
                                stringToPrint += Environment.NewLine;
                                lineDetailAux = lineDetailTemplate;
                            }
                        }
                        else
                        {
                            stringToPrint += lineTemp;
                            stringToPrint += Environment.NewLine;
                        }
                    }
                }

                // Open the stream and read it back.
                //using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read))
                //{
                //    byte[] b = new byte[1024];
                //    UTF8Encoding temp = new UTF8Encoding(true);

                //    while (fs.Read(b, 0, b.Length) > 0)
                //    {
                //        string lineTemp = temp.GetString(b);
                //        if (lineTemp.Contains("{444444444444}"))
                //        {
                //            string lineDetailTemplate = lineTemp;
                //            string lineDetailAux = lineDetailTemplate;
                //            foreach (var item in bill.BillDetail)
                //            {                                
                //                lineDetailAux = lineDetailAux
                //                .Replace("{444444444444}", item.Product.Substring(0, item.Product.Length < 14 ? item.Product.Length : 14)
                //                .PadLeft(14 - item.Product.Substring(0, item.Product.Length < 14 ? item.Product.Length : 14).Length, ' ')); //product
                //                lineDetailAux = lineDetailAux
                //                .Replace("{5}", item.Quantity.ToString().Substring(0, item.Quantity.ToString().Length < 3 ? item.Quantity.ToString().Length : 3)
                //                .PadLeft(3 - item.Quantity.ToString().Substring(0, item.Quantity.ToString().Length < 3 ? item.Quantity.ToString().Length : 3).Length, ' ')); //quantity
                //                lineDetailAux = lineDetailAux
                //                .Replace("{6666666666}", item.UnitPrice.ToString().Substring(0, item.UnitPrice.ToString().Length < 12 ? item.UnitPrice.ToString().Length : 12)
                //                .PadLeft(12 - item.UnitPrice.ToString().Substring(0, item.UnitPrice.ToString().Length < 12 ? item.UnitPrice.ToString().Length : 12).Length, ' ')); //unit value
                //                lineDetailAux = lineDetailAux
                //                .Replace("{7777777777}", item.Total.ToString().Substring(0, item.Total.ToString().Length < 12 ? item.Total.ToString().Length : 12)
                //                .PadLeft(12 - item.Total.ToString().Substring(0, item.Total.ToString().Length < 12 ? item.Total.ToString().Length : 12).Length, ' ')); //total

                //                //lineTemp = lineDetailAux;
                //                stringToPrint += lineDetailAux;
                //                lineDetailAux = lineDetailTemplate;
                //            }
                //        }
                //        //if (lineTemp.Contains("{9}"))
                //        //{
                //        //    foreach (var item in bill.BillTaxes)
                //        //    {
                //        //        lineTemp = lineTemp
                //        //        .Replace("{9}", item.PercentageValue.ToString().Substring(0, item.PercentageValue.ToString().Length < 3 ? item.PercentageValue.ToString().Length : 3)
                //        //        .PadLeft(3 - item.PercentageValue.ToString().Substring(0, 2).Length, ' ')); //tax percent
                //        //        lineTemp = lineTemp
                //        //        .Replace("{aaaaaaaaaa}", item.Total.ToString().Substring(0, item.Total.ToString().Length < 12 ? item.Total.ToString().Length : 12)
                //        //        .PadLeft(12 - item.Total.ToString().Substring(0, item.Total.ToString().Length < 12 ? item.Total.ToString().Length : 12).Length, ' ')); //tax value                                
                //        //    }
                //        //}
                //        stringToPrint += lineTemp;
                //        //Console.WriteLine(temp.GetString(b));
                //    }
                //    try
                //    {
                //        // Try to write to the file.
                //        fs.Write(b, 0, b.Length);
                //    }
                //    catch (Exception ex)
                //    {
                //        Console.WriteLine("Writing was disallowed, as expected: {0}", ex.ToString());
                //    }
                //}
                
                //replace bill values
                stringToPrint = stringToPrint
                    .Replace("{000000000}", bill.Bill.BillNumber.ToString()                    
                    .Substring(0, bill.Bill.BillNumber.ToString().Length < 11 ? bill.Bill.BillNumber.ToString().Length : 11)
                    .PadLeft(12 - bill.Bill.BillNumber.ToString().Substring(0, bill.Bill.BillNumber.ToString().Length < 12 ? bill.Bill.BillNumber.ToString().Length : 11).Length, '0'));//bill number
                stringToPrint = stringToPrint
                    .Replace("{111111111}", bill.Bill.DateEvent.ToString("dd/MM/yyyy").Substring(0, bill.Bill.DateEvent.ToString("dd/MM/yyyy").Length < 11 ? bill.Bill.DateEvent.ToString("dd/MM/yyyy").Length : 11)
                    .PadLeft(11 - bill.Bill.DateEvent.ToString("dd/MM/yyyy").Substring(0, bill.Bill.DateEvent.ToString("dd/MM/yyyy").Length < 11 ? bill.Bill.DateEvent.ToString("dd/MM/yyyy").Length : 11).Length, ' '));//date
                stringToPrint = stringToPrint
                    .Replace("{222222222222222222222}", bill.Client.Name.Substring(0, bill.Client.Name.Length < 23 ? bill.Client.Name.Length : 23)
                    .PadLeft(23 - bill.Client.Name.Substring(0, bill.Client.Name.Length < 23 ? bill.Client.Name.Length : 23).Length, ' '));//client name
                stringToPrint = stringToPrint
                    .Replace("{33333333333333}", bill.Client.IdentificationNumber.Substring(0, bill.Client.IdentificationNumber.Length < 16 ? bill.Client.IdentificationNumber.Length : 16)
                    .PadLeft(16 - bill.Client.IdentificationNumber.Substring(0, bill.Client.IdentificationNumber.Length < 16 ? bill.Client.IdentificationNumber.Length : 16).Length, ' '));//client id                
                stringToPrint = stringToPrint
                    .Replace("{8888888888}", bill.Bill.SubTotal.ToString(specifierFormat).Substring(0, bill.Bill.SubTotal.ToString(specifierFormat).Length < 12 ? bill.Bill.SubTotal.ToString(specifierFormat).Length : 12)
                    .PadLeft(12 - bill.Bill.SubTotal.ToString(specifierFormat).Substring(0, bill.Bill.SubTotal.ToString(specifierFormat).Length < 12 ? bill.Bill.SubTotal.ToString(specifierFormat).Length : 12).Length, ' ')); //subtotal               
                stringToPrint = stringToPrint
                    .Replace("{bbbbbbbbbb}", bill.Bill.Total.ToString(specifierFormat).Substring(0, bill.Bill.Total.ToString(specifierFormat).Length < 12 ? bill.Bill.Total.ToString(specifierFormat).Length : 12)
                    .PadLeft(12 - bill.Bill.Total.ToString(specifierFormat).Substring(0, bill.Bill.Total.ToString(specifierFormat).Length < 12 ? bill.Bill.Total.ToString(specifierFormat).Length : 12).Length, ' ')); //total bill

                //command to cut paper
                string GS = Convert.ToString((char)29);
                string ESC = Convert.ToString((char)27);
                string COMMAND = "";
                COMMAND = ESC + "@";
                COMMAND += GS + "V" + (char)1;
                stringToPrint += COMMAND;
                //command to open cash drawer
                var commandCash =
                Char.ConvertFromUtf32(16) +
                Char.ConvertFromUtf32(20) +
                Char.ConvertFromUtf32(1) +
                Char.ConvertFromUtf32(0) +
                Char.ConvertFromUtf32(3);
                stringToPrint += commandCash;
                // Print the file to the printer.
                RawPrinterHelper.SendStringToPrinter(printDocument.PrinterSettings.PrinterName, stringToPrint);
                //printDocument.Print();
            }
            catch (InvalidPrinterException)
            {
            }
            finally
            {
                printDocument.Dispose();
            }
        }

        public void printRemission() {
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            StringBuilder stringToPrintBuider = new StringBuilder();
            stringToPrintBuider.AppendLine("                    TEST PRINTER!!!                            ");
            stringToPrintBuider.AppendLine("                      HOLA MUNDO                               ");
            stringToPrintBuider.AppendLine("            Esta es una prueba de impresion termica            ");
            stringToPrintBuider.AppendLine("---------------------------------------------------------------");
            stringToPrintBuider.AppendLine("Item                          Cnt. Vlr.Unit       Total        ");
            stringToPrintBuider.AppendLine("Esta es una prueba de impres  1    1234567890.00  1234567890.00");
            stringToPrintBuider.AppendLine("---------------------------------------------------------------");
            stringToPrintBuider.AppendLine();
            string stringToPrint = stringToPrintBuider.ToString();

            Font printFont = new Font("Arial", 8, FontStyle.Regular);

            int charactersOnPage = 0;
            int linesPerPage = 0;

            ev.Graphics.MeasureString(stringToPrint, printFont,
                ev.MarginBounds.Size, StringFormat.GenericDefault,
                out charactersOnPage, out linesPerPage);

            ev.Graphics.DrawString(stringToPrint, printFont, Brushes.Black,
                ev.MarginBounds, StringFormat.GenericTypographic);

            stringToPrint = stringToPrint.Substring(charactersOnPage);

            ev.HasMorePages = (stringToPrint.Length > 0);
            //ev.HasMorePages = false;
        }
    }
}
