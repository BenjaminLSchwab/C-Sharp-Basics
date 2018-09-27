using System;

namespace Methods5
{
    class Program
    {
        static void Main()
        {
            Divider divider = new Divider();
            Console.WriteLine("Input a whole number to be divided by two.");
            int input = Convert.ToInt32(Console.ReadLine());
            int result;
            divider.DevideByTwo(input, out result);

            Console.WriteLine("Answer: {0}", result);

            Console.WriteLine("Input a whole number to be divided by three.");
            input = Convert.ToInt32(Console.ReadLine());
            int remainder;
            StaticDivider.DivideByThree(input, out result, out remainder);

            Console.WriteLine("Answer: {0}", result);
            Console.WriteLine("Remainder: {0}", remainder);

            Console.WriteLine("Input a floating point number to be divided by three.");
            float floatInput = Convert.ToSingle(Console.ReadLine());
            float floatResult;
            StaticDivider.DivideByThree(input, out floatResult);

            Console.WriteLine("Answer: {0}", floatResult);

            Console.ReadLine();
        }
    }
}
