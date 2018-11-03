using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Str_to_Int;

namespace String_to_Int
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to string parser app!");
            Console.WriteLine("Please supply the string supposed to be converted to integer number:");
            string inp = Console.ReadLine();
            try
            {
                Console.WriteLine("The resulting number is: {0}.", Str_to_Int.StringToInt32.StrToInt_wConvert(inp).ToString());
                Console.WriteLine("Press any button to exit.");
            }
            catch (Exception e)
            {
                Console.WriteLine("The original error message: {0}", e.Message);
                //throw;
            }
            Console.WriteLine("Press any button to exit.");
            Console.ReadKey();
        }
    }
}
