using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input a number or face the consequences.");
            bool validInput = false;
            string input = "";
            while (!validInput)
            {
                try
                {
                    input = Console.ReadLine();
                    Convert.ToInt32(input);
                    validInput = true;
                }
                catch
                {
                    Console.WriteLine("Whole numbers only!");
                    validInput = false;
                }
            }
            using (StreamWriter file = new StreamWriter(@"C:\Users\DwarfKhan\Documents\work\TechAcademyLocalRepos\C-Sharp-Basics\FileIO\number.txt", false))
            {
                file.WriteLine(input);
            }

            string fileText = File.ReadAllText(@"C:\Users\DwarfKhan\Documents\work\TechAcademyLocalRepos\C-Sharp-Basics\FileIO\number.txt");
            Console.WriteLine("The number you entered was {0}",fileText);
            Console.ReadLine();
        }
    }
}
