using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //public delegate TReslut GenericNumDelegate<in T , out TReslut>(T x);
    public class GenericNumrics<T>
    {
        //Built in Delegate
        public static List<T> FilterNum(List<T> list , Predicate<T> filterNumDelegate)
        {
            List<T> res = new List<T>();
            for (var i = 0; i < list?.Count; i++)
            {
                if (filterNumDelegate.Invoke(list[i]))
                    res.Add(list[i]);
            }
            return res;
        }
    }
}
