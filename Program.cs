using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PracticeQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            Test.TestCSharpTutorial.TestPoint();
            General.WaitToExit();
        }

        public static void stuff()
        {
            int[] test = { 1, 2, 3, 4, 5 };
            var res = from x in test
                      where x < 3
                      select x;
            double sum = (from x in test
                      where x < 3
                      select x).Average();
            foreach (var x in res)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(sum);
        }
    }
}
