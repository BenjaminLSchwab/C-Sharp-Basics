using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void Main()
        {
            TwoInt twoInt = new TwoInt();

            twoInt.DoMath(15, 20);

            twoInt.DoMath(first: 60, second: 15);

            Console.ReadLine();

        }
    }
}
