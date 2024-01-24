using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //public delegate bool ConditionDelegate(int x);

    public class Numrics
    {
        public static List<int> GetOODNumber(List<int> nums)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums?.Count; i++)
            {
                if (nums[i] % 2 == 1)
                    result.Add(nums[i]);
            }
            return result;
        }

        public static List<int> FilerNumber(List<int> nums, Predicate<int> condition)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums?.Count; i++)
            {
                if (condition.Invoke(nums[i]))
                    result.Add(nums[i]);
            }
            return result;
        }
    }

    
}
