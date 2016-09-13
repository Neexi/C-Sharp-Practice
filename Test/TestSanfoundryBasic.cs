using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion.Test
{
    class TestSanfoundryBasic
    {

        public static void TestEvenOdd()
        {
            Console.WriteLine("Check odd or even");
            int num1 = General.ReadNumberFromInput(1)[0];
            Console.WriteLine(num1 + " is even : " + SanfoundryBasic.IsEven(num1));
        }

        public static void TestSwap()
        {
            Console.WriteLine("Swapping 2 numbers");
            List<int> nums = General.ReadNumberFromInput(2);
            int num1 = nums[0];
            int num2 = nums[1];
            Console.WriteLine("num 1 is " + num1 + ", num2 is " + num2);
            Console.WriteLine("Swapping...");
            SanfoundryBasic.SwapNumber(ref num1, ref num2);
            Console.WriteLine("num 1 is " + num1 + ", num2 is " + num2);
        }

        public static void TestSumDigit()
        {
            Console.WriteLine("Sum Digit Function");
            int num1 = General.ReadNumberFromInput(1)[0];
            Console.WriteLine("Digit sum of " + num1 + " is " + SanfoundryBasic.SumDigit(num1));
        }

        public static void TestReverse()
        {
            Console.WriteLine("Reverse Function");
            int num1 = General.ReadNumberFromInput(1)[0];
            Console.WriteLine("Reverse of " + num1 + " is " + SanfoundryBasic.Reverse(num1));
        }

        public static void TestTriangle()
        {
            Console.WriteLine("Drawing Triangle");
            int num1 = General.ReadNumberFromInput(1)[0];
            Console.WriteLine("Triangle with height " + num1);
            SanfoundryBasic.PrintTriangle(num1);
        }

        public static void TestCountOccurence()
        {
            Console.WriteLine("Count occurence of number in a list");
            Console.WriteLine("Specify the list size");
            int listSize = General.ReadNumberFromInput(1)[0];
            Console.WriteLine("Input the list element");
            List<int> list = General.ReadNumberFromInput(listSize);
            Console.WriteLine("The list is [" + string.Join(", ", list.ToArray()) + "]");
            Console.WriteLine("Input the number to be searched");
            int num = General.ReadNumberFromInput(1)[0];
            Console.WriteLine("There are " + SanfoundryBasic.CountOccurence(list, num) + " occurences of " + num + " in the list");
        }

        public static void TestIsLeapYear()
        {
            Console.WriteLine("Is Leap Year?");
            Console.WriteLine("Specify the test number");
            int testNumber = General.ReadNumberFromInput(1)[0];
            Console.WriteLine("Input the test cases");
            List<int> list = General.ReadNumberFromInput(testNumber);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i] + " is" + (SanfoundryBasic.IsLeapYear(list[i]) ? "" : " not") + " a leap year");
            }
        }

        public static void TestAtmSimulation()
        {
            SanfoundryBasic.AtmSimulation();
        }

        public static void TestRollDice()
        {
            SanfoundryBasic.RollDice();
        }

        public static void TestPhonebookSimulation()
        {
            SanfoundryBasic.PhonebookSimulation();
        }
    }
}
