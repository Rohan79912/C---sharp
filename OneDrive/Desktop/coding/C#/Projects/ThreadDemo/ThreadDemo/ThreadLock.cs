using System;
using System.Threading;

namespace ThreadDemo
{
    class ThreadLockDemo
    {
        public void Display()
        {
            lock (this)
            {
                Console.Write("This is C# ");
                Thread.Sleep(3000);
                Console.WriteLine("Lab");
            }
        }
        static void Main(string [] args)
        {
            ThreadLockDemo tld = new ThreadLockDemo();
            Thread T1 = new Thread(tld.Display);
            Thread T2 = new Thread(tld.Display);
            Thread T3 = new Thread(tld.Display);

            T1.Start();
            T2.Start();
            T3.Start();
            Console.ReadKey();
        } 
    }
}
