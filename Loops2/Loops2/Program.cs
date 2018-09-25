using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace Loops2
{
    class Program
    {
        static void Main()
        {
            //task 1
            string[] stringArray = {"1: ", "2: ", "3: "};
            Console.WriteLine("Please input some text to be repeated.");
            string input = Console.ReadLine();

            for (byte i = 0; i < stringArray.Length; i++ )
            {
                stringArray[i] = stringArray[i] + input;
            }

            foreach (string text in stringArray)
            {
                Console.WriteLine(text);
            }

            //task 2
            while (true)
            {
                Console.WriteLine("Infinite");
                break; //former infinite loop
            }
            Console.ReadLine();


            //task 3
            byte j = 0;
            StringBuilder output = new StringBuilder();
            while (j < 100)
            {
                if (j == 0)
                {
                    output.Append('o');
                }
                else if (j == 55)
                {
                    output.Insert( j - 1,'S');
                }
                else if (j == 56)
                {
                    output.Insert( j - 1, 'u');
                }
                else if (j == 57)
                {
                    output.Insert(j - 1, 'p');
                }
                else
                {
                output.Insert( j - 1, '.');
                }

                Console.WriteLine(output);
                j++;
                Thread.Sleep(60);
            }


            //task 4
            while (1 <= j)
            {
                output.Remove(Math.Max(j - 2, 0), 1);
                j--;
                Console.WriteLine(output);
                Thread.Sleep(60);
            }

            //task 5
            List<string> names = new List<string> {"Ben", "Bon", "Bo", "Billboye", "Tim?" };
            Console.WriteLine("I have a list of names, try to guess a name...");
            input = Console.ReadLine();
            bool foundName = false;

            while (!foundName)
            {
                for (int i = 0; i < names.Count; i++)
                {
                    if (names[i].Contains(input))
                    {
                        Console.WriteLine("You guessed the " + Convert.ToString(i + 1) + "th name!");
                        foundName = true;
                        Console.ReadLine();
                        break;
                    }
                }
                if (!foundName)
                {
                    Console.WriteLine("Nope, not on the list! Guess again...");
                    input = Console.ReadLine();
                }
            }

            //task 6 - 8
            List<string> newNames = new List<string> { "John Cena!", "Jorgan", "Bo", "Billboye", "John Cena!" };
            Console.WriteLine("I have a list of names, try to guess a name, this time there are 2 identical names...");
            input = Console.ReadLine();

            bool foundNewName = false;

            while (!foundNewName)
            {
                for (int i = 0; i < newNames.Count; i++)
                {
                    if (newNames[i].Contains(input))
                    {
                        Console.WriteLine("You guessed the " + Convert.ToString(i + 1) + "th name!");
                        foundNewName = true;
                    }
                }
                if (!foundNewName)
                {
                    Console.WriteLine("Nope, not on the list! Guess again...");
                    input = Console.ReadLine();
                }
            }
            Console.ReadLine();

            //task 9 - 10
            Console.WriteLine("Here comes a list of places, lets see if there are any repeats...");
            Console.ReadLine();

            List<string> places = new List<string> {"portland", "under a rock", "inside that one 7/11", "portland", "the surface of the sun" };
            List<string> passedPlaces = new List<string>();
            foreach (string place in places)
            {
                if (passedPlaces.Contains(place))
                {
                    Console.WriteLine(place + " has been listed already.");
                }
                else
                {
                Console.WriteLine(place + " is new to the list.");

                }
                passedPlaces.Add(place);
            }



            Console.ReadLine();
        }
    }
}
