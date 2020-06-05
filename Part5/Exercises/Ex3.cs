using System;
using System.Collections.Generic;

namespace Part5
{
    public class Components
    {
        public int n;
        public List<int>[] graph;
        public List<int> visits;

        public Components(int n)
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
        public int Calculate()
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (visits.Contains(i))
                {
                    return 0;
                }
                visits.Add(i);
                sum++;
            }
            return sum;
        }

        /*for each node
          if node not visited
             // handle component
             sum + 1
        return sum*/
    }
}