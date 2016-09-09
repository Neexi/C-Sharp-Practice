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
        * Wait for any key from user to close the app/proceed to the function
        */
        public static void WaitToExit()
        {
            Console.WriteLine("Press any key to proceed/exit...");
            Console.Read();
        }
    }
}
