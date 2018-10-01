using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            Employee<String> sample = new Employee<String>() { FirstName = "Sample", LastName = "Student", ID = 1 };
            sample.Things = new List<string> { "Thing 1", "Thing 2", "Thing Red", "Thing Blue" };

            Employee<int> different = new Employee<int>() { FirstName = "Bob", LastName = "Roberts", ID = 2 };
            different.Things = new List<int> { 1, 2, 77, 45 };

            sample.SayName();
            sample.ListThings();

            different.SayName();
            different.ListThings();

            


            Console.ReadLine();
        }
    }
}
