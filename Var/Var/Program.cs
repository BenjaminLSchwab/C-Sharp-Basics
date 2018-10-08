using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var
{
    class Program
    {
        static void Main()
        {
            const string zooName = "The Best Zoo";
            Animal bird = new Animal("Flaps the bird", 2);
            Animal squirrel = new Animal("Nutty the squirrel");
            var animals = new List<Animal>() {bird, squirrel };


            Console.WriteLine("Welcome to {0}", zooName);
            Console.WriteLine("Animals:");
            foreach (Animal animal in animals)
            {
                Console.WriteLine("Name: {0}, Number of legs: {1}", animal.Name, animal.NumLegs);
            }

            Console.WriteLine("Wow, we really need to get some more animals...");
            Console.ReadLine();
        }
    }
}
