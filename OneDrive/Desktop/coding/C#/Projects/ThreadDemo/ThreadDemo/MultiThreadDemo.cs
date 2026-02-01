using System;
using System.Threading;

namespace ThreadDemo
{
    class MultiThreadDemo
    {
        public static void Test1()
        {
            Console.WriteLine("T1 threaded Started");
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine("Test1 " + i);
            }
            Console.WriteLine("T1 Threaded Ended ");
        }
        public static void Test2()
        {
            Console.WriteLine("T2 threaded Started");
            for (int i = 1; i <= 30; i++)
            {
                if (i == 15)
                {
                    Console.WriteLine("Test2 is going to Sleep");
                    Thread.Sleep(1000);
                    Console.WriteLine("Test 2 is woke up");
                }
                Console.WriteLine("Test2 " + i);
            }
            Console.WriteLine("T2 threaded Ended");
        }
        public static void Test3()
        {
            Console.WriteLine("T3 threaded Started");
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine("Test3 " + i);
            }
            Console.WriteLine("T3 Threaded Ended ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Threaded Started ");
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);

            t1.Start();
            t2.Start();
            t3.Start();
            

            Console.WriteLine("Main Threaded Ended ");
            Console.ReadKey();
        }
    }
}
