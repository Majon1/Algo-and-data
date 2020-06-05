using System;

namespace Part5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EX2
            /* Connectivity c = new Connectivity(6);
             c.AddConnection(1, 2);
             c.AddConnection(2, 3);
             c.AddConnection(1, 3);
             c.AddConnection(3, 4);
             c.AddConnection(5, 6);
             Console.WriteLine(c.Calculate(1)); // 3*/

            Console.WriteLine();

            //EX3
            Components k = new Components(6);
            k.AddConnection(1, 2);
            k.AddConnection(2, 3);
            k.AddConnection(1, 3);
            k.AddConnection(3, 4);
            k.AddConnection(5, 6);
            Console.WriteLine(k.Calculate()); // 2
        }
    }
}