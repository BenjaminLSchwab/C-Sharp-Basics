﻿using System;

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            Employee sample = new Employee() { FirstName = "Sample", LastName = "Student" };

            sample.SayName();

            Console.ReadLine();
        }
    }
}