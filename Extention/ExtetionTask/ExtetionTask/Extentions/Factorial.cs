using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtetionTask.Extentions
{
    internal static class Factorial
    {
        public static int Fact(this int number)
        {
            int result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}