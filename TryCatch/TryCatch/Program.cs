using System;

namespace TryCatch
{
    class Program
    {
        static void Main()
        {
            int[] numerators = {5, 10, 15, 16, 27, 36, 54, 128, 293, 40112};

            Console.WriteLine("Input a number to be used in several divisions...");

            bool finishedMath = false;
            while (!finishedMath)
            {
                try
                {
                    float input = Convert.ToSingle(Console.ReadLine());
                    foreach (int numerator in numerators)
                    {
                        Console.WriteLine(numerator/input);
                    }
                    finishedMath = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please input a number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);                   
                }
            }

            Console.WriteLine("Program outside Try/Catch");

            Console.ReadLine();
        }
    }
}
