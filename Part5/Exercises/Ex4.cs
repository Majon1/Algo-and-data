using System;
using System.Collections.Generic;

namespace Part5
{
    public class Communication
    {
        public int n;
        public List<int>[] graph;
        public List<int> visited;
        public Communication(int n)
        {
            this.n = n;
            this.graph = new List<int>[n + 1];
            for (int i = 1; i <= n; i++)
            {
                graph[i] = new List<int>();
            }
            this.visited = new List<int>();
        }
        public void AddConnection(int a, int b)
        {
            this.graph[a].Add(b);
            this.graph[b].Add(a);
        }
        public bool Examine(int x, int y)
        {bool[] visited = new bool[n];
        List<int> paths = new List<int>();
        
        paths.Add(x);
        
        
        
           /* bool[] visited = new bool[n + 1];

            foreach (int i in graph[x])
            {
                if (visited[x]) DFS(x, visited);
            }
            return true;
        }

        public void DFS(int v, bool[] visited)
        {
            visited[v] = true;

            foreach (int x in graph[v])
            {
                if (!visited[x]) DFS(x, visited);
            }
        }*/
    }
}