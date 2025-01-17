using System;
using System.Diagnostics;

namespace All_In_One.src.Utilities.Office_Windows
{
    public class OW
    {
        public void Active()
        {
            try
            {
                // docscument Link : https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.processstartinfo?view=net-8.0
                // setup ProcessStartInfo
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "powershell.exe", // run PowerShell
                    Arguments = "-Command \"iex (irm https://get.activated.win)\"",// run command
                    RedirectStandardOutput = true,// Show output
                    RedirectStandardError = true, // Debug
                    UseShellExecute = false,
                    CreateNoWindow = true // not show powershell
                };

                // Khởi động process
                using (Process process = Process.Start(startInfo))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit(); 

                    if (!string.IsNullOrEmpty(error))
                    {
                        Console.WriteLine("Error:");
                        Console.WriteLine(error);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
            }
        }
    }
}
