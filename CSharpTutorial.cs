using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    class CSharpTutorial
    {
        public struct Point
        {
            public int X { get; }
            public int Y { get; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public static Point Add(Point a, Point b)
            {
                Point c = new Point(a.X + b.X, a.Y + b.Y);
                return c;
            }
        }

        public static double CalculateAustralianTax(int income)
        {
            double tax = 0;
            int[] stageVal = { 0, 18200, 37000, 80000, 180000 };
            double[] stagePercent = { 0, 0.19, 0.325, 0.37, 0.45 };
            int curStage = 0;
            while (income > 0 && curStage < stageVal.Count())
            {
                int subtract = stageVal[curStage + 1] - stageVal[curStage];
                tax += (double)Math.Min(subtract, income) * stagePercent[curStage];
                income -= subtract;
                curStage++;
            }
            return tax;
        }

        public static int AddChecked(int a, int b, bool c)
        {
            if (c)
            {
                try
                {
                    int res = checked(a + b);
                    return res;
                }
                catch (System.OverflowException e)
                {
                    // The following line displays information about the error.
                    Console.WriteLine("CHECKED and CAUGHT:  " + e.ToString());
                    return 0;
                }
            }
            else
            {
                return unchecked(a + b);
            }

        }
    }
}
