//thread Join Delegate
using System;
using System.Threading;

namespace ThreadDemo
{
    class ThreadDelegate1
    {
        public static void Test1()
        {
            Console.WriteLine("T Thread Start");
            for (int i = 1; i <= 20; i++)
            {
                if (i == 15)
                {
                Console.WriteLine("T Thread is going to Sleep");
                Thread.Sleep(10000);
                Console.WriteLine("T Thread woke up");
                }
                Console.WriteLine("Test1" + i);
            }
            Console.WriteLine("T Thread Terminate");
        }
    }
    class JoinDelegate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Start");
            ThreadStart ts = new ThreadStart(ThreadDelegate1.Test1);
            Thread t = new Thread(ts);
            t.Start();
            t.Join(5000);
            Console.WriteLine("Main Thread Terminate");
            Console.ReadKey();
        }
    }
}
