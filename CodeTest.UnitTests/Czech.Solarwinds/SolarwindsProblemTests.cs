using CodeTest.Czech.Solarwinds;
using NUnit.Framework;

namespace CodeTest.UnitTests.Czech.Solarwinds
{
    public class SolarwindsProblemTests
    {
        [Test]
        [TestCase(new[] { 1, 2, 5, 9, 9 }, 5, 3)]
        public void ResolveProblemTest(int[] a, int v, int res)
        {
            //Assert.That(_problem.Resolve(), Is.True);
            Assert.That(new Problem2().Solution(a, v), Is.EqualTo(res));
        }
    }
}