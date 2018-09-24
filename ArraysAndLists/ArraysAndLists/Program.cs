using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            string[] strings = new string[3];
            Console.WriteLine("Lets get 3 strings...");

            Console.WriteLine("1:");
            strings[0] = Console.ReadLine();

            Console.WriteLine("2:");
            strings[1] = Console.ReadLine();

            Console.WriteLine("3:");
            strings[2] = Console.ReadLine();

            Console.WriteLine("Which one do you want to see again? (1 - 3)");
            Console.WriteLine(strings[Convert.ToByte(Console.ReadLine()) -1]);

            int[] nums = new int[] {26, 52, 258};
            Console.WriteLine("I have 3 numbers, which one do you want to see? (1 - 3)");
            Console.WriteLine(nums[Convert.ToByte(Console.ReadLine()) -1]);

            List<string> stringList = new List<string> {"one", "won", "1" };
            Console.WriteLine("I have 3 strings, which one do you want to see? (1 - 3)");
            Console.WriteLine(stringList[Convert.ToByte(Console.ReadLine()) -1]);

            Console.ReadLine();

        }
    }
}
