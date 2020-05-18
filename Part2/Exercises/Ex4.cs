using System;
using System.Collections.Generic;


namespace Part2
{
    public class Revolutions
    {
        public int Calculate(int[] t)
        {
            int runs = 0;
            for (int i = 0; i < t.Length - 1; i++)
            {
                int min = t[0];
                foreach(int num in t)
                {
                    if (t[i] < min)
                    {
                        min = i;
                       

                        
                    }
                    runs++;
                }
            }
            return runs;
        }
    }
}