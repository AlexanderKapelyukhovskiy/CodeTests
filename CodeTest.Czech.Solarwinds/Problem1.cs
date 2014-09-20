using System;
using System.Collections.Generic;

namespace CodeTest.Czech.Solarwinds
{
    //Codility
    public class Problem1
    {
        public class Tree
        {
            public Tree l;
            public Tree r;
            public int x;
        }

        public class ProblemSolution
        {
            public static int GetVisibleCount(Tree top)
            {
                if (top == null)
                    return 0;
                int max = top.x;

                var stack = new Stack<Tree>();
                int count = 0;
                while (top != null || stack.Count != 0)
                {
                    if (stack.Count != 0)
                    {
                        top = stack.Pop();
                        top = top.r;
                    }
                    while (top != null)
                    {
                        top.x = Math.Max(top.x, max);
                        if (top.x > max)
                            count++;

                        stack.Push(top);
                        top = top.l;
                    }
                }
                return count;
            }
        }
    }
}