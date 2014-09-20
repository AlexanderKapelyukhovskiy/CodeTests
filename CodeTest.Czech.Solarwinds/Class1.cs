using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
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


    public int solution(Tree T)
    {
        return ProblemSolution.GetVisibleCount(T);
        // write your code in C# 5.0 with .NET 4.5 (Mono)
    }
}
