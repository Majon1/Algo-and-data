using System;
using System.Text;

namespace Part2
{
    public class Counter
    {
        public string CreateInput(int n)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                sb.Append(random.Next(0, 2).ToString());
            }
            return sb.ToString();
        }
        public void Counter1(string n)
        {
            int counter = 0;
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = 0; j < n.Length; j++)
                {
                    if (n[i].ToString() == "0" && n[j].ToString() == "1")
                    {
                        counter += 1;
                    }
                }
            }
            Console.WriteLine(counter);
        }
         public void Counter2(string n)
        {
            int counter = 0;
            int zeros = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i].ToString() == "0")
                {
                    zeros += 1;
                }
                else
                {
                    counter += zeros;
                }
            }
            Console.WriteLine(counter);
        }
    }
}