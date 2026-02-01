//Thread delegate Parameterized
using System;
using System.Threading;

namespace ThreadDemo
{
    class ThreadDelegate
    {
        public static void Test1(Object x)
        {
            int n = Convert.ToInt32(x);
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Test1" + i);
            }
        }
    }
    class MainClass
    {
        static void Main(string [] args) {
            ParameterizedThreadStart ts = new ParameterizedThreadStart(ThreadDelegate.Test1);
            ts(20);
            Thread t = new Thread(ts);
            t.Start();
            Console.ReadKey();
        }
    }
}
