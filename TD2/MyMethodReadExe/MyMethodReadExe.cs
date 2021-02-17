using System;
using System.Diagnostics;
using System.IO;

namespace MyMethodReadExe
{
    class MyMethodReadExe
    {
        static string MyMethodExe(string param1, string param2)
        {

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"D:\SI4_TD\SOC\eiin839\TD2\MyMethod\bin\Debug\MyMethod.exe"; // Specify exe name.
            start.Arguments = param1 + " " +param2; // Specify arguments.
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            //
            // Start the process.
            //
            using (Process process = Process.Start(start))
            {
                //
                // Read in all the text from the process with the StreamReader.
                //
                using (StreamReader reader = process.StandardOutput)
                {
                    return reader.ReadToEnd();

                }
            }
        }

        static void Main(string[] args)
        {
            // just to test the function 
            Console.WriteLine(MyMethodReadExe.MyMethodExe("test", "eeee"));
        }
    }
}
