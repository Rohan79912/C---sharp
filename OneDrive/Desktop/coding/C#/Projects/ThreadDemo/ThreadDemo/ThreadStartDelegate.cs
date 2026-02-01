//thread Start Delegate
using System;
using System.Threading;

namespace ThreadDemo
{
    class ThreadStartDelegate
    {
        public static void Test1()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Test1" + i);
            }
        }
    }
    class StartDelegate
    {
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(ThreadStartDelegate.Test1); 
            Thread t = new Thread(ts);
            t.Start();
            Console.ReadKey();
        }
    }
}
