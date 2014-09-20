using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
using CodeTest.London.Intechnica;
using NUnit.Framework;

namespace CodeTest.UnitTests.London.Intechnica
{
    [TestFixture]
    public class IntechnicaProblemTests
    {
        private Problem _problem;

        [SetUp]
        public void SetUp()
        {
            _problem = new Problem();
        }

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

            //Assert.That(_problem.Resolve(), Is.True);
        }

        [Test]
        public void ResolveTest1()
        {
            string s1 = "1233";
            string s2 = "2244";
            //s1[3] = 'G';
            Console.Write("{0}", s1[1] == s2[1]);

            //Assert.That(_problem.Resolve(), Is.True);
            
        }
        [Test]
        public void ResolveTest2()
        {
            string readLine = Console.ReadLine();
            PrintNumbers(0);
        }
        [Test]
        public void ResolveTest3()
        {
            string readLine = Console.ReadLine();
            foreach (var r in GetPairs(2,new []{1,5,3,4,2}))
            {
                Console.WriteLine(r[0] + " " + r[1]);
            }
        }
        public IEnumerable<int[]> GetPairs(int k, int[] inpput)
        {
            Array.Sort(inpput);
            for (int i = 0; i < inpput.Length; i++)
            {
                int current = inpput[i];
                if (Array.Exists(inpput, p => p == current + k));
                yield return new[] {current, current + k};
            }
        }

        public void PrintNumbers(long n)
        {
            for (long i = 1; i <= n; i++)
            {
                bool fizzDetected = i>=3 && i % 3 == 0;
                bool buzzDetected = i>=5 && i % 5 == 0;

                if (!fizzDetected && !buzzDetected)
                    Console.WriteLine(i);
                else
                {
                    if (fizzDetected)
                        Console.Write("Fizz");
                    if (buzzDetected)
                        Console.Write("Buzz");
                    Console.WriteLine();
                }
            }
        }
    }
}