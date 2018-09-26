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

                    if (input != 0)
                    {                       
                        foreach (int numerator in numerators)
                        {
                            Console.WriteLine(numerator/input);
                        }
                        finishedMath = true;
                    }
                    else
                    {
                        Console.WriteLine("Non-zero number please.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please input a number.");
                }
            }

            Console.WriteLine("Program outside Try/Catch");

            Console.ReadLine();
        }
    }
}
