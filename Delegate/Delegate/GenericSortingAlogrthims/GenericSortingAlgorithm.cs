using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.GenericSortingAlogrthims
{
    //public delegate TReslut GenericComperDelegate<in T1 , in T2 , out TReslut>(T1 Left , T2 Right);
    public class GenericSortingAlgorithm<T>
    {

        //using Built in Deletage
        public static void GenericBubbleSort(T[] Arr , Func<T , T , bool> genericComper)
        {
            for (int i = 0; i < Arr?.Length; i++)
            {
                for(int j = 0; j < Arr?.Length-i-1; j++)
                {
                    if (genericComper.Invoke(Arr[j] , Arr[j+1]) )
                        Swap(ref Arr[j],ref Arr[j+1]);
                        
                }
            }
        }

        public static void Swap(ref T  X ,ref T Y)
        {
            T temp = X;
            X = Y; 
            Y = temp;
        }
    }

    public class GenericComperMethods
    {
        public static bool Ascending(int Left , int Right)=> Left > Right;
        public static bool Descending(int Left, int Right) => Left < Right;
        public static bool ComperLengthString(string Left, string Right) => Left?.Length > Right?.Length;
    }
}
