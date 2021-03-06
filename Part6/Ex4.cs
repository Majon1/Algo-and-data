/*using System;
using System.Collections.Generic;

namespace Part6
{
    public class Edge4
    {
        public int beginning, end, weight;

        public Edge4(int beginning, int end, int weight)
        {
            this.beginning = beginning;
            this.end = end;
            this.weight = weight;
        }
    }
    public class ShortestPath
    {
        public int n;
        public List<Edge4> edges;
        public ShortestPath(int n)
        {
            this.n = n;
            this.edges = new List<Edge4>();
        }
        public void AddRoad(int a, int b, int d)
        {
            this.edges.Add(new Edge4(a, b, d));
            this.edges.Add(new Edge4(b, a, d));
        }
        public List<int> Create(int x, int y)
        {
            int INF = 9999;
            int[] distance = new int[n + 1];
            for (int i = 1; i < n + 1; i++)
            {
                distance[i] = INF;
            }
            distance[x] = 0;
            while (true)
            {
                bool change = false;
                foreach (Edge4 edge in edges)
                {
                    int current = distance[edge.end];
                    int newC = distance[edge.beginning] + edge.weight;
                    if (newC < current)
                    {
                        distance[edge.end] = newC;
                        change = true;
                    }
                }
                if (change == false)
                {
                    break;
                }
            }
        }
    }
}*/
