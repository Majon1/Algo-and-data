using System;
using System.Collections.Generic;

namespace Part5
{
    public class Components
    {
        public int n;
        public List<int>[] graph;
        public List<int> visited;


        public Components(int n)
        {
            this.n = n;
            this.graph = new List<int>[n + 1];
            this.visited = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                graph[i] = new List<int>();
            }
        }
        public void AddConnection(int a, int b)
        {
            this.graph[a].Add(b);
            this.graph[b].Add(a);
        }
        public int Calculate()
        {
            bool[] visited = new bool[n];
            int sum = 0;
            int find = 1;
            foreach (bool item in visited)
            {
                if (item == false)
                {
                    DFS(find, visited);
                    sum++;
                }
            }
            return sum;
        }
        public void DFS(int v, bool[] visited)
        {
            visited[v] = true;

            foreach (int x in graph[v])
            {
                if (!visited[x]) DFS(x, visited);
            }
        }
    }
}