using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeDrill
{
    class Program
    {
        static void Main()
        {
            bool validInput = false;
            while (!validInput)
            {
                 try
                 {
                    Console.WriteLine("How old are you?");
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age < 1) throw new NotSupportedException();
                    TimeSpan ageInYears = TimeSpan.FromDays(age * 365);
                    DateTime yearOfBirth = DateTime.Now - ageInYears;
                    Console.WriteLine("You were born in {0}", yearOfBirth.Year);
                    Console.ReadLine();
                    validInput = true;

                 }
                 catch (NotSupportedException)
                 {
                    Console.WriteLine("Please input at least one year.");
                    Console.ReadLine();
                 }
                 catch(Exception)
                 {
                    Console.WriteLine("An error occured, please run around in circles.");
                    Console.ReadLine();
                 }
            }

        }
    }
}
