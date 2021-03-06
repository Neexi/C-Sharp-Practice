﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    class SanfoundryBasic
    {
        public static int One { get; } = 1;

        public static char Char { get; } = 'a';

        /*
         * Check whether input number is an even number
         * Return true if yes, false otherwise
         */
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        /*
         * Swap 2 input numbers
         */
        public static void SwapNumber(ref int num1, ref int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }

        /*
         * Count the sum of digit in a number
         */
        public static int SumDigit(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        /*
         * Avoid using string for this function, as it is much slower
         * This function currently does not check for overflow
         * TODO : Fix it
         */
        public static int Reverse(int num)
        {
            int ret = 0;
            while (num > 0)
            {
                int mod = num % 10;
                ret = ret * 10 + mod;
                num /= 10;
            }
            return ret;
        }

        /*
         * Print a triangle with specific height
         */
        public static void PrintTriangle(int height)
        {
            StringBuilder sb = new StringBuilder();
            //Draw the top first
            AddSpace(sb, height - 1);
            sb.Append("*");
            AddSpace(sb, height - 1);
            sb.Append("\n");
            //Draw the middle part
            for (int i = 1; i < height - 1; i++)
            {
                AddSpace(sb, height - i - 1);
                sb.Append("*");
                AddSpace(sb, (2 * i - 1));
                sb.Append("*");
                AddSpace(sb, height - i - 1);
                sb.Append("\n");
            }
            //Draw bottom
            if (height > 1)
            {
                for (int i = 0; i < height - 1; i++)
                {
                    sb.Append("* ");
                }
                sb.Append("*\n");
            }
            Console.WriteLine(sb.ToString());
        }

        private static void AddSpace(StringBuilder sb, int numSpaces)
        {
            for (int i = 0; i < numSpaces; i++)
            {
                sb.Append(" ");
            }
        }

        /*
         * Count the occurence count of specified number in a list of number
         */
        public static int CountOccurence(List<int> list, int num)
        {
            int count = 0;
            foreach (int i in list)
            {
                if (i == num) count++;
            }
            return count;
        }

        /*
         * Return whether a year is a leap year or not
         */
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        /*
         * Simple simulation for ATM functionality
         */
        public static void AtmSimulation()
        {
            Console.WriteLine("Welcome to kappa ATM Service");
            int balance = 0;
            while (true)
            {
                Console.WriteLine("Enter the following number");
                Console.WriteLine("1 Check Balance");
                Console.WriteLine("2 Withdraw Cash");
                Console.WriteLine("3 Deposit Cash");
                Console.WriteLine("4 Quit");
                int choice = General.ReadNumberFromInput(1)[0];
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Your current balance is " + balance);
                        break;
                    case 2:
                        Console.WriteLine("Please input the amount :");
                        int withdraw = General.ReadNumberFromInput(1)[0];
                        if (balance >= withdraw)
                        {
                            balance -= withdraw;
                            Console.WriteLine("You have withdrawn : " + withdraw + ", your current balance is : " + balance);
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money in your account");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Please input the amount :");
                        int deposit = General.ReadNumberFromInput(1)[0];
                        balance += deposit;
                        Console.WriteLine("You have deposited : " + deposit + ", your current balance is : " + balance);
                        break;
                    case 4:
                        Console.WriteLine("Thank you for coming, we hope to see you again");
                        return;
                    default:
                        Console.WriteLine("Command not recognized");
                        break;
                }
            }
        }

        public static void RollDice()
        {
            Random rnd = new Random();
            while (true)
            {
                Console.Write("You want to roll dice? (y/n) : ");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "y":
                        Console.WriteLine("You have rolled : " + rnd.Next(1, 7));
                        break;
                    default:
                        Console.WriteLine("Thanks for coming!");
                        return;
                }
            }
        }

        /*
         * Simple simulation for Phonebook functionality
         */
        public static void PhonebookSimulation()
        {
            Console.WriteLine("Welcome to kappa Phonebook");
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            PrintPhoneBookCommand();
            while (true)
            {
                Console.Write("Input command : ");
                int res;
                string choice = Console.ReadLine();
                while (!int.TryParse(choice, out res))
                {
                    Console.Write("Please input number only : ");
                    choice = Console.ReadLine();
                }
           
                switch (int.Parse(choice))
                {
                    case 1:
                        if (phonebook.Count == 0)
                        {
                            Console.WriteLine("Phonebook is empty!");
                            break;
                        }
                        foreach (KeyValuePair<string, string> person in phonebook)
                        {
                            Console.WriteLine("Name : " + person.Key + ", Phone number : " + person.Value);
                        }
                        break;
                    case 2:
                        {
                            if (phonebook.Count == 0)
                            {
                                Console.WriteLine("Phonebook is empty!");
                                break;
                            }
                            Console.Write("Please insert the person name : ");
                            string name = Console.ReadLine();
                            if (phonebook.ContainsKey(name))
                            {
                                phonebook.Remove(name);
                                Console.WriteLine(name + " is removed from phonebook");
                            }
                            else
                            {
                                Console.WriteLine(name + " does not exist in phonebook");
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Please insert the person name : ");
                            string name = Console.ReadLine();
                            if (phonebook.ContainsKey(name))
                            {
                                Console.WriteLine(name + " already exists in phonebook");
                                break;
                            }
                            Console.Write("Please insert the phone number : ");
                            //TODO : Add function to validate phone number
                            string phone = Console.ReadLine();
                            phonebook.Add(name, phone);
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Please insert the person name : ");
                            string name = Console.ReadLine();
                            if (phonebook.ContainsKey(name))
                            {
                                Console.WriteLine(name + "'s phone number is : "+phonebook[name]);
                                break;
                            } else
                            {
                                Console.WriteLine(name + " does not exist in phonebook");
                            }
                            break;
                        }
                    case 5:
                        PrintPhoneBookCommand();
                        break;
                    case 6:
                        Console.WriteLine("Thank you for coming, we hope to see you again");
                        phonebook.Clear();
                        return;
                    default:
                        Console.WriteLine("Command not recognized");
                        break;
                }
            }
        }

        /*
         * Print command function
         */ 
        private static void PrintPhoneBookCommand()
        {
            Console.WriteLine("Enter the following number");
            Console.WriteLine("1 List content of phonebook");
            Console.WriteLine("2 Remove person from phonebook");
            Console.WriteLine("3 Add person to phonebook");
            Console.WriteLine("4 Get phone number of a person");
            Console.WriteLine("5 Show command");
            Console.WriteLine("6 Quit");
        }


    }
}
