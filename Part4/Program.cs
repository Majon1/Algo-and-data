using System;

namespace Part4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* //EX1
             LinkedList myLinks = new LinkedList();
             myLinks.AddLast(1);
             myLinks.AddFirst(2);
             myLinks.AddLast(3);
             Console.WriteLine(myLinks); // for example: 2, 1, 3
             myLinks.RemoveFirst();
             Console.WriteLine(myLinks); // for example: 1, 3
             Console.WriteLine(myLinks.GetNode(0)); // 1
             Console.WriteLine(myLinks.GetNode(1)); // 3 */

            Console.WriteLine();

            //EX2
            CircleGame g = new CircleGame();
            Console.WriteLine(g.Last(7)); // 7
            Console.WriteLine(g.Last(4)); // 1
            Console.WriteLine(g.Last(123)); // 119
        }
    }

}