using System;

namespace Abstract
{
    class Program
    {
        static void Main()
        {
            Employee sample = new Employee() {FirstName = "Sample", LastName = "Student" };
            sample.SayName();

            Console.ReadLine();
        }
    }
}
