using System;
using System.Diagnostics;
using CodeTest.Poland.Pgs;
using NUnit.Framework;

namespace CodeTest.UnitTests.Poland.Pgs
{
    [TestFixture]
    public class PgsProblemTests
    {
        [Test]
        [TestCase("aaa", 1)]
        [TestCase("abccda", 0)]
        [TestCase("abcbca", 1)]
        public void Test1(string str, int res)
        {
            Assert.That(new Problem1().Solution(str),Is.EqualTo(res));
        }

        [Test]
        [TestCase(new [] { 2, 3, -1, 1, 3 }, 4)]
        [TestCase(new[] { 1, 1, -1, 1 }, -1)]
        public void Test2(int[] a, int res)
        {
            Assert.That(new Problem2().Solution(a),Is.EqualTo(res));
        }

        [Test]
        [TestCase(6, new[] { 1, 8, -3, 0, 1, 3, -2, 4, 5 },7)]
        public void Test3(int k, int[] a, int res)
        {
            Assert.That(new Problem3().Solution(k, a), Is.EqualTo(res));
        }

        [Test]
        [TestCase("07", 3)]
        public void Test4(string str, int res)
        {
            Assert.That(new Problem4().Solution(str),Is.EqualTo(res));
        }
    }
}