using System;

namespace Part3
{
    public class SmallestDifference
    {
        public int Calculate(int[] t)
        {   
            Array.Sort(t);
           int minDifference = t[1] - t[0]; 
            for (int i = 2; i != t.Length; i++)
           {
               minDifference = Math.Min(minDifference, t[i] - t[i - 1]);
           } 
           return minDifference;
        }
    }
}