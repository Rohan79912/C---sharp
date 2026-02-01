using System;

using System.Threading;

namespace ThreadDemo
{
    class SingleThread
    {
        public static void Test1()
        {
            for(int i = 1; i <= 30; i++)
            {
                Console.WriteLine("Test1 " + i);
            }
        }
        public static void Test2()
        {
            for (int i = 1; i <= 30; i++)
            {
                if (i == 15)
                {
                    Console.WriteLine("Test2 is going to Sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Test 2 is woke up");
                }
                Console.WriteLine("Test2 " + i);
            }
        }
        public static void Test3()
        {
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine("Test3 " + i);
            }
        }
        static void Main(string [] args) {
            Test1();
            Test2();
            Test3();
            Console.ReadKey();
        }
    }
}
