using System.Diagnostics;
using NUnit.Framework;

namespace CodeTest.UnitTests.Common
{
    [TestFixture]
    public class ThreeAndFiveMultiplierTests
    {
        [Test]
        public void Test()
        {
            long result = 0;
            for (long i = 3; i < 1000; i++)
            {
                if (i%3 == 0 || i%5 == 0)
                {
                    Trace.WriteLine(i);
                    result += i;
                }
            }
            Trace.WriteLine(result);
        }
    }
}