using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Part1
{
    public class Substrings
    {
        public int Calculate(string a, string b)
        {
            int start = 0;
            int count = -1;
            int idx = -1;

            while (start != -1)
            {
                start = a.IndexOf(b, idx + 1);
                count += 1;
                idx = start;
            }
            return count;
        }
    }
}
