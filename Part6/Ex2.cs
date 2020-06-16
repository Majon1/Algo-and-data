/*using System;
using System.Collections.Generic;

namespace Part6
{
    public class Dijkstra
    {
        public int n;
        public int[,] adjMatrix;
        public int[,] parent;

        public Dijkstra(int n)
        {
            this.n = n;
            this.adjMatrix = new int[n + 1, n + 1];
            this.parent = new int[n + 1, n + 1];

            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    if (i == j)
                    {
                        adjMatrix[i, j] = 0;
                    }
                    else
                    {
                        adjMatrix[i, j] = int.MaxValue;
                    }
                }
            }
        }
        public void AddRoad(int a, int b, int d)
        {
            adjMatrix[a, b] = d;
        }
        public int Calculate(int x, int y)
        {
            int infinity = 9999;
            int[,] distance = new int[n + 1, n + 1];
            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    distance[i, j] = adjMatrix[i, j];
                    if (adjMatrix[i, j] != int.MaxValue && i != j)
                    {
                        parent[i, j] = i;
                    }
                    else
                    {
                        parent[i, j] = -1;
                    }
                }
            }
            foreach (int node in adjMatrix)
            {
                distance[node, y] = infinity;
                distance[node - 1, y] = 0;
            }
            distance[x, y] = 0;
            while (adjMatrix.Length > 0)
            {
                foreach (node + 1 && LinkedListNode - 1)
                {
                    int alt = distance[n] + distance[n, n + 1];
                }
            }

            if (distance[x, y] == infinity)
            {
                return -1;
            }
            else
            {
                return distance[x, y];
            }
        }
    }
}*/