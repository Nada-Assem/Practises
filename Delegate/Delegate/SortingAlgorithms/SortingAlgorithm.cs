using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.SortingAlgorithms
{
    //public delegate bool ComperDelegat(int Left , int Right);
    public class SortingAlgorithm
    {
        //using Built in Delegate
        public static void BubbleSort(int[] Arr , Func<int , int , bool> comperNum)
        {
            for (int i = 0; i < Arr?.Length; i++)
            {
                for(int j = 0; j < Arr?.Length-i-1; j++)
                {
                    if (comperNum.Invoke(Arr[j] , Arr[j+1]) )
                        Swap(ref Arr[j] ,ref Arr[j+1]);
                }
            }
        }
        public static void Swap(ref int X ,ref int Y)
        {
            int temp = X;
            X = Y; 
            Y = temp;
        }

    }

    public class ComperMethods
    {
        public static bool Ascending(int x, int y) => x > y;
        public static bool Descending(int x, int y) => x < y;
    }
}
