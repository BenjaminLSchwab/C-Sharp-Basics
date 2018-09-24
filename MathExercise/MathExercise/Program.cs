using System;

namespace MathExercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("1. Input a number...");
            float input = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(input * 50);

            Console.WriteLine("2. Input a number...");
            input = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(input + 25);

            Console.WriteLine("3. Input a number...");
            input = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(input/12.5f);

            Console.WriteLine("4. Input a number...");
            input = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(input > 50);

            Console.WriteLine("5. Input a number...");
            input = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(input % 7);

            Console.ReadLine();
        }
    }
}
