using System;

namespace Examprep
{
    public class ShortenArray
    {
        public int Calculate(int[] input)
        {
           int n = input.Length;
           int i=0;
           int k=0;

           for (i = 0; i<(n-1);)
           {
               if((input[i] == input[i+1]) && (input[i] == input[i + 2]))
               {
                   for(k=i+1;k<(n-1);k++)
                   {
                       input[k]=input[k+1];
                   }
                   --n;
               }
               else
               i++;
           }
           return n;
        }
    }
}
////SORTED