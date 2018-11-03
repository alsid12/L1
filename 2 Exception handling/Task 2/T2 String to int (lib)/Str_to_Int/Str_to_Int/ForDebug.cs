using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Str_to_Int
{
    class ForDebug
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to string converter app!");
            Console.WriteLine("Please supply the string supposed to be converted to integer number:");
            string inp = Console.ReadLine();
            Console.WriteLine("The resulting number is: {0}.", StringToInt32.StrToInt_wConvert(inp).ToString());
            //Console.WriteLine("The resulting number is: {0}.", String_to_Int32(inp));
            //Test1();
            //Parse_with_Regex();
            Console.ReadKey();

            //string myPattern = @"[0-9]";
        }
    }
}
