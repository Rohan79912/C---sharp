using System;
using System.Threading;

namespace ThreadDemo
{
    class Testing
    {
        public long Count1 = 0, Count2 = 0;
        public void IncrementCount1()
        {
            while (true)
            {
                Count1 += 1;
            }
        }
        public  void IncrementCount2()
        {
            while (true)
            {
                Count2 += 1;
            }
        }
    }
        class ThreadPriorityDemo { 
        static void Main(string[] args) {
            Testing t = new Testing();
            Thread T1 = new Thread(t.IncrementCount1);
            Thread T2 = new Thread(t.IncrementCount2);

            T1.Priority = ThreadPriority.Highest;
            T2.Priority = ThreadPriority.Lowest;

            T1.Start();
            T2.Start();

            Thread.Sleep(1000);

           // Console.WriteLine("Priority of T1 and Value of Count1: "+ T1.Priority +" " + t.Count1);
            //Console.WriteLine("Priority of T2 and Value of Count2: " + T2.Priority + " " + t.Count2);

            T1.Abort();
            T2.Abort();
            T1.Join();
            T2.Join();

            Console.WriteLine("Count1: " + t.Count1);
            Console.WriteLine("Count2: " + t.Count2);
            Console.ReadKey();

        }
    }
}
