using System;

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            Employee sample = new Employee() { FirstName = "Sample", LastName = "Student", ID = 1 };

            Employee different = new Employee() { FirstName = "Bob", LastName = "Roberts", ID = 2 };

            sample.SayName();
            different.SayName();

            Console.WriteLine("Are the two employees the same? {0}.", sample == different);


            Console.ReadLine();
        }
    }
}
