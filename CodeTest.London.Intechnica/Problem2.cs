using System;

namespace CodeTest.London.Intechnica
{
    public class Problem2
    {
        public void PrintNumbers(long n)
        {
            for (long i = 1; i <= n; i++)
            {
                bool fizzDetected = i >= 3 && i % 3 == 0;
                bool buzzDetected = i >= 5 && i % 5 == 0;

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