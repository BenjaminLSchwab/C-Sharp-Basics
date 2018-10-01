using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a day of the week.");
            DayOfTheWeek day = 0;
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    string input = Console.ReadLine();
                    input = input.ToLower();
                    string firstLetter = input.ToUpper().Substring(0, 1);
                    input = firstLetter + input.Substring(1);
                    //input now has capitol letter at front

                    //Enum.TryParse("Active", out StatusEnum myStatus); //found online          
                    validInput = Enum.TryParse(input, out day);
                    if (!validInput) throw new Exception();
                }
                catch
                {
                    validInput = false;
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }                     

            Console.WriteLine(day);

            Console.ReadLine();
        }
    }
    public enum DayOfTheWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
