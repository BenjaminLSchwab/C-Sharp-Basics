using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Input a number or face the consequences.");
            bool validInput = false;
            string input = "";
            int number = 0;
            while (!validInput)
            {
                try
                {
                    input = Console.ReadLine();
                    number = Convert.ToInt32(input);
                    validInput = true;
                }
                catch
                {
                    Console.WriteLine("Whole numbers only!");
                    validInput = false;
                }
            }

            TimeSpan hours = TimeSpan.FromHours(number);

            Console.WriteLine("In {0} hours, it will be {1}", number, DateTime.Now + hours);
            Console.ReadLine();
        }
    }
}
