using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods5
{
    static class StaticDivider
    {
        public static void DivideByThree(int input, out int answer, out int remainder)
        {
            answer = input / 3;
            remainder = input % 3;
        }

        public static void DivideByThree(float input, out float answer)
        {
            answer = input / 3f;
        }
    }
}
