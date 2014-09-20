using System;
using System.Collections.Generic;

namespace CodeTest.London.Intechnica
{
    public class Problem1
    {
        public IEnumerable<int[]> GetPairs(int k, int[] inpput)
        {
            Array.Sort(inpput);
            for (int i = 0; i < inpput.Length; i++)
            {
                int current = inpput[i];
                if (Array.Exists(inpput, p => p == current + k)) ;
                yield return new[] { current, current + k };
            }
        }
    }
}