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
                        if (lineTemp.Contains("{4"))
                        {
                            string lineDetailTemplate = lineTemp;
                            string lineDetailAux = lineDetailTemplate;

                            IDictionary<string, int> dynamicTemplateLine = lineTemp
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .ToDictionary(x => x.Replace("$", string.Empty), x => x.Replace("$", string.Empty).Length);
                                                        
                            foreach (var item in bill.BillDetail)
                            {
                                string keyItemTemp = string.Empty;
                                int keyItemSizeTemp = 0;

                                if(dynamicTemplateLine.Keys.Any(x => x.Contains("{4")))
                                {
                                    keyItemTemp = dynamicTemplateLine.Keys.Where(x => x.Contains("{4")).First();
                                    keyItemSizeTemp = dynamicTemplateLine[keyItemTemp];

                                    lineDetailAux = lineDetailAux
                                    .Replace(keyItemTemp, item.Product.Substring(0, item.Product.Length < keyItemSizeTemp ? item.Product.Length : keyItemSizeTemp)
                                    .PadRight(keyItemSizeTemp)); //product
                                }
                                if (dynamicTemplateLine.Keys.Any(x => x.Contains("{5")))
                                {
                                    keyItemTemp = dynamicTemplateLine.Keys.Where(x => x.Contains("{5")).First();
                                    keyItemSizeTemp = dynamicTemplateLine[keyItemTemp];

                                    lineDetailAux = lineDetailAux
                                    .Replace(keyItemTemp, item.Quantity.ToString().Substring(0, item.Quantity.ToString().Length < keyItemSizeTemp ? item.Quantity.ToString().Length : keyItemSizeTemp)
                                    .PadLeft(keyItemSizeTemp)); //quantity
                                }
                                if (dynamicTemplateLine.Keys.Any(x => x.Contains("{6")))
                                {
                                    keyItemTemp = dynamicTemplateLine.Keys.Where(x => x.Contains("{6")).First();
                                    keyItemSizeTemp = dynamicTemplateLine[keyItemTemp];

                                    lineDetailAux = lineDetailAux
                                    .Replace(keyItemTemp, item.UnitPrice.ToString(specifierFormat).Substring(0, item.UnitPrice.ToString(specifierFormat).Length < keyItemSizeTemp ? item.UnitPrice.ToString(specifierFormat).Length : keyItemSizeTemp)
                                    .PadLeft(keyItemSizeTemp)); //unit value
                                }
                                if (dynamicTemplateLine.Keys.Any(x => x.Contains("{7")))
                                {
                                    keyItemTemp = dynamicTemplateLine.Keys.Where(x => x.Contains("{7")).First();
                                    keyItemSizeTemp = dynamicTemplateLine[keyItemTemp];

                                    lineDetailAux = lineDetailAux
                                    .Replace(keyItemTemp, item.Total.ToString(specifierFormat).Substring(0, item.Total.ToString(specifierFormat).Length < keyItemSizeTemp ? item.Total.ToString(specifierFormat).Length : keyItemSizeTemp)
                                    .PadLeft(keyItemSizeTemp)); //total
                                }

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
            }
            catch (InvalidPrinterException)
            {
            }
            finally
            {
                printDocument.Dispose();
            }
        }

        public void printRemission(RemissionSaveModel remission) {

            var printDocument = new PrintDocument();
            printDocument.PrinterSettings.PrinterName = _printerName;
            try
            {
                string filePath = _docTemplatePath;
                string stringToPrint = string.Empty;
                string specifierFormat = "0,0.000";
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (sr.Peek() >= 0)
                    {
                        string lineTemp = sr.ReadLine();
                        if (lineTemp.Contains("{4"))
                        {
                            string lineDetailTemplate = lineTemp;
                            string lineDetailAux = lineDetailTemplate;

                            IDictionary<string, int> dynamicTemplateLine = lineTemp
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .ToDictionary(x => x.Replace("$", string.Empty), x => x.Replace("$", string.Empty).Length);

                            foreach (var item in remission.RemissionDetail)
                            {
                                string keyItemTemp = string.Empty;
                                int keyItemSizeTemp = 0;

                                if (dynamicTemplateLine.Keys.Any(x => x.Contains("{4")))
                                {
                                    keyItemTemp = dynamicTemplateLine.Keys.Where(x => x.Contains("{4")).First();
                                    keyItemSizeTemp = dynamicTemplateLine[keyItemTemp];

                                    lineDetailAux = lineDetailAux
                                    .Replace(keyItemTemp, item.Product.Substring(0, item.Product.Length < keyItemSizeTemp ? item.Product.Length : keyItemSizeTemp)
                                    .PadRight(keyItemSizeTemp)); //product
                                }
                                if (dynamicTemplateLine.Keys.Any(x => x.Contains("{5")))
                                {
                                    keyItemTemp = dynamicTemplateLine.Keys.Where(x => x.Contains("{5")).First();
                                    keyItemSizeTemp = dynamicTemplateLine[keyItemTemp];

                                    lineDetailAux = lineDetailAux
                                    .Replace(keyItemTemp, item.Quantity.ToString().Substring(0, item.Quantity.ToString().Length < keyItemSizeTemp ? item.Quantity.ToString().Length : keyItemSizeTemp)
                                    .PadLeft(keyItemSizeTemp)); //quantity
                                }
                                if (dynamicTemplateLine.Keys.Any(x => x.Contains("{6")))
                                {
                                    keyItemTemp = dynamicTemplateLine.Keys.Where(x => x.Contains("{6")).First();
                                    keyItemSizeTemp = dynamicTemplateLine[keyItemTemp];

                                    lineDetailAux = lineDetailAux
                                    .Replace(keyItemTemp, item.UnitPrice.ToString(specifierFormat).Substring(0, item.UnitPrice.ToString(specifierFormat).Length < keyItemSizeTemp ? item.UnitPrice.ToString(specifierFormat).Length : keyItemSizeTemp)
                                    .PadLeft(keyItemSizeTemp)); //unit value
                                }
                                if (dynamicTemplateLine.Keys.Any(x => x.Contains("{7")))
                                {
                                    keyItemTemp = dynamicTemplateLine.Keys.Where(x => x.Contains("{7")).First();
                                    keyItemSizeTemp = dynamicTemplateLine[keyItemTemp];

                                    lineDetailAux = lineDetailAux
                                    .Replace(keyItemTemp, item.Total.ToString(specifierFormat).Substring(0, item.Total.ToString(specifierFormat).Length < keyItemSizeTemp ? item.Total.ToString(specifierFormat).Length : keyItemSizeTemp)
                                    .PadLeft(keyItemSizeTemp)); //total
                                }

                                stringToPrint += lineDetailAux;
                                stringToPrint += Environment.NewLine;
                                lineDetailAux = lineDetailTemplate;
                            }
                        }
                        else if (lineTemp.Contains("{9}"))
                        {
                        }
                        else
                        {
                            stringToPrint += lineTemp;
                            stringToPrint += Environment.NewLine;
                        }
                    }
                }
            
                //replace remission values
                stringToPrint = stringToPrint
                    .Replace("{000000000}", remission.Remission.RemissionNumber.ToString()
                    .Substring(0, remission.Remission.RemissionNumber.ToString().Length < 11 ? remission.Remission.RemissionNumber.ToString().Length : 11)
                    .PadLeft(12 - remission.Remission.RemissionNumber.ToString().Substring(0, remission.Remission.RemissionNumber.ToString().Length < 12 ? remission.Remission.RemissionNumber.ToString().Length : 11).Length, '0'));//remission number
                stringToPrint = stringToPrint
                    .Replace("{111111111}", remission.Remission.DateEvent.ToString("dd/MM/yyyy").Substring(0, remission.Remission.DateEvent.ToString("dd/MM/yyyy").Length < 11 ? remission.Remission.DateEvent.ToString("dd/MM/yyyy").Length : 11)
                    .PadLeft(11 - remission.Remission.DateEvent.ToString("dd/MM/yyyy").Substring(0, remission.Remission.DateEvent.ToString("dd/MM/yyyy").Length < 11 ? remission.Remission.DateEvent.ToString("dd/MM/yyyy").Length : 11).Length, ' '));//date
                stringToPrint = stringToPrint
                    .Replace("{222222222222222222222}", remission.Client.Name.Substring(0, remission.Client.Name.Length < 23 ? remission.Client.Name.Length : 23)
                    .PadLeft(23 - remission.Client.Name.Substring(0, remission.Client.Name.Length < 23 ? remission.Client.Name.Length : 23).Length, ' '));//client name
                stringToPrint = stringToPrint
                    .Replace("{33333333333333}", remission.Client.IdentificationNumber.Substring(0, remission.Client.IdentificationNumber.Length < 16 ? remission.Client.IdentificationNumber.Length : 16)
                    .PadLeft(16 - remission.Client.IdentificationNumber.Substring(0, remission.Client.IdentificationNumber.Length < 16 ? remission.Client.IdentificationNumber.Length : 16).Length, ' '));//client id                
                stringToPrint = stringToPrint
                    .Replace("{bbbbbbbbbb}", remission.Remission.Total.ToString(specifierFormat).Substring(0, remission.Remission.Total.ToString(specifierFormat).Length < 12 ? remission.Remission.Total.ToString(specifierFormat).Length : 12)
                    .PadLeft(12 - remission.Remission.Total.ToString(specifierFormat).Substring(0, remission.Remission.Total.ToString(specifierFormat).Length < 12 ? remission.Remission.Total.ToString(specifierFormat).Length : 12).Length, ' ')); //total remission

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
            }
            catch (InvalidPrinterException)
            {
            }
            finally
            {
                printDocument.Dispose();
            }
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
