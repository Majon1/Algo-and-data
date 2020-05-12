using System;
using System.Linq;
using System.Collections.Generic;
namespace Part1
{
    public class Tables
    { //as a parameter give the program an array with integers

        public int Calculate(int[] t)
        {
            if (t.Length == 1)
            {
                return t.Last();
            }
            else
            {
                int[] newArray = new int[t.Length - 1];
                int sum = 0;
                int n = t.Length - 1;

                for (int i = 0; i < n; i++)
                {
                    sum = t[i] + t[i + 1];
                    newArray[i] = sum;
                }
                return Calculate(newArray);
            }

        }
    }
}