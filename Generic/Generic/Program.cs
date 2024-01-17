using System.Drawing;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
           #region Non-Generic Swap
           // Console.WriteLine($"============Non-Generic Swap=============");
           // Console.WriteLine($"============Swap integer=============");
           // int x = 5 , y = 10 ;
           // Console.WriteLine($"============Before Swap=============");
           // Console.WriteLine($"X = {x} \nY = {y}");
           // Helper.Swap(ref x,ref y);
           // Console.WriteLine($"============After Swap=============");
           // Console.WriteLine($"X = {x} \nY = {y}");

           // Console.WriteLine($"============Swap Double=============");
           // double a = 5.5, b = 10.2;
           // Console.WriteLine($"============Before Swap=============");
           // Console.WriteLine($"A = {a} \nB = {b}");
           // Helper.Swap(ref a, ref b);
           // Console.WriteLine($"============After Swap=============");
           // Console.WriteLine($"A = {a} \nB = {b}");

           // Console.WriteLine($"============Swap String=============");
           // string s1 = "Nada", s2 = "Assem";
           // Console.WriteLine($"============Before Swap=============");
           // Console.WriteLine($"S1 = {s1} \ns2 = {s2}");
           // Helper.Swap(ref s1, ref s2);
           // Console.WriteLine($"============After Swap=============");
           // Console.WriteLine($"S1 = {s1} \nS2 = {s2}");

           // Console.WriteLine($"============Swap Point=============");
           //Point p1 = new Point(2,1);
           // Point p2 = new Point(8,3);
           // Console.WriteLine($"============Before Swap=============");
           // Console.WriteLine($"Point 1 = {p1.ToString()}");
           // Console.WriteLine($"Point 2 = {p2.ToString()}");
           // Helper.Swap(ref p1, ref p2);
           // Console.WriteLine($"============After Swap=============");
           // Console.WriteLine($"Point 1 = {p1.ToString()}");
           // Console.WriteLine($"Point 2 = {p2.ToString()}");
            #endregion

            #region Generic Swap
            Console.WriteLine($"============Generic Swap============");
            float f1 = 0.2f , f2 = 0.6f;
            Console.WriteLine($"============Before Swap=============");
            Console.WriteLine($"F1 = {f1} \nF2 = {f2}");
            Helper<float>.Swap(ref f1, ref f2);
            Console.WriteLine($"============After Swap=============");
            Console.WriteLine($"F1 = {f1} \nF2 = {f2}");


            Console.WriteLine($"============Swap Point=============");
            Point<int> p1 = new Point<int>(2, 1);
            Point<int> p2 = new Point<int>(8, 3);
            Console.WriteLine($"============Before Swap=============");
            Console.WriteLine($"Point 1 = {p1.ToString()}");
            Console.WriteLine($"Point 2 = {p2.ToString()}");
            Point<int>.Swap(ref p1, ref p2);
            Console.WriteLine($"============After Swap=============");
            Console.WriteLine($"Point 1 = {p1.ToString()}");
            Console.WriteLine($"Point 2 = {p2.ToString()}");
            #endregion

            #region Generic Search
            Console.WriteLine($"============Generic Search=============");
            int[] Numbers = {10,5,6,2,3,7,8};
            int index = Helper<int>.SearchArr(Numbers, 2);
            Console.WriteLine($"index of 2 : {index}");

            Console.WriteLine($"============Search Employee=============");
            Employee Emp1 = new Employee { Id = 1 , Name="Nada"};
            Employee Emp2 = new Employee { Id = 2 , Name="Mohamed"};
            Employee Emp3 = new Employee { Id = 3 , Name="Ali"};
            
            Console.WriteLine($"============compare Emp1 == Emp2 ========");
            if (Emp1 == Emp2)
                Console.WriteLine("Is Equal");
            else
                Console.WriteLine("Not Equal");
            Console.WriteLine($"=========================");
            Employee[] employees = [Emp1, Emp2, Emp3];
            int Ind = Employee.SearchArr(employees, new Employee { Id = 1, Name = "Nada" });
            Console.WriteLine($"index of Employee : {Ind}");
            #endregion

            #region BubblleSort
            Console.WriteLine($"============Sort Arrar =============");
            int[] Arr = new int[] {10,5,6,3,7,8};
            Helper<int>.BubbleSort(Arr);
            foreach ( int i in Arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine($"\n============Sort Arrar of Points=============");
            Console.WriteLine("============Before Sort==========");
            Point<int> p3 = new Point<int>(2, 3);
            Point<int>[] Points = {p1, p2,p3 };
            foreach (Point<int> P in Points)
            {
                Console.WriteLine(P);
            }
            Point<int>.BubbleSort(Points);
            Console.WriteLine("============After Sort==========");
            foreach (Point<int> P in Points)
            {
                Console.WriteLine(P);
            }
            #endregion
        }
    }
}
