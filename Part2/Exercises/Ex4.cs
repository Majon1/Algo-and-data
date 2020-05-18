using System;
using System.Collections.Generic;


namespace Part2
{
    public class Revolutions
    {
        public int Calculate(int[] t)
        {   int n = 0;
            foreach (int num in t)
            {
                if (num > n)
                {
                    n = num;
                }
            }
            // biggest value
            int pick = 1;
            int revolutions = 0;
            while (pick <= n)
            {
                foreach (int numb in t)
                {
                    if (numb == pick)
                    {
                        pick++;
                    }
                }
                revolutions++;
            }
            return revolutions;
        }
    }
}
