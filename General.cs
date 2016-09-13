using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

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

        //Function from http://www.csharp-examples.net/

        /*
         * Get all flagged methods from an input class
         */
        public static void GetMethodInfos(Type clazz, BindingFlags flag)
        {
            // get all public static methods of input class type
            MethodInfo[] methodInfos = clazz.GetMethods(flag);
            // sort methods by name
            Array.Sort(methodInfos,
                    delegate (MethodInfo methodInfo1, MethodInfo methodInfo2)
                    { return methodInfo1.Name.CompareTo(methodInfo2.Name); });

            // write method names
            foreach (MethodInfo methodInfo in methodInfos)
            {
                Console.WriteLine(methodInfo.Name);
            }
        }

        /*
         * Get all flagged properties from an input class
         */ 
        public static void GetPropertyNames(Type clazz, BindingFlags flag)
        {
            // get all public static properties of input type
            PropertyInfo[] propertyInfos;
            propertyInfos = clazz.GetProperties(flag);
            // sort properties by name
            Array.Sort(propertyInfos,
                    delegate (PropertyInfo propertyInfo1, PropertyInfo propertyInfo2)
                    { return propertyInfo1.Name.CompareTo(propertyInfo2.Name); });

            // write property names
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                Console.WriteLine(propertyInfo.Name);
            }

        }

        /*
         * Get current call stack minus this function itself
         */ 
        public static void GetCallStack()
        {
            StackTrace stackTrace = new StackTrace();           // get call stack
            StackFrame[] stackFrames = stackTrace.GetFrames();  // get method calls (frames)
            stackFrames = stackFrames.Skip(1).ToArray();
            // write call stack method names
            foreach (StackFrame stackFrame in stackFrames)
            {
                Console.WriteLine(stackFrame.GetMethod().Name);   // write method name
            }
        }

    }
}
