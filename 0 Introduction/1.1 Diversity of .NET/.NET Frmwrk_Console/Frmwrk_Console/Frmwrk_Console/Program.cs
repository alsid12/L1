using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frmwrk_Console
{
    class Program
    {
        private static void Main(string[] args)
        {
            //args[0] = Console.ReadLine();
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter your name.");
                args[0] = Console.ReadLine().ToString();
            }
            Console.WriteLine("Hello, {0}!", args[0]);
            Console.ReadKey();
        }
    }
}
