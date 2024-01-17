using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal struct Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

       

        public static bool operator ==(Employee Left, Employee Rigth)
        {
            return Left.Equals(Rigth);
        }
        public static bool operator !=(Employee Left, Employee Rigth)
        {
            return Left.Equals(Rigth);
        }
        public static int SearchArr(Employee[] Arr, Employee value)
        {
            for (int i = 0; i < Arr?.Length; i++)
            {
                if (Arr[i].Equals(value))
                    return i;
            }
            return -1;
        }
    }
}
