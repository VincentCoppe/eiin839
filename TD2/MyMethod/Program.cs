using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                //Create the HTML From the arguments 
                Console.WriteLine("<HTML><BODY> Hello " + args[0] + " " + args[1] + "</HTML></BODY>");


            }
            else
                Console.WriteLine("MyMethodExe <string parameter>");
        }
    }
}
