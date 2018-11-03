using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Str_to_Int
{
    public static class StringToInt32
    {
        public static Int32 StrToInt_wConvert(string input)
        {
            try
            {
                return Convert.ToInt32(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Inside FormatException block");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType().ToString());
                Console.WriteLine("The provided string cannot be converted to integer.");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong. Original error message: {0}", e.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Inside finally block");
            }
        }
    }
}
