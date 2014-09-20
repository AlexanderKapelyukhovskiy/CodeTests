using System.Diagnostics;
using CodeTest.Czech.Solarwinds;
using NUnit.Framework;

namespace CodeTest.UnitTests.Czech.Solarwinds
{




    public class Solution
    {
        public static int solution(int[] A, int X)
        {
            int N = A.Length;
            if (N == 0)
            {
                return (-1);
            }
            int l = 0;
            int r = N - 1;
            while (l < r )
            {
                int m = (l + r) / 2;
                if (A[m] == X)
                    return m;
                if (A[m] >= X)
                {
                    r = m - 1;
                }
                else
                {
                    l = m + 1;
                }
            }
            if (A[r] == X)
            {
                return l;
            }
            return -1;
        }
    }



    public class SolarwindsProblemTests
    {
        private Problem _problem;

        [SetUp]
        public void SetUp()
        {
            _problem = new Problem();
        }

        [Test]
        public void ResolveProblemTest()
        {
            //Assert.That(_problem.Resolve(), Is.True);
            Trace.WriteLine(Solution.solution(new[] {1, 2, 5, 9, 9}, 5));
        }
    }
}