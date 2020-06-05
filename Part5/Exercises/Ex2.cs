using System;
using System.Collections.Generic;

namespace Part5
{
    public class Connectivity
    {
        public int n;
        public List<int>[] graph;
        public List<int> visits;

        public Connectivity(int n)
        {
            this.n = n;
            this.graph = new List<int>[n + 1];
            for (int i = 1; i <= n; i++)
            {
                graph[i] = new List<int>();
            }
            this.visits = new List<int>();
            
        }
        public void AddConnection(int a, int b)
        {
            this.graph[a].Add(b);
            this.graph[b].Add(a);
        }
        public int Calculate(int x)
        {
            if (visits.Contains(x))
            {
                return 0;
            }
            visits.Add(x);
            foreach (int i in graph[x])
            {
                Calculate(i);
            }
            return visits.Count - 1;
        }
    }
}
