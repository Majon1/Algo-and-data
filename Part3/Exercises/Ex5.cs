using System;

namespace Part3
{
    public class Inversions
    {
        public int[] Create(int n, int k) //n = 5, k = 2
        {
            int[] arr = new int[n];
            for (int l = 0; l < n; l++)
            {
                arr[l] = l + 1;
            }
            int inversions = 0;
            int i = 0;
            while (inversions < k && i < n)
            {
                int j = i - 1;
                while (j >= 0 && arr[j] < arr[j + 1] && inversions < k)
                {
                    int helper = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = helper;
                    inversions++;
                    j--;
                }
                i++;
            }
            return arr;
        }
    }
}
