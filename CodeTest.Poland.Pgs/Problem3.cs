using System;

namespace CodeTest.Poland.Pgs
{
    public class Problem3
    {
        public int Solution(int K, int[] A)
        {
            int count = 0;
            Array.Sort(A);
            for (int i = 0; i < A.Length; i++)
            {
                int p = K - A[i];
                //int index = Array.BinarySearch(A, i, A.Length - i, p);
                int index = Array.BinarySearch(A, p);
                if (index > 0)
                    count++;
            }
            if (K % 2 == 0 && Array.BinarySearch(A, K / 2) > 0)
                count++;

            return count;
        }

    }
}