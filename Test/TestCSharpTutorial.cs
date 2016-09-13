using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PracticeQuestion.CSharpTutorial;

namespace PracticeQuestion.Test
{
    class TestCSharpTutorial
    {

        public static void TestCalculateAustralianTax()
        {
            Console.WriteLine("Calculate australian tax");
            int num1 = General.ReadNumberFromInput(1)[0];
            Console.WriteLine("Tax is : "+CSharpTutorial.CalculateAustralianTax(num1));
        }

        public static void TestAddChecked()
        {
            Console.WriteLine("Adding 2147483647 and 1");
            int a = int.MaxValue;
            int b = 1;
            Console.WriteLine("Overflow addition checked : "+CSharpTutorial.AddChecked(a, b, true));
            Console.WriteLine("Overflow addition unchecked : " + CSharpTutorial.AddChecked(a, b, false));
        }

        public static void TestPoint()
        {
            var a = new Point(3, 4);
            var b = new Point(6, 7);
            var c = Point.Add(a, b);
            Console.WriteLine(c.X + " " + c.Y);
        }
    }
}
