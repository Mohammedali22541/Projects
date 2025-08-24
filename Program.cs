using Session_1_C__Advance.Classes;
using Session_1_C__Advance.Example_1;
using Session_1_C__Advance.NewFolder;
using System.Collections;


namespace Session_1_C__Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment

            #region Question 1

            //Classes.Range<int> range = new Classes.Range<int>(13, 20);
            //
            //bool Isinrange =   range.IsInRange(15);
            //Console.WriteLine(Isinrange);
            //
            //int length = range.Length();
            //Console.WriteLine(length);

            #endregion

            #region MyRegion
            FixedSizeList<int> fixedSize = new FixedSizeList<int> (10);
            fixedSize.Add (10);
            Console.WriteLine(fixedSize.Get(0));
            

            
            #endregion

            #endregion

            #region Demo
            #region Example 1
            #region Without Generic
            //int a = 2 , b = 3 ;
            //Console.WriteLine($"A = {a}"); // A = 2
            //Console.WriteLine($"B = {b}"); // B = 3

            //Helper.Swap(ref a, ref b);
            //Console.WriteLine("After Swap");
            //Console.WriteLine($"A = {a}"); // A = 3
            //Console.WriteLine($"B = {b}"); // B = 2




            //decimal m = 2.2m , n = 3.5m;
            //Console.WriteLine($"A = {m}"); // A = 2.2
            //Console.WriteLine($"B = {n}"); // B = 3.5

            //Helper.Swap(ref m, ref n);
            //Console.WriteLine("After Swap");
            //Console.WriteLine($"A = {m}"); // A = 3.5
            //Console.WriteLine($"B = {n}"); // B = 2.2



            //Point p1 = new Point(5, 10);
            //Point p2= new Point(50, 100);
            //Console.WriteLine($"P1 = {p1}"); // P1 = X = 5 , Y  = 10
            //Console.WriteLine($"P2 = {p2}"); // P2 = X = 50 , Y  = 100

            //Helper.Swap(ref p1, ref p2);
            //Console.WriteLine("After Swap");
            //Console.WriteLine($"P1 = {p1}"); // P1 = X = 50 , Y  = 100
            //Console.WriteLine($"P2 = {p2}"); // P2 = X = 5 , Y  = 10 
            #endregion

            #region Generic

            //int a = 2, b = 3;
            //Console.WriteLine($"A = {a}"); // A = 2
            //Console.WriteLine($"B = {b}"); // B = 3
            //
            //Helper.Swap<int>(ref a, ref b);
            //Console.WriteLine("After Swap");
            //Console.WriteLine($"A = {a}"); // A = 3
            //Console.WriteLine($"B = {b}"); // B = 2




            //decimal m = 2.2m, n = 3.5m;
            //Console.WriteLine($"A = {m}"); // A = 2.2
            //Console.WriteLine($"B = {n}"); // B = 3.5

            //Helper.Swap<decimal>(ref m, ref n);
            //Console.WriteLine("After Swap");
            //Console.WriteLine($"A = {m}"); // A = 3.5
            //Console.WriteLine($"B = {n}"); // B = 2.2



            //Point p1 = new Point(5, 10);
            //Point p2 = new Point(50, 100);
            //Console.WriteLine($"P1 = {p1}"); // P1 = X = 5 , Y  = 10
            //Console.WriteLine($"P2 = {p2}"); // P2 = X = 50 , Y  = 100
            //
            //Helper.Swap<Point>(ref p1, ref p2);
            //Console.WriteLine("After Swap");
            //Console.WriteLine($"P1 = {p1}"); // P1 = X = 50 , Y  = 100
            //Console.WriteLine($"P2 = {p2}"); // P2 = X = 5 , Y  = 10 
            #endregion
            #endregion

            #region Example 2

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int value =  5;

            //int index =  Helper<int>.LinearSearch(numbers, value);
            //Console.WriteLine(index);


            //Point[] points =
            //{
            //    new Point(10,20),
            //    new Point(100,200),
            //    new Point(1000,2000),
            //    new Point(10000,20000),
            //    new Point(100000,200000),
            //};

            //Point point = new Point(1000, 2000);

            //int index = Helper<Point>.LinearSearch(points, point);
            //Console.WriteLine(index);




            #endregion

            #region Example 3

            //Employee[] employees = {
            //    new Employee (10 , "mo" , 5000),
            //    new Employee (20 , "salma" , 500),
            //    new Employee (30 , "Omar" , 2000),
            //    new Employee (40 , "ahmed" , 10000),
            //};

            //Employee employee = new Employee(0, "salma", 0);
            //Employee employee = new Employee(20, null, 0);

            //int index = Helper<Employee>.LinearSearch(employees, employee);
            //Console.WriteLine(index);

            //int index = Helper<Employee>.LinearSearch(employees, employee,new IEqulaityComparerByNamecs());
            //Console.WriteLine(index);

            //int index = Helper<Employee>.LinearSearch(employees, employee , new IEqualityComparerById());
            //Console.WriteLine(index); 
            #endregion
            #region Question 2

            ////ArrayList numbers = new ArrayList(){ 1, 2, 3, 4, 5, 6 };
            ////Utility.Swap(ref numbers);
            ////foreach (int num in numbers)
            ////{
            ////    Console.WriteLine(num);
            ////}
            #endregion

            #region Question 3

            //int[] num = { 1, 2, 3 , 4 , 5 , 6 , 7 , 8};
            //Utility.GetEvenNumbers(ref num);
            //foreach (int item in num)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion







        }
    }
}
