namespace CodeTest.Poland.Pgs
{
    public class Problem2
    {
        public int Solution(int[] A)
        {
            int index = A[0];
            int jumps = 1;
            while (index > 0 && index < A.Length)
            {
                int val = A[index];
                if (val == 0)
                    return -1;

                A[index] = 0;
                jumps++;
                index = index + val;
            }
            return jumps;
        }
    }
}