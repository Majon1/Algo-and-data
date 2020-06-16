using System;

namespace Part6
{
    public class Program
    {
        public static void Main(string[] args)
        {   //EX1
            BellmanFord s = new BellmanFord(5);
            s.AddRoad(1, 2, 7);
            s.AddRoad(2, 4, 2);
            s.AddRoad(1, 3, 6);
            s.AddRoad(3, 4, 5);
            s.AddRoad(4, 5, 3);
            //s.AddRoad(6, 7, 3);
            Console.WriteLine(s.Calculate(1, 5)); // 12

            Console.WriteLine();
            //EX2
          /*  Dijkstra d = new Dijkstra(5);
            d.AddRoad(1, 2, 7);
            d.AddRoad(2, 4, 2);
            d.AddRoad(1, 3, 6);
            d.AddRoad(3, 4, 5);
            d.AddRoad(4, 5, 3);
            Console.WriteLine(d.Calculate(1, 5)); // 12 */

            Console.WriteLine();
            //EX3
            FloydWarshall a = new FloydWarshall(5);
            a.AddRoad(1, 2, 7);
            a.AddRoad(2, 4, 2);
            a.AddRoad(1, 3, 6);
            a.AddRoad(3, 4, 5);
            a.AddRoad(4, 5, 3);
            Console.WriteLine(a.Calculate(1, 5)); // 12

            Console.WriteLine();
            //EX4
           /* ShortestPath k = new ShortestPath(5);
            k.AddRoad(1, 2, 7);
            k.AddRoad(2, 4, 2);
            k.AddRoad(1, 3, 6);
            k.AddRoad(3, 4, 5);
            k.AddRoad(4, 5, 3);
            k.Create(1, 5).ForEach(Console.Write); // 1245*/

        }
    }
}
