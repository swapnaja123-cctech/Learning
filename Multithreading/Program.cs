using System;
using System.Threading;

namespace Multithreading
{
    internal class Program 
    {
        public static void function1()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("func = 1:"+i);
            }
        }

        public static void function2()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine($"func = 2: {i}");
            }
        }

        public static void function3()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine($"func = 3: {i}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Thread t1 = new Thread(function1);
            Thread t2 = new Thread(function2);
            Thread t3 = new Thread(function3);

            t1.Start();
            //t2.Start();
            //t3.Start();

            // Optionally wait for all threads to finish
            t1.Join();
            //t2.Join();
            //t3.Join();
        }
    }
}
