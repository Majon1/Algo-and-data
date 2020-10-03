using System;
namespace Examprep
{
    public class Numbers
    {    
       public int Steps(int x)
       {
        int i = 1;
        int sum = 0;
        int count = 0;
        
        while( sum < x)
        {
            sum = sum + i;
            i++;
            count++;
        }
        return count;
       }

    }
}