using System;

namespace CodeTest.Poland.Pgs
{
    public class Problem1
    {
        public int Solution(string s)
        {
            char[] line = s.ToCharArray();
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
                    if (curCount % 2 != 0)
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