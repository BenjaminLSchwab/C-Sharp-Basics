using System;


namespace Structs
{
    class Program
    {
        static void Main()
        {
            Number number = new Number();
            number.Amount = 2;
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }

    struct Number
    {
        public decimal Amount { get; set; }
    }
}
