using System;

namespace Abstract
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}
