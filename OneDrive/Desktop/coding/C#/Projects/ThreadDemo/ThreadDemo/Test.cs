using System;
using System.Threading;
using System.Diagnostics;
namespace ThreadDemo
{
    class Test
    {
        static long counter1, counter2;
        public static void Performance1()
        {
            for(int i = 1; i <= 1000000000; i++)
            {
                counter1++;
            }
        }
        public static void Performance2()
        {
            for (int i = 1; i <= 1000000000; i++)
            {
                counter2++;
            }
        }
        static void Main(string [] args)
        {
            Thread T1 = new Thread(Performance1);
            Thread T2 = new Thread(Performance2);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //Performance1();
            //Performance2();
            T1.Start();
            T2.Start();
            sw.Stop();
            Console.WriteLine("Time taken by Method :"+sw.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
