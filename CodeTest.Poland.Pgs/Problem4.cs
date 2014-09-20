using System;

namespace CodeTest.Poland.Pgs
{
    public class Problem4
    {
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
        public int Solution(string S)
        {
            var bytes = StringToByteArrayFastest(S);
            int count = 0;
            foreach (var b in bytes)
            {
                count += CountBits(b);
            }
            return count;
        }
    }
}