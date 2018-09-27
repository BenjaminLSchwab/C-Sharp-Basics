using System;

namespace Methods4
{
    class Program
    {
        static void Main()
        {
            AverageTwo averageTwo = new AverageTwo();

            int firstInput = 0;
            int secondInput = 0;
            string tempInput = "";

            bool validInput = true;
            do
            {
                try
                {
                    Console.WriteLine("Input a whole number please.");
                    firstInput = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Second input is optional, type a whole number if you feel like it, then press enter.");
                    tempInput = Console.ReadLine();
                    if (tempInput != "") Convert.ToInt32(tempInput); //this will throw an error and re-loop if user inputs a non whole number
                    
                    validInput = true;
                }
                catch
                {
                    validInput = false;
                }


            } while (!validInput);



            if (tempInput == "")
            {
                Console.WriteLine("Averaged with 1: {0}", averageTwo.Average(firstInput));
            }
            else
            {
                secondInput = Convert.ToInt32(tempInput);
                Console.WriteLine("Average: {0}", averageTwo.Average(firstInput, secondInput));
            }

            Console.ReadLine();
        }
    }
}
