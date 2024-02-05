using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public static class IntExtension
    {
        public static int Reverse(this int num)
        {
            int reversed = 0;
            while (num != 0)
            {
                int remainder = num % 10;
                reversed = reversed * 10 + remainder;
                num /= 10;
            }
            return reversed;
        }

    }
}
