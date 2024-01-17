using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Point<T> where T : IComparable<T> 
    {
        public T X { get; set; }
        public T Y { get; set; }

        public Point(T x , T y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

       

        #region Generic Swap
        public static void Swap(ref Point<T> x, ref Point<T> y)
        {
            Point< T> temp = x;
            x = y;
            y = temp;
        }
        #endregion

        #region Generic Search
        public static int SearchArr(Point<T>[] Arr, Point<T> value)
        {
            for (int i = 0; i < Arr?.Length; i++)
            {
                if (Arr[i].Equals(value))
                    return i;
            }
            return -1;
        }
        #endregion


        #region Bubble Sort
        public static void BubbleSort(Point<T>[] Arr)
        {
            for (int i = 0; i < Arr?.Length; i++)
            {
                for (int j = 0; j < Arr?.Length - i - 1; j++)
                {
                    if (Arr[j].X.CompareTo(Arr[j + 1].X) == 1)
                        Swap(ref Arr[j], ref Arr[j + 1]);
                }
            }
        }
        #endregion
    }
}
