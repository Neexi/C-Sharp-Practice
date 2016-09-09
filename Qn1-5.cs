using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    class Qn1_5
    {
        /*
         * Qn1 : Read input from user and use it in a greeting message
         */
        public static void Greetings()
        {
            String name;
            Console.Write("Please enter your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            General.WaitToExit();
        }

        /*
         * Qn2 : Read 2 number inputs from user and print out their sum
         */
        public static void SumTwoNumbers()
        {
            int num1, num2, sum;
            string input;
            bool inputIsValid;
            Console.WriteLine("This is a function for summing two numbers");
            Console.Write("Please enter the first number : ");
            input = Console.ReadLine();
            inputIsValid = false;
            while (!inputIsValid)
            {
                inputIsValid = Int32.TryParse(input, out num1);
                if (!inputIsValid)
                {
                    Console.WriteLine("Input number is not valid");
                    Console.Write("Please enter the first number : ");
                    input = Console.ReadLine();
                }
            }
            num1 = Convert.ToInt32(input);
            Console.Write("Please enter the second number : ");
            input = Console.ReadLine();
            inputIsValid = false;
            while (!inputIsValid)
            {
                inputIsValid = Int32.TryParse(input, out num2);
                if (!inputIsValid)
                {
                    Console.WriteLine("Input number is not valid");
                    Console.Write("Please enter the second number : ");
                    input = Console.ReadLine();
                }
            }
            num2 = Convert.ToInt32(input);
            sum = num1 + num2;
            Console.WriteLine("Sum of " + num1 + " and " + num2 + " is " + sum);
            General.WaitToExit();
        }

        /*
         * Qn3 : Read 2 number inputs from user and print out their division result (two precision)
         */
        public static void DivideTwoNumbers()
        {
            int num1;
            int num2 = 0;
            double divide;
            string input;
            bool inputIsValid;
            Console.WriteLine("This is a function for dividing two numbers");
            Console.Write("Please enter the first number : ");
            input = Console.ReadLine();
            inputIsValid = false;
            while (!inputIsValid)
            {
                inputIsValid = Int32.TryParse(input, out num1);
                if (!inputIsValid)
                {
                    Console.WriteLine("Input number is not valid");
                    Console.Write("Please enter the first number : ");
                    input = Console.ReadLine();
                }
            }
            num1 = Convert.ToInt32(input);
            Console.Write("Please enter the second number : ");
            input = Console.ReadLine();
            inputIsValid = false;
            while (!inputIsValid || num2 == 0)
            {
                inputIsValid = Int32.TryParse(input, out num2);
                if (!inputIsValid)
                {
                    Console.WriteLine("Input number is not valid");
                    Console.Write("Please enter the second number : ");
                    input = Console.ReadLine();
                }
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide with 0");
                    Console.Write("Please enter the second number : ");
                    input = Console.ReadLine();
                }
            }
            num2 = Convert.ToInt32(input);
            divide = Math.Round((double)num1 / (double)num2, 2);
            Console.WriteLine("Division result of " + num1 + " and " + num2 + " is " + divide);
            General.WaitToExit();
        }

        /*
         * Qn4 : Simple parsing function for arithmetic expression
         */
        public static void ParseArithmetic()
        {
            char[] operators = { '+', '-', '*', '/' };
            string input;
            Console.WriteLine("This is a function to evaluate arithmetic expressions");
            Console.Write("Please enter the expression : ");
            input = Console.ReadLine();
            //Remove all whitespaces
            input = Regex.Replace(input, @"\s+", "");
            //Request input from user until it is valid
            input = RequestValidInput(input);
            Console.WriteLine(input + " is valid");
            General.WaitToExit();
        }

        /*
         * Helper function for Qn4 to parse string input
         */
        private static string RequestValidInput(string input)
        {
            bool isValidInput = false;
            while (!isValidInput)
            {
                isValidInput =
                    //Check for non valid character 
                    !Regex.IsMatch(input, ".*[^0-9+*/-].*") &&
                    //Check for double operators 
                    !Regex.IsMatch(input, ".*[+*/-][+*/-].*") &&
                    //Check operator at the start of string
                    !Regex.IsMatch(input, "^[+*/-]") &&
                    //Check operator at the end of string
                    !Regex.IsMatch(input, "[+*/-]$");

                if (!isValidInput)
                {
                    Console.WriteLine(input + " is not valid");
                    Console.Write("Please enter new expression : ");
                    input = Console.ReadLine();
                    input = Regex.Replace(input, @"\s+", "");
                }

            }
            return input;
        }
    }
}
