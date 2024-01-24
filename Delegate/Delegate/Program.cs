using Delegate.GenericSortingAlogrthims;
using Delegate.SortingAlgorithms;
using System;
namespace Delegate
{

    //Ex 01
    public class StringMethod
    {
        public static int GetCountOfUpperChars(string word)
        {
            int count = 0;
            for (int i = 0; i < word?.Length; i++)
            {
                if (Char.IsUpper(word[i]))
                    count++;
            }
            return count;
        }
        public static int GetCountOfLowerChars(string word)
        {
            int count = 0;
            for (int i = 0; i < word?.Length; i++)
            {
                if (Char.IsLower(word[i]))
                    count++;
            }
            return count;
        }

        public static void print(string word) => Console.WriteLine(word);
    }
    

    public delegate int StringMethodDelegate(string word);
    //End Ex01
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("=========================Delegate===============================\n");
            #region Delegate Ex01
            Console.WriteLine("======================Example 01===============================");
            StringMethodDelegate methodDelegate;
            //methodDelegate = new StringMethodDelegate(StringMethod.GetCountOfUpperChars);
            methodDelegate = StringMethod.GetCountOfUpperChars; //shortcut
            methodDelegate += StringMethod.GetCountOfLowerChars;
            //int reslut = methodDelegate.Invoke("Nada Assem");
            int reslut = methodDelegate("Nada Assem");
            Console.WriteLine(reslut);

            //Action (Bulit-in Deletage)
            Action<string> action = StringMethod.print;
            action.Invoke("Nada Assem");
            #endregion

            #region Ex02 Non-Generic
            Console.WriteLine("======================Example 02===============================");
            int[] Arr = { 2, 5, 1 };
            //ComperDelegat comperDelegat = ComperMethods.Descending;
            //using Built in Delegate
            Func<int,int,bool> comperDelegat = ComperMethods.Descending;
            SortingAlgorithm.BubbleSort(Arr, comperDelegat);
            foreach (int i in Arr)
            {
                Console.Write($"{i} ");
            }
            #endregion

            #region Ex02 Generic
            Console.WriteLine("\n======================Example 02(Generic)=======================");
            int[] Arr01 = { 2, 5, 1 , 4};
            //GenericComperDelegate<int, int, bool> genericComperDelegate;

            //using Built-in Deletage
            Func<int, int, bool> genericComperDelegate;
            genericComperDelegate = GenericComperMethods.Ascending;
            GenericSortingAlgorithm<int>.GenericBubbleSort(Arr01, genericComperDelegate);
            foreach (int i in Arr01)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n===================Sort Arr Of String============================");
            string[] str = { "Nada", "Assem", "Islam", "Eman", "Mohamed" };
            //GenericComperDelegate<string, string, bool> comperString;

            //using Built-in Deletage
            Func<string, string, bool> comperString;
            comperString = GenericComperMethods.ComperLengthString;
            GenericSortingAlgorithm<string>.GenericBubbleSort(str, comperString);
            foreach (string i in str)
            {
                Console.Write($"{i} ");
            }

            #endregion

            #region Ex 03
            Console.WriteLine("\n======================Example 03===============================");
            List<int> list = Enumerable.Range(0, 100).ToList();
            List<int> res = Numrics.GetOODNumber(list);
            foreach (int i in res)
                Console.Write($"{i} ");
            // Filter
            Console.WriteLine("\n========================Filter=================================");
            Console.Write("Even Numbers: ");

            //ConditionDelegate condition = ConditionMethodes.CheckEven;
            
            //using Bulit in Delegate
            List<int> res01 = Numrics.FilerNumber(list, ConditionMethodes.CheckEven);
            foreach (int i in res01)
                Console.Write($"{i} ");
            Console.WriteLine("\n====================================================");
            Console.Write("OOD Numbers: ");
            //ConditionDelegate condition01 = ConditionMethodes.CheckOdd;
            List<int> res02 = Numrics.FilerNumber(list, ConditionMethodes.CheckOdd);
            foreach (int i in res02)
                Console.Write($"{i} ");

            Console.WriteLine("\n====================================================");
            Console.Write("Numbers Division 7 : ");
            List<int> res03 = Numrics.FilerNumber(list, ConditionMethodes.CheckDevisionSeven);
            foreach (int i in res03)
                Console.Write($"{i} ");
            #endregion

            #region Ex03 Generic
            Console.WriteLine("\n=================Example 03 Generic===================================");
            //GenericNumDelegate<int,bool> genericNumDelegate = ConditionMethodes.CheckEven;
            
            //Built in Delegate
            Predicate<int> genericNumDelegate = ConditionMethodes.CheckEven;
            List<int> res04 = GenericNumrics<int>.FilterNum(list, genericNumDelegate);
            foreach (int i in res03)
                Console.Write($"{i} ");
            #endregion


            #region Anonymouns Method
            //Anonymouns Method ==> C# 2.0
            Console.WriteLine("\n========================Anonymouns Method=================================");
            Action<string> action1 = delegate (string s)
            {
                Console.WriteLine(s);
            };
            action1("Hello");

            Func<int, string> func = delegate (int s) {
                return s.ToString();
            };
            Console.WriteLine( func(5000) );


            //Lambda Expression
            //Called Fat Arrow ==> Read as Goes To

            //Action<string> action1 = (string s) => Console.WriteLine(s);
            //Func<int, string> func = (int s) => s.ToString();
            Console.WriteLine("=====================ForEach===================================");
            List<int> num = Enumerable.Range(0, 10).ToList();

            num.ForEach((x) => Console.Write($"{x} ")); ;

            Console.WriteLine("\n=====================All===================================");
            Console.WriteLine( num.All(X => X > 0));
            Console.WriteLine( num.All(X => X >= 0));

            Console.WriteLine("\n=====================Count===================================");
            Console.WriteLine(num.Count(X => X%2 == 0));
            
            #endregion
        }
    }


    

}
