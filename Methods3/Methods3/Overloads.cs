using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    class Overloads
    {
        public int DoMath(int input)
        {
            return input * 2;
        }

        public int DoMath(decimal input)
        {
            return (int)(input + 5);
        }

        public int DoMath(string input)
        {
            int ans = 0;

            try
            {
                ans = Convert.ToInt32(input);
            }
            catch
            {
                Console.WriteLine("Can't do math on words");
                return 0;
            }

            ans = ans % 2;
            return ans;
        }


    }
}
