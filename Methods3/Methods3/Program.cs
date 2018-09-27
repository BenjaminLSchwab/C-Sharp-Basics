using System;

namespace Methods3
{
    class Program
    {
        static void Main()
        {
            Overloads overloads1 = new Overloads();
            int firstInput = 2;
            Console.WriteLine(overloads1.DoMath(firstInput));

            Overloads overloads2 = new Overloads();
            decimal secondInput = 4.32M;
            Console.WriteLine(overloads2.DoMath(secondInput));

            Overloads overloads3 = new Overloads();
            string thirdInput = "5";
            Console.WriteLine(overloads3.DoMath(thirdInput));


            Console.ReadLine();
        }
    }
}
