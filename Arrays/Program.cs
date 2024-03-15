using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            //array
            int[]a = new int[5] {1,2,3,4,5};
            string[] b = new string[5] { "one", "two", "three", "fore", "five" };

            /*System.Console.WriteLine(a[0]);
            System.Console.WriteLine(a[1]);
            System.Console.WriteLine(a[2]);
            System.Console.WriteLine(a[3]);
            System.Console.WriteLine(a[4]);
            System.Console.WriteLine();
            System.Console.WriteLine(b[0]);
            System.Console.WriteLine(b[1]);
            System.Console.WriteLine(b[2]);
            System.Console.WriteLine(b[3]);
            System.Console.WriteLine(b[4]);
            System.Console.ReadKey();
            */
            //for loop
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}
            //Console.WriteLine();

            //for(int i=0;i<b.Length; i++)
            //{
            //    Console.WriteLine(b[i]);
            //}


            //foreach loop
            /*foreach(string i in b)
            {
                Console.WriteLine(i);
            }
            //reverse
            for(int i = b.Length-1; i >= 0; i--)
            {
                Console.WriteLine(b[i]);
            }
            */

            //indexOf
            ////int n = Array.IndexOf(a, 5);
            //Console.WriteLine("Element is found at index:"+ n);

            ////BinarySearch
            //int m = Array.BinarySearch(b, "three");
            //Console.WriteLine("Element is found at index:" + m);

            ////clear()
            ////Array.Clear(a, 0, a.Length);

            ////Resize()
            ///*Array.Resize(ref a, 3);

            //for(int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}
            //*/
            ////sort()
            //Array.Sort(a);
            ////Reverse()
            //Array.Reverse(a);


            ////jagged array
            //int[][] c = new int[5][];
            //c[0] = new int[3] { 10, 20, 30 };
            //c[1] = new int[4] { 1, 2, 3, 4 };
            //c[2] = new int[5] {22,21,23,34,45};
            //c[3] = new int[2] { 7, 77 };
            //c[4] = new int[1] { 8 };

            //for(int i=0;i<5;i++)
            //{
            //    for(int j = 0; j < c[i].Length; j++)
            //    {
            //        Console.Write(c[i][j]);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine() ;
            //}

            List<int> MyList = new List<int>() { 10, 26,26, 43, 12, 34, 90 };

            List<int> NewList = MyList.FindAll(x => x <= 43);
            foreach(int item in NewList)
            {
                Console.WriteLine(item);
            }
            int FirstFailedMarks = MyList.Find(m => m < 26);
            Console.WriteLine(FirstFailedMarks);
            Console.ReadKey();

        }
    }
}
