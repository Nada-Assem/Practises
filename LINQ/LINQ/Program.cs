using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.Data;
using System.Buffers.Text;
using System.Runtime.ConstrainedExecution;
using System.Security.Claims;
using static LINQ.SampleData;
using static LINQ.ListGenerators;
using System.Xml.Linq;
using System.ComponentModel;
using System.Text.RegularExpressions;
namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Implicitly Typed Local Variable [Var, Dynamic]
            Console.WriteLine("================Implicitly Typed Local Variable [Var, Dynamic]==========================");
            ////Var
            ////Compiler will detect variable datatype based on its initial value at compilation time
            ////must be initialize
            ////can not ne initialized with null
            ////after initialization u can not chanage its datatype
            //var data = 22;
            //data = "ABC"; // Cannot implicitly convert type 'string' to 'int'
            //==============================================================
            ////Dynamic
            ////Compiler will detect variable datatype based on its last value at run time
            dynamic x = 5;
            ////after initialization u can chanage its datatype
            x = "Nada";
            //not neccesary to be intialized
            //dynamic y;
            //can be initialized by null
            //dynamic z = null;
            //Get Type
            Type type = ((object)x).GetType();
            Console.WriteLine(type);
            #endregion

            #region Extension Methods
            Console.WriteLine("====================Extension Methods=====================");
            int num = 123456;
            //int res = IntExtension.ReverseInteger(num);
            Console.WriteLine(num.Reverse());
            #endregion

            #region Anonymous Type
            Console.WriteLine("====================Anonymous Type=====================");

            var emp1 = new { Name = "Nada", id = 12, Address = "Qena" };
            Console.WriteLine($"ID : {emp1.id}\nName: {emp1.Name}\nAddress: {emp1.Address}");
            var emp2 = new { Name = "Nada", id = 12, Salary = 7000 };
            // Same Anonymous Type as long as
            // 1. Same Properties name (Case Sensetive)
            // 2. Same Properties order
            Console.WriteLine(emp1.GetType().Name);
            Console.WriteLine(emp2.GetType().Name);

            // emp1.Name = "Assem"; // can't be assigned
            var emp3 = emp2 with { Salary = 10000 };
            Console.WriteLine(emp3.GetType().Name);
            Console.WriteLine(emp3.Salary);
            #endregion

            #region LINQ Intrqduction
            ////LINQ => Language Integrated Query
            ////+40 Extension methods(Class that implementing IEnumrable Interface)
            ////[Query Operators] existing at Enumerable Class and categorized to 13 Categories

            //// Linq operators can be used against Data(Sequence)
            ////Sequence Any Class implmentin IEnumerabIe List, Array, Dictionary
            ////Sequence Type
            ////1.Local Sequence => L20, L2XML
            ////2.Remote Sequence => L2E
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            Console.WriteLine("=============LINQ Syntax===========================");
            #region LINQ Syntax
            //1.Fluent Syntax
            Console.WriteLine("\n==================Fluent Syntax=========================");

            Console.WriteLine("\n==================Calling as static through Enumrable class =========================");

            //1.1 calling LINQ method as static through Enumrable class
            var result = Enumerable.Where(list, (num) => num % 2 == 0);
            //1.2 calling LINQ Method as Extension Method
            result = list.Where((num) => num % 2 == 0);
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n==================Calling as Extension Method =========================");

            //1.2 Calling LINQ Method as Extension Method 

            result = list.Where((num) => num % 2 == 0);
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
            //===============================================================================================================================
            //2. Query Syntax [Query Expression] => like sql query style
            //start with from introduction Range Varible : Represent each element at sequence
            //end with select or group by
            Console.WriteLine("\n==================Query Syntax=========================");
            result = from number in list
                     where number % 2 == 0
                     select number;
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
            #endregion
            #endregion

            #region Filteration (Restrictions) Operator Where
            Console.WriteLine("\n================Operator Where================");
            //Fluent Syntax
            Console.WriteLine("=============================Where===============================");

            var Res = Books.Where(book => book.Price > 20 && book.Price < 100);
            //Query Syntax
            //var Res = from book in Books
            //      where book.Price > 20
            //      select book;
            Console.WriteLine("=============================Where Index===============================");

            // Where Index
            //valid only at Fluent Syntax can not be written usin Query syntax
            Res = Books.Where((book, Index) => book.Price > 20 && Index < 10);
            Console.WriteLine($"Books which cost more than 20$");
            foreach (var book in Res)
            {
                Console.WriteLine($"{book}");
            }
            #endregion

            #region Transformation (Projection Operators) Select / SelectMany
            Console.WriteLine("=====================Select / SelectMany===============================");

            var prices = Books.Select(book => book.Price);
            foreach (var item in prices)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==========================================================");
            var authors = Authors.Select(authors => $"{authors.FirstName} {authors.LastName}");
            foreach (var item in authors)
            {
                Console.WriteLine($"Author Name : {item}");
            }
            Console.WriteLine("==========================================================");
            Console.WriteLine("=============================SelectMany===============================");

            var R = CustomerList.SelectMany(customer => customer.Orders);
            //Query Syntax
            var res1 = from customer in CustomerList
                       from order in customer.Orders
                       select new
                       {
                           customer.CustomerID,
                           order
                       };


            foreach (var item in R)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region AnonymounsType - indexed select
            Console.WriteLine("======================AnonymounsType=======================");
            //Fluent Syntax

            var discountProduct = ProductList.Select(product => new
            {
                product.ProductID,
                product.ProductName,
                product.Category,
                product.UnitsInStock,
                NewPrice = product.UnitPrice * 0.8M
            }).Where(product => product.UnitsInStock > 10);

            // Query Syntax
            discountProduct = from product in ProductList
                              select new
                              {
                                  product.ProductID,
                                  product.ProductName,
                                  product.Category,
                                  product.UnitsInStock,
                                  NewPrice = product.UnitPrice * 0.8M
                              } into NewProducts
                              where NewProducts.UnitsInStock > 10
                              select NewProducts;
            foreach (var item in discountProduct)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("========================Indexed Select======================================");
            // Indexed Select
            var pro = ProductList.Select((product, index) => new { index = index, product = product.ProductName });
            foreach (var item in pro)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Ordering Operator 
            //Fluent Syntax
            Console.WriteLine("=============================OrderBy===============================");

            var OrderProduct = ProductList.OrderBy(product => product.UnitPrice).Select(product => new
            {
                ProductName = product.ProductName,
                ProductPrice = product.UnitPrice
            });
            foreach (var item in OrderProduct)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("================================================================================");
            var OrderProduct1 = ProductList.Select(product => new
            {
                ProductName = product.ProductName,
                ProductPrice = product.UnitPrice
            }).OrderBy(product => product.ProductPrice);

            foreach (var item in OrderProduct1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("================================================================================");
            // Query Syntax
            var OrderProduct2 = from product in ProductList
                                orderby product.UnitPrice
                                select new
                                {
                                    ProductName = product.ProductName,
                                    ProductPrice = product.UnitPrice
                                };
            foreach (var item in OrderProduct2)
            {
                Console.WriteLine(item);
            }
            // OrderBy Desc
            Console.WriteLine("\n======================================OrderBy Descending==========================================\n");

            var Desc = ProductList.OrderByDescending(product => product.UnitPrice).Select(product =>
            new
            {
                ProductName = product.ProductName,
                ProductPrice = product.UnitPrice
            });
            foreach (var item in Desc)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("================================================================================");

            //Query Syntax
            Desc = from product in ProductList
                   orderby product.UnitPrice descending
                   select new
                   {
                       ProductName = product.ProductName,
                       ProductPrice = product.UnitPrice
                   };
            foreach (var item in Desc)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n================================OrderBy Multiple Columns=====================================");
            //Fluent Syntax
            // Ascending
            var MultOrder = ProductList.OrderBy(product => product.UnitPrice)
                                        .ThenBy(product => product.UnitsInStock)
                                        .Select(product =>
                                                new
                                                {
                                                    ProductName = product.ProductName,
                                                    Count = product.UnitsInStock,
                                                    ProductPrice = product.UnitPrice
                                                });
            foreach (var item in MultOrder)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===========================================================================");
            //Descending
            MultOrder = ProductList.OrderBy(product => product.UnitPrice)
                                        .ThenByDescending(product => product.UnitsInStock)
                                        .Select(product =>
                                                new
                                                {
                                                    ProductName = product.ProductName,
                                                    Count = product.UnitsInStock,
                                                    ProductPrice = product.UnitPrice
                                                });
            foreach (var item in MultOrder)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("======================================================================");
            //Qeury Syntax 
            MultOrder = from Product in ProductList
                        orderby Product.UnitPrice, Product.UnitsInStock descending
                        select new
                        {
                            ProductName = Product.ProductName,
                            Count = Product.UnitsInStock,
                            ProductPrice = Product.UnitPrice
                        };
            foreach (var item in MultOrder)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("====================================Reverse===================================");
            var reverse = ProductList.Select((product, index) => new { ID = product.ProductID, ProductName = product.ProductName }).Reverse();
            foreach (var item in reverse)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Element Operators — Immediate Execution
            //Immediate Execution
            // 1 - Element
            // 2- Aggregate
            // 3- Casting
            Console.WriteLine("====================Element Operators========================");

            Console.WriteLine("=============================First & Last===============================");

            var Result = ProductList.First();
            Console.WriteLine(Result);
            Result = ProductList.Last();
            Console.WriteLine(Result);

            //List<Product> List = new List<Product>();
            //var Res = List.First(); //Exception
            //Console.WriteLine(Res);
            Console.WriteLine("========================FirstOrDefault & LastOrDefault===============================");
            //More Safe Then First & Last
            List<int> List = new List<int>();
            //Return the first element if exist
            //else => default value based on seuqence items datat
            var Res01 = List.FirstOrDefault();
            Console.WriteLine(Res);
            //Return the Last element if exist
            //else => default value based on se uence items datat
            Res01 = List.LastOrDefault();
            Console.WriteLine(Res);
            Console.WriteLine("==============================================");
            //If No element does not match condation => Will throw exception
            // Return the First product => product.UnitPrice == 10
            Result = ProductList.First(product => product.UnitPrice == 10);
            Console.WriteLine(Result);
            // Return the Last product => product.UnitPrice == 10
            Result = ProductList.Last(product => product.UnitPrice == 10);
            Console.WriteLine(Result);

            Console.WriteLine("==============================================");
            //Return the element if exist
            //else => default value based on seuqence items datat
            // Return the First product => product.UnitPrice == 10
            Result = ProductList.FirstOrDefault(product => product.UnitPrice == 10);
            Console.WriteLine(Result);
            // Return the Last product => product.UnitPrice == 10
            Result = ProductList.LastOrDefault(product => product.UnitPrice == 10);
            Console.WriteLine(Result);

            Console.WriteLine("=========================Element At===========================================");
            //if there is no element, will throw exception
            var E = ProductList.ElementAt(1);
            Console.WriteLine(E);

            //More Safe 
            E = ProductList.ElementAtOrDefault(1000);
            Console.WriteLine(E);
            Console.WriteLine("=============================================================");
            //Throw Exception
            //If the sequence contains more than one element
            //Sequence is empty
            List<int> ints = new List<int>();
            //var single = ints.Single();  //if sequence contains just only one element will return it
            //Console.WriteLine(single);

            //if sequence is empty wilt return null
            //if sequence contains more than one element will throw exception
            //if sequence co tains just only one element will return it
            //single = ints.SingleOrDefault();
            //Console.WriteLine(single);

            //========================================================================================
            Console.WriteLine("=============================Single===============================");

            Result = ProductList.Single(Product => Product.ProductID == 10);
            //Will throw exception if Zero or more than one element match the condition
            //if sequence contains just only one element matching
            Console.WriteLine(Result);

            //if sequence is empty will return null
            //if sequence does not contain any element matching the condition, will return null
            //if sequence contains constains more than one element matchin the condidtion will throw exception
            Result = ProductList.SingleOrDefault(Product => Product.ProductID == 1000);
            Console.WriteLine(Result);

            Console.WriteLine("==========================================================================");
            //Hybird Syntax ==> (Query Expression).Fluent Syntax
            var New = (from product in ProductList
                       where product.ProductID == 10
                       select new { product.ProductID, product.ProductName }).FirstOrDefault();
            Console.WriteLine(New);
            #endregion

            #region Aggregate Operators — Immediate Execution
            Console.WriteLine("===========================Aggregate Operators=========================");

            Console.WriteLine("======================Count===================");
            var countProducts = ProductList.Count();
            Console.WriteLine(countProducts);

            countProducts = ProductList.Count(product => product.UnitsInStock == 0);
            Console.WriteLine(countProducts);

            Console.WriteLine("=========================Max======================");
            var MaxPrice = ProductList.Max(product => product.UnitPrice);
            //Return Value
            Console.WriteLine(MaxPrice);
            Console.WriteLine("=========================Min==============================");
            var MinPrice = ProductList.Min(product => product.UnitPrice);
            Console.WriteLine(MinPrice);

            Console.WriteLine("=========================MaxBy======================");
            var MaxByPrice = ProductList.MaxBy(product => product.UnitPrice);
            //Return Product
            Console.WriteLine(MaxByPrice);

            Console.WriteLine("=========================MinBy======================");
            var MinByPrice = ProductList.MinBy(product => product.UnitPrice);
            //Return Product
            Console.WriteLine(MinByPrice);
            Console.WriteLine("====================================================================");
            var MinLenName = ProductList.Min(product => product.ProductName.Length);
            Console.WriteLine(MinLenName);

            //Query Syntax
            var QMin = from product in ProductList
                       where (product.ProductName.Length) == ProductList.Min(product => product.ProductName.Length)
                       select product;
            foreach (var item in QMin)
            {
                Console.WriteLine(item);
            }
            var QMinProuct = (from product in ProductList
                              where (product.ProductName.Length) == ProductList.Min(product => product.ProductName.Length)
                              select product).FirstOrDefault();
            Console.WriteLine(QMinProuct);

            Console.WriteLine("===================================Sum==================================");
            Console.WriteLine($"Sum Of Price : {ProductList.Sum(product => product.UnitPrice)}");
            Console.WriteLine("=================================Aggregate===================================");
            string[] str = { "Nada", "Assem", "Abo El Magd", "Mohamed" };
            var concatStr = str.Aggregate((str1, str2) => $"{str1} {str2}");
            Console.WriteLine(concatStr);
            #endregion

            #region Casting Operators— Immediate Execution
            Console.WriteLine("=============================Casting Operators========================================");
            //Convert Deffred Excution to Immediate Execution
            var Products = ProductList.Where(product => product.UnitsInStock == 0).ToList();
            Console.WriteLine(Products);

            Console.WriteLine("====================================================================");

            var arrProducts = ProductList.Where(product => product.UnitsInStock == 0).ToArray();
            Console.WriteLine(arrProducts);

            Console.WriteLine("====================================================================");

            var dicProducts = ProductList.Where(product => product.UnitsInStock == 0).ToDictionary(product => product.ProductID);
            foreach (var item in dicProducts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("====================================================================");
            Dictionary<long, string> DProducts = ProductList.Where(product => product.UnitsInStock == 0)
                .ToDictionary(product => product.ProductID, product => product.ProductName);
            foreach (var item in DProducts)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Generator Operator
            Console.WriteLine("=========================Generator Operator======================================");
            //The Only way to catt them is as static methods from Enumerable Class
            Console.WriteLine("\n=================================Range============================================");
            var Num = Enumerable.Range(1, 100);  //Range(start , Count)
            foreach (var item in Num)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n=================================Repeat============================================");
            var repeated = Enumerable.Repeat("o_o ", 10);
            foreach (var item in repeated)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n=================================Empty============================================");
            var empty = Enumerable.Empty<Product>();  // => new List<Product>()
            #endregion


            #region Set Operator
            Console.WriteLine("=========================Set Operator======================================");
            var seq1 = Enumerable.Range(0, 100);
            var seq2 = Enumerable.Range(50, 150);

            Console.WriteLine("=============================Union=======================================");

            var union = seq1.Union(seq2);  //Remove Deplicates
            foreach (var item in union)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n=============================Concat=======================================");
            var unionAll = seq1.Concat(seq2);  //return seq1 + seq2 with Deplicates
            foreach (var item in unionAll)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n=============================Concat &(Distinct)=======================================");
            var unionAllDis = seq1.Concat(seq2).Distinct();  //return seq1 + seq2 and Remove Deplicates
            foreach (var item in unionAllDis)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n=============================Except=======================================");
            var intersection = seq1.Except(seq2);  //Return in Seq1 and not in Seq2.
            foreach (var item in intersection)
            {
                Console.Write($"{item} ");
            }
            #endregion

            #region Quantifiers Operators => Return Boolean Value
            Console.WriteLine("===============================Any & All===================================");
            var found = ProductList.Any(); // if ProductList has Data Return True else Return False
            Console.WriteLine(found);
            found = ProductList.Any(product => product.UnitsInStock == 0);
            Console.WriteLine(found);

            //if list is empty return true
            var all = ProductList.All(product => product.UnitsInStock == 0);
            Console.WriteLine(all);

            Console.WriteLine("==============================SequenceEqual====================================");
            var Seq1 = Enumerable.Range(0, 100);
            var Seq2 = Enumerable.Range(0, 100);
            var equal = Seq1.SequenceEqual(Seq2);
            Console.WriteLine(equal);

            Seq1 = Enumerable.Range(1, 100);
            Seq2 = Enumerable.Range(0, 100);
            equal = Seq1.SequenceEqual(Seq2);
            Console.WriteLine(equal);
            #endregion

            #region Grouping By
            Console.WriteLine("============================== Grouping By==================================");
            var Group0 = ProductList.Where(product => product.UnitsInStock > 0)
                .GroupBy(product => product.Category)
                .Where(productGroup => productGroup.Count() > 10);
            foreach (var group in Group0)
            {
                Console.WriteLine($"\n{group.Key}");
                foreach (var products in group)
                {
                    Console.WriteLine($"=== {products}");
                }
            }


            Console.WriteLine("=========================================");
            var Group = ProductList.Where(product => product.UnitsInStock > 0)
                .GroupBy(product => product.Category)
                .Where(productGroup => productGroup.Count() > 10)
                .OrderByDescending(productGroup => productGroup.Count())
                .Select(productGroup => new
                {
                    productGroup.Key,
                    Count = productGroup.Count()
                });
            foreach (var group in Group)
            {
                Console.WriteLine($"=== {group}");
            }
            Console.WriteLine("==============================================");
            //Query Syntax
            var Group2 = from product in ProductList
                         where product.UnitsInStock > 0
                         group product by product.Category
                         into NewProductGroup
                         where NewProductGroup.Count() > 10
                         orderby NewProductGroup.Count() descending
                         select new
                         {
                             NewProductGroup.Key,
                             Count = NewProductGroup.Count()
                         };
            foreach (var item in Group2)
            {
                Console.WriteLine(item);
            }
            #endregion


            #region Zip Operators
            Console.WriteLine("\n=============================Zip Operators========================================");

            ///==>Type Parameters
            //////TFirst
            //////The type of the elements of the first input sequence.

            //////TSecond
            //////The type of the elements of the second input sequence.

            //////TResult
            //////The type of the elements of the result sequence.

            ////==>Parameters
            //////first
            //////IEnumerable<TFirst>
            //////The first sequence to merge.

            //////second
            //////IEnumerable<TSecond>
            //////The second sequence to merge.

            //////resultSelector
            //////Func<TFirst, TSecond, TResult>
            //////A function that specifies how to merge the elements from the two sequences.

            ////==>Returns
            //////IEnumerable<TResult>
            //////An IEnumerable<T> that contains merged elements of two input sequences.
            
            ///==>Exceptions
            //first or second is null.
            
            List<string> Names = new List<string> { "Nada" , "Assem" , "Mohamed" , "Eman"};
            List<int> numbers = Enumerable.Range(0, 10).ToList();

            var Result01 = numbers.Zip(Names , (number , name) => new {number , name});
            foreach (var item in Result01)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Partitioning Operators
            Console.WriteLine("\n===========================Partitioning Operators===============================\n");
            //Get the first 3 Products that are out of stock
            Console.WriteLine("===================================Take============================================");
            var Result02 = ProductList.Where(product => product.UnitsInStock == 0).Take(3);
            foreach (var item in Result02)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===================================TakeLast============================================");
            //Get the Last 3 Products that are out of stock
            Result02 = ProductList.Where(product => product.UnitsInStock == 0).TakeLast(3);
            foreach (var item in Result02)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("======================================Skip==========================================");

            //Get all out of stock products without the first 2
            Result02 = ProductList.Where(product => product.UnitsInStock == 0).Skip(2);
            foreach (var item in Result02)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=================================SkipLast===============================================");
            //Get all out of stock products without the Last 2
            Result02 = ProductList.Where(product => product.UnitsInStock == 0).SkipLast(2);
            foreach (var item in Result02)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=================================TakeWhile===============================================");
            //return elements from the start of a sequence as long as a condition that uses
            //the element's index is true.
            string[] fruits = { "apple", "passionfruit", "banana", "mango",
                      "orange", "blueberry", "grape", "strawberry" };

            IEnumerable<string> query =
                fruits.TakeWhile((fruit, index) => fruit.Length >= index);

            foreach (string fruit in query)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine("=================================SkipWhile===============================================");
            //Bypasses elements in a sequence as long
            //as a specified condition is true and then returns the remaining elements.
            int[] grades = { 59, 82, 70, 56, 92, 98, 85 };

            IEnumerable<int> lowerGrades = grades.OrderByDescending(grade => grade)
                .SkipWhile( grade => grade >= 80);
            //skip elements of an array as long as a condition is true.
            Console.WriteLine("All grades below 80:");
            foreach (int grade in lowerGrades)
            {
                Console.WriteLine(grade);
            }

            #endregion

            #region Into - Let
            Console.WriteLine("=================================Into - Let===============================================");
            List<string> strings = new List<string> {"Ali" , "Islam" , "Eman" , "Nada" , "Osama" , "Mohamed"};
            //Into & Let ==> in Query Syntax only

            Console.WriteLine("=================================Into===============================================");

            var Result03 = from name in strings
                           select Regex.Replace(name, "[aeiouAEIOU]", string.Empty)
                           into newNames
                           where newNames.Length > 3
                           select newNames;
            foreach (var item in Result03)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=================================Let===============================================");

            Result03 = from name in strings
                       let newNames = Regex.Replace(name, "[aeiouAEIOU]", string.Empty)
                       where newNames.Length > 3
                       select newNames;
            foreach (var item in Result03)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
