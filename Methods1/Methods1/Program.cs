using System;
using System.Threading;

namespace Methods1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("No time to explain, give me a number.");
            bool validInput = false;
            int input = 0;
            while (!validInput)
            {
                try
                {
                input = Convert.ToInt32(Console.ReadLine());
                    validInput = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Thats not a whole number, man. Try again.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Number after 1st operation:");
            input = Operations.AddThree(input);
            Console.WriteLine(Convert.ToString(input));

            Thread.Sleep(200);

            Console.WriteLine("Number after 2nd operation:");
            input = Operations.OneMoreThanHalf(input);
            Console.WriteLine(Convert.ToString(input));

            Thread.Sleep(200);

            Console.WriteLine("Number after 3rd operation:");
            input = Operations.PrettyClose(input);
            Console.WriteLine(Convert.ToString(input));




            Console.ReadLine();
        }
    }
}
