using System;
using System.Text;

namespace Strings1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Give me three sentences.");

            Console.WriteLine("1:");
            string st1 = Console.ReadLine();

            Console.WriteLine("2:");
            string st2 = Console.ReadLine();

            Console.WriteLine("3:");
            string st3 = Console.ReadLine();

            Console.WriteLine("Together, that makes:");
            Console.WriteLine(st1 + " " + st2 + " " + st3);

            Console.WriteLine("Give me some text, and I will yell it back to you.");
            string input = Console.ReadLine();
            Console.WriteLine(input.ToUpper());

            StringBuilder sb = new StringBuilder();
            sb.Append("This is a paragraph of text. ");
            sb.Append("It was added to a string builder one sentence at a time. ");
            sb.Append("I am a monkey designed to operate in small hunter gatherer tribes.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
