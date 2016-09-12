using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    class General
    {

        /*
         * Read number of integer input from user
         * return list of int
         */ 
        public static List<int> ReadNumberFromInput(int count)
        {
            List<int> ret = new List<int>(count);
            Console.WriteLine("Please input " + count + " numbers");
            for (int i = 0; i < count; i++)
            {
                try
                {
                    Console.Write("Input " + (i + 1) + " : ");
                    ret.Add(int.Parse(Console.ReadLine()));
                }
                catch (FormatException e)
                {
                    //TODO : Something with e
                    Console.WriteLine("Please input number only");
                    i--;
                }
            }
            return ret;
        } 

        /*
        * Wait for any key from user to close the app/proceed to the function
        */
        public static void WaitToExit()
        {
            Console.WriteLine("Press any key to proceed/exit...");
            Console.Read();
        }
    }
}
