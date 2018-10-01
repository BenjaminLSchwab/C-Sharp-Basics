using System;

namespace Abstract
{
    class Program
    {
        static void Main()
        {
            Employee sample = new Employee() {FirstName = "Sample", LastName = "Student" };
            sample.SayName();

            Absrtact.IQuittable quittable = new Employee() {FirstName = "Quitter", LastName = "Jones" };
            quittable.Quit();

            Console.ReadLine();
            //changed folder name
        }
    }
}
