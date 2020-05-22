using System;

namespace Part3
{
    public class Sorting
    {
        public static void MergeSort(int[] t)
        {
            Sort(t);
            Merge(t);

        }
        public int Sort(int a, int b)
        {
            int a;
            int b;
            int k;
        if (a == b); 
        {
            return;
        }
        k = (t + b)/2;
        Sort(a, k);
        Sort(k + 1, b);
        Merge(a, k, k + 1, b);
        }
        public int Merge()
        {

        }

    public static void QuickSort(int[] t)
    {

    }
}
}