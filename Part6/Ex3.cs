using System;
using System.Collections.Generic;

namespace Part6
{
    public class Edge2
    {
        public int beginning, end;
        public int weight;

        public Edge2(int beginning, int end, int weight)
        {
            this.beginning = beginning;
            this.end = end;
            this.weight = weight;
        }
    }
    public class FloydWarshall
    {
        public int n;
        public List<Edge2> edges2;
        public int vertices, edges;
        public int[,] adjMatrix;
        public int[,] parent;

        public FloydWarshall(int n)
        {
            this.n = n;
            this.edges2 = new List<Edge2>(edges);
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
            // this.edges2.Add(new Edge2(a, b, d));
        }
        public int Calculate(int x, int y)
        {
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
            for (int k = 1; k < n + 1; k++)
            {
                for (int l = 1; l < n + 1; l++)
                {
                    for (int j = 1; j < n + 1; j++)
                    {
                        if (distance[l, k] == int.MaxValue || distance[k, j] == int.MaxValue) //Math.Min(distance[l, j], distance[l, k] + distance[k, j]);
                        {
                            continue;
                        }
                        if(distance[l, j] > distance[l, k] + distance[k, j])
                        {
                            distance[l, j] = distance[l, k] + distance[k, j];
                            parent[l, j] = parent[k, j];
                        }
                    }
                }
            }
            return distance[x, y];
        }
    }
}