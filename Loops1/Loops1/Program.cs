using System;

namespace Loops1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What color is a duck?");
            bool correctAnswer = (Console.ReadLine() == "yellow");
            while (!correctAnswer)
            {
                Console.WriteLine("Thats not quite right, guess again.");
                correctAnswer = (Console.ReadLine() == "yellow");
            }

            do
            {
                Console.WriteLine("What if the duck was green? What color would he be then?");
                correctAnswer = (Console.ReadLine() == "green");
            } while (!correctAnswer);

            Console.WriteLine("That makes sense to me.");
            Console.ReadLine();
        }
    }
}
