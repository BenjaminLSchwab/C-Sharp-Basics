using System;

namespace Abstract
{
    public class Employee : Person, Absrtact.IQuittable 
    {
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }

        public void Quit()
        {
            Console.WriteLine("{0} {1} has quit.", FirstName, LastName);
        }
    }
}
