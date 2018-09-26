using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods1
{
    static public class Operations
    {
        static public int AddThree(int input)
        {
            return input + 3;
        }

        static public int OneMoreThanHalf(int input)
        {
            return (input / 2) + 1;
        }

        static public int PrettyClose(int input)
        {
            Random random = new Random();
            return input + random.Next(-5, 5);
        }

    }
}
