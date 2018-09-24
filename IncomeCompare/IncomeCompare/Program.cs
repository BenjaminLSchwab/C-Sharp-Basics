using System;

namespace IncomeCompare
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate:");
            int rate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours per Week:");
            int hours1 = Convert.ToInt32(Console.ReadLine());
            int salary1 = rate1 * hours1;

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate:");
            int rate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours per Week:");
            int hours2 = Convert.ToInt32(Console.ReadLine());
            int salary2 = rate2 * hours2;

            Console.WriteLine("Person 1 Weekly Salary: " + salary1);
            Console.WriteLine("Person 2 Weekly Salary: " + salary2);

            Console.WriteLine("Does person 1 make more than person 2? " + (salary1 > salary2));

            Console.ReadLine();
        }
    }
}
