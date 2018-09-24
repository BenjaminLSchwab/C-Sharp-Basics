using System;

namespace Insurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            byte age = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            byte tickets = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && !hasDUI && tickets < 4);

            Console.ReadLine();
        }
    }
}
