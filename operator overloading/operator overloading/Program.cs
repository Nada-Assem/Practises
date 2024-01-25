using System.Runtime.Intrinsics.Arm;

namespace operator_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Complex c1 = new Complex() { Real = 1 , Image = 5};
            Complex c2 = new Complex() { Real = 3 , Image = 1};
            #region Operator Overloading
            Console.WriteLine("==============(Operator Overloading)=================");
            Console.WriteLine($"C1 = {c1.ToString()}");
            Console.WriteLine($"C2 = {c2.ToString()} ");
            Console.WriteLine("===============================");
            Complex c3 = default;
            c3 = c1 + c2;
            Console.WriteLine($"C3 = C1 + C2 =  {c3.ToString()} ");
            Console.WriteLine("===============================");
            Complex c4 = default;
            c4 = c1 - c2;           
            Console.WriteLine($"C4 = C1 - C2 =  {c4.ToString()}"); 
            Console.WriteLine("===============================");
            Complex c5 = default;
            c5 = c1 + 3;
            Console.WriteLine($"C5 = C1 + 3 =  {c5.ToString()}");
            Console.WriteLine("===============================");
            Complex c6 = default;
            c6 = 3 + c1 ;
            Console.WriteLine($"C6 = 3 + C1 =  {c6.ToString()}");
            Console.WriteLine("===============================");
            Complex c7 = default;
            c7 = c1 - 5;
            Console.WriteLine($"C7 = C1 - 5 =  {c7.ToString()}");
            Console.WriteLine("===============================");
            Complex c8 = default;
            c8 = 3 - c1;
            Console.WriteLine($"C8 = 3 - C1 =  {c8.ToString()}");
            #endregion

            #region 
            Console.WriteLine("==============Operator(++)=================");
            c2++;
            Console.WriteLine($"C2++ = {c2.ToString()}");
            #endregion

            #region 
            Console.WriteLine("==============Operator(--)=================");
            c2--;
            Console.WriteLine($"C2-- = {c2.ToString()}");
            #endregion
            #region
            Console.WriteLine("==============Operator(==)=================");
            if (c1 == c2)
                Console.WriteLine("c1 Is Equel c2");
            else
                Console.WriteLine("c1 Not Equel c2");
            Console.WriteLine("===============================");
            Complex complex1 = new Complex() { Real = 1 , Image = 1};
            Complex complex2 = new Complex() { Real = 1, Image = 1 };
            if (complex1 == complex2)
                Console.WriteLine("Is Equel");
            else
                Console.WriteLine("Not Equel");

            #endregion
        }
    }
}
