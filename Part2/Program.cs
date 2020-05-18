using System;
using System.Text;

namespace Part2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            /* EX 1
            Counter counter = new Counter();
            string input10 = counter.CreateInput(10);
            string input100 = counter.CreateInput(100);
            string input1000 = counter.CreateInput(1000);
            string input10000 = counter.CreateInput(10000);


            DateTime start1 = DateTime.Now;
            counter.Counter1(input100);
            DateTime end1 = DateTime.Now;
            Console.WriteLine("Time this took: " + end1.Subtract(start1));

            Console.WriteLine();

            DateTime start2 = DateTime.Now;
            counter.Counter2(input100);
            DateTime end2 = DateTime.Now;
            Console.WriteLine("Time this took: " + end2.Subtract(start2));*/


            //EX 2
           /* LongestRepetition p = new LongestRepetition();
            Console.WriteLine(p.Calculate(new int[] { 1, 2, 1, 1, 2 })); // 2
            Console.WriteLine(p.Calculate(new int[] { 1, 2, 3, 4, 5 })); // 1
            Console.WriteLine(p.Calculate(new int[] { 1, 1, 1, 1, 1 })); // 5
            Console.WriteLine(p.Calculate(new int[] { 5, 5, 1, 1, 1 })); // 3
        */
            //EX3
            Changes m = new Changes();
            Console.WriteLine(m.Calculate(new int[] { 1, 1, 2, 2, 2 })); // 2
            Console.WriteLine(m.Calculate(new int[] { 1, 2, 3, 4, 5 })); // 0
            Console.WriteLine(m.Calculate(new int[] { 1, 1, 1, 1, 1, 1})); // 2

        }
    }
}