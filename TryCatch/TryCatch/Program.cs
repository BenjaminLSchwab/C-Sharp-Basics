using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main()
        {
            int[] numerators = {5, 10, 15, 16, 27, 36, 54, 128, 293, 40112};

            Console.WriteLine("Input a number to be used in several divisions...");

            try
            {
                float input = Convert.ToSingle(Console.ReadLine());
            }
            catch(FormatException ex)
            {

            }
            catch(Exception ex)
            {

            }
        }
    }
}
