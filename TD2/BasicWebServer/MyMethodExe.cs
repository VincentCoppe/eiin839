﻿using System.Diagnostics;
using System.IO;

namespace BasicServerHTTPlistener
{
    internal class MyMethodExe
    {
        /*
        *  Change this to your url to the project
        */
        public static string url_to_exe = @"D:\SI4_TD\SOC\eiin839\TD2";

        public static string MyMethod(string param1, string param2)
        {

            //get the result for the execution of MyMethod.exe
            //Create the HTML result 
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = url_to_exe + @"\MyMethod\bin\Debug\MyMethod.exe"; // Specify exe name.
            start.Arguments = param1 + " " + param2; // Specify arguments.
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

    }
}