using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace Part1
{
    public class LuckyNumbers
    {
        private int a { get; set; }
        private int b { get; set; }
        public int Calculate(int a, int b) //returns the amount of lucky numbers
        {   
            int sum = 0;
            List<string> range = new List<string>();
            for (int i = a; i <= b; i++)
            {
                range.Add(Convert.ToString(i));
            }
         foreach (string num in range)
            {
                if ((num.Contains("3")) && (num.Contains("7")))
                {
                    sum++;
                }
                else if (num.Contains("3"))
                {
                    sum++;
                }
                else if (num.Contains("7"))
                {
                    sum++;
                }
            }
            return sum;
            



       /* foreach (string num in range)
        {
            if (range.Contains("3"))
            {
                sum = sum + 1;
            }
            if (range.Contains("7"))
            {
                sum = sum + 1;
            }
            if ((range.Contains("3")) && (range.Contains("7")))
            {
                sum = sum + 1;
            }
         }
         return sum;
        }*/
         
    }



           /*
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                int n = i * 10; 
                if ((a <= n + 3) && (n + 3 <= b))
                {
                    sum++;
                }
                if ((a <= n + 7) && (n + 7 <= b))
                {
                    sum++;
                }
            }
            return sum;

            
            
            /*int beginning = a;
            int end = b;
            int sum = 0;
             for (int i = beginning; i <= end; i++)
             {
                 if (CheckNumber(i))
                 {
                     sum++;
                 }
                 
             }
             return sum;
        }
       /* static bool CheckNumber(int num)
        {
            while (num != 0)
            {
                if ((num % 10 == 3) || (num % 10 == 7))
                {
                  //  num = num / 10;
                    return true;
                }
            }
            return false;/
           /* int rem = 0;
            while (num != 0)
            {
                rem = num % 10;
                if(rem != 2 || rem != 5)
                {
                    num = num / 10;
                }
                return false;
            }
            return true;*/
        
        
        /* int result = 0;
         for (int i = a; a <= b; i++)
         {
             result += has3(i);
         }
         return result;
     }
     public bool has3 (int i)
     {
         while (i != 0)
         {
             if (i % 10 == 3)
             {
                 return true;     
             }
             i = i / 10;
         }
         return false;
     }


            

         int sum3 = 0;
          int sum7 = 0;
          int summa = 0;

          for (int i = a; i <= b; i++)
          {
              sum3 = i * 10 + 3;
              sum7 = i * 10 + 7;
              if (a <= sum3 && sum3 <= b) 
              {
                  summa = summa + 1;
              }
              if (a <= sum7 && sum7 <= b)
              {
                  summa = summa + 1;
              }
              i++;
          }
          return summa;
      } /*
                     int sum = 0;
                     List<int> numb = new List<int>();
                     for (int i = a; i <= b; i++)
                     {
                         numb.Add(i);
                     }
                     for (int j = a; j <= b; j++)
                     {
                         if (numb.Contains(3))
                         {
                             sum++;

                         }
                         if (numb.Contains(7))
                         {
                             sum++;      
                         }
                     }
                     return sum;
                 }


         int sum = 0;
         for (int i = a; i <= b; i++)
         {
             if (i % 10 == 3 || i % 10 == 7)
             {
                 sum++;
             }
         }
         return sum;


         int first = 3;
                   int second = 7;
                   int sum = 0;

                   for (int i = a; i <= b; i++)
                   {
                       if (i == first || i == second)
                       {
                           sum++;
                       }
                   }
                   return sum;*//*
                    int sum = 0;
                    for (int i = a; i < b; i++)
                    {
                        if (i == 3)//(3 >= a && 3 <= b)
                        {
                            sum++;
                        }
                        if (i == 7)
                        {
                            sum++;
                        }
                    }
                    return sum;

                    //if ((3 >= a && 3 <= b) || (7 >= a && 7 <= b))*/

    }
}