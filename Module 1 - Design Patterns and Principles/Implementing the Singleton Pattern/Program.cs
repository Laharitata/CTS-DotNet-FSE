using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get first instance
            Logger logger1 = Logger.GetInstance();
            logger1.Log("First log message.");

            // Get second instance
            Logger logger2 = Logger.GetInstance();
            logger2.Log("Second log message.");

            // Check whether both references point to the same object
            if (logger1 == logger2)
            {
                Console.WriteLine("\nOnly one Logger instance exists.");
            }
            else
            {
                Console.WriteLine("\nMultiple Logger instances exist.");
            }

            Console.WriteLine("\nHash Codes:");
            Console.WriteLine(logger1.GetHashCode());
            Console.WriteLine(logger2.GetHashCode());

            Console.ReadKey();
        }
    }
}
