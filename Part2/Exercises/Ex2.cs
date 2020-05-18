using System;

namespace Part2
{
    public class LongestRepetition
    {
        public int Calculate(int[] t)
        {
            int repetition = 1;
            //int j = t[i - 1];
            for (int i = 1; i < t.Length; i++)
            {
                    if (t[i] == t[i - 1])
                    {
                        repetition++;
                    }
            }
            return repetition;

            //ex 90
        }
    }
}