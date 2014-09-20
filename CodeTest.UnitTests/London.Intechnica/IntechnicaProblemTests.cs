using System;
using System.Diagnostics;
using CodeTest.London.Intechnica;
using NUnit.Framework;

namespace CodeTest.UnitTests.London.Intechnica
{
    [TestFixture]
    public class IntechnicaProblemTests
    {
        [Test]
        public void ResolveTest()
        {
            string s = "Hello, World.";
            Trace.Write("string = {0}",s);
            Trace.Write("String =");
            foreach (var c in s)
            {
                Trace.Write(c);
            }
        }

        [Test]
        public void ResolveTest1()
        {
            string s1 = "1233";
            string s2 = "2244";
            Console.Write("{0}", s1[1] == s2[1]);
        }
        [Test]
        public void ResolveTest2()
        {
            new Problem2().PrintNumbers(10);
        }
        [Test]
        public void ResolveTest3()
        {
            foreach (var r in new Problem1().GetPairs(2,new []{1,5,3,4,2}))
            {
                Console.WriteLine(r[0] + " " + r[1]);
            }
        }
    }
}