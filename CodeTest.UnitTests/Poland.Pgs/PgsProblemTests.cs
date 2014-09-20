using System;
using System.Diagnostics;
using NUnit.Framework;

namespace CodeTest.UnitTests.Poland.Pgs
{
    [TestFixture]
    public class PgsProblemTests
    {
        [Test]
        public void Test1()
        {
            Trace.WriteLine(Solution("aaa"));
            Trace.WriteLine(Solution("abccda"));
        }

        [Test]
        public void Test2()
        {
            Trace.WriteLine(Solution2(new int[] {2, 3, -1, 1, 3}));
            Trace.WriteLine(Solution2(new int[] { 1,1,-1,1 }));

        }

        [Test]
        public void Test3()
        {
            Trace.WriteLine(Solution3(6, new int[] { 1, 8, -3, 0, 1, 3, -2, 4, 5 }));

        }


        public static byte[] StringToByteArrayFastest(string hex)
        {
            if (hex.Length % 2 == 1)
                throw new Exception("The binary key cannot have an odd number of digits");

            byte[] arr = new byte[hex.Length >> 1];

            for (int i = 0; i < hex.Length >> 1; ++i)
            {
                arr[i] = (byte)((GetHexVal(hex[i << 1]) << 4) + (GetHexVal(hex[(i << 1) + 1])));
            }

            return arr;
        }

        public static int GetHexVal(char hex)
        {
            int val = (int)hex;
            return val - (val < 58 ? 48 : 55);
        }

        public int CountBits(int b)
        {
            int c = 0;
            while (b != 0)
            {
                if ((b & 1) != 0) c++;
                b = b >> 1;
            }
            return c;
        }
        public int Solution4(string s)
        {
            var bytes = StringToByteArrayFastest(s);
            int count = 0;
            foreach (var b in bytes)
            {
                count += CountBits(b);
            }
            return count;
        }

        public int Solution3(int K, int[] A)
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
            if (K%2 == 0 && Array.BinarySearch(A, K/2) > 0)
                count++;

            return count;
        }

        public int Solution2(int[] A)
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


        public int Solution(string s)
        {
            char[]line = s.ToCharArray();
            Array.Sort(line);
            char current = line[0];
            int curCount = 1;
            bool singleDetect = false;

            for (int i = 1; i < line.Length; i++)
            {
                if (current != line[i])
                {
                    if (curCount == 1 && singleDetect)
                        return 0;
                    if (curCount == 1)
                        singleDetect = true;
                    if (curCount%2 != 0)
                        return 0;
                    curCount = 0;
                    current = line[i];
                }
                curCount++;
            }
            return 1;
        }
    }
}