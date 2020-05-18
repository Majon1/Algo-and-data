using System;

namespace Part2
{
    public class LongestRepetition
    {
        public int Calculate(int[] t)
        {
            int longest = 0;
            int repetition = 1;

            for (int i = 0; i < t.Length - 1; i++)
            {
                if (t[i] == t[i + 1])
                {
                    repetition++;
                }
                else
                {
                    repetition = 1;
                }
                if (repetition > longest)
                {
                    longest = repetition;
                }
            }
            return longest;

            //ex 90
        }
    }
}