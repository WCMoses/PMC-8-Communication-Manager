using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IxosTest2
{
    public class RomFlasher
    {
        public string GetQuotedString(string s)
        {
            return "\"" + s + "\"";
        }
        public string FlashRom(string filePropeller, string fileEeprom)
        {
            string result = null;
            filePropeller = GetQuotedString(filePropeller);
            fileEeprom = GetQuotedString(fileEeprom) + " /eeprom";
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Console.WriteLine("Tryiny to ececute: " + filePropeller + " " + fileEeprom);
                ProcessStartInfo procStartInfo = new ProcessStartInfo(filePropeller, fileEeprom);
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;

                // wrap IDisposable into using (in order to release hProcess) 
                using (Process process = new Process())
                {
                    process.StartInfo = procStartInfo;
                    process.Start();

                    // Add this: wait until process does its work
                    process.WaitForExit();

                    // and only then read the result
                    result = process.StandardOutput.ReadToEnd();

                }
            }
            catch (Exception ex)
            {

                throw;
            }
            Cursor.Current = Cursors.Default;
            return result;

        }
    }
}
