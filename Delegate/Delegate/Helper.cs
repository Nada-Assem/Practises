using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class ConditionMethodes
    {
        public static bool CheckOdd(int x) => x % 2 == 1;
        public static bool CheckEven(int x) => x % 2 == 0;
        public static bool CheckDevisionSeven(int x) => x % 7 == 0;
    }
}
