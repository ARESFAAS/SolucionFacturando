using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturando.Helper
{
    public static class ExternalFileHelper
    {
        public static string[] ReadTabularFile(string path)
        {
            string[] lines = null;
            try
            {
                // Read each line of the file into a string array. Each element
                // of the array is one line of the file.
                // string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\WriteLines2.txt");
                lines = File.ReadAllLines(path);

                return lines;
            }
            catch (Exception ex)
            {
                throw ex;
            }                            
        }

        public static void CreateTabularFile(string path)
        {
            try
            {

                // Delete the file if it exists.
                if (File.Exists(path))
                {
                    // Note that no lock is put on the
                    // file and the possibility exists
                    // that another process could do
                    // something with it between
                    // the calls to Exists and Delete.
                    File.Delete(path);
                }

                using (FileStream fs = File.Create(path)) { }

                // Create the file.
                //using (FileStream fs = File.Create(path))
                //{
                //    Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                //    // Add some information to the file.
                //    fs.Write(info, 0, info.Length);
                //}               
            }
            catch (Exception)
            {               
            }
        } 
    }
}
