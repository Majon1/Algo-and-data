using System;

namespace Part2
{
    public class Split
    {
        public int Calculate(int[] t)
        { int l = t.Length;
            int left = 0;
            int right = 0;
            int sum = 0;

            for (int i = 0; i < l; i++)
            {
                left += t[i];
            }
            
            for (int i = l - 1; i > 0; i--)
            { 
                right += t[i];
                left -= t[i];
                if (right == left)
                {
                    sum++;
                }
            }
            return sum;
        }
    }
}