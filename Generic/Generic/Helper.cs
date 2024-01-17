using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Helper<T> where T : IComparable<T>
    {
        #region Non-Generic Swap
        //public static void Swap(ref int x , ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void Swap(ref double x, ref double y)
        //{
        //    double temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void Swap(ref string x, ref string y)
        //{
        //    string temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public static void Swap(ref Point p1, ref Point p2)
        //{
        //    Point temp = p1;
        //    p1 = p2;
        //    p2 = temp;
        //}

        #endregion

        #region Generic Swap
        public static void Swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        #endregion

        #region Generic Search
        public static int SearchArr(T[]Arr , T value)
        {
            for(int i = 0; i < Arr?.Length; i++) 
            {
                if (Arr[i].Equals(value))
                    return i;
            }
            return -1;
        }
        #endregion

        #region Bubble Sort
        public static void BubbleSort(T[] Arr)
        {
            for (int i = 0;i < Arr?.Length;i++)
            {
                for(int j = 0; j < Arr?.Length - i -1; j++)
                {
                    if (Arr[j].CompareTo( Arr[j+1]) == 1 )
                        Swap(ref Arr[j] , ref Arr[j+1]);
                }
            }
        }
        #endregion
    }
}
