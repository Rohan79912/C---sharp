//Deligate 

using System;

namespace Delegate
{
    public delegate void AddDelegate(int a, int b);

    class A
    {
        public static void Add(int x , int y)
        {
            Console.WriteLine(x+y);
        }
        static void Main(string[] args)
        {
            AddDelegate ad = new AddDelegate(Add);
            ad(4,5);
           

            Console.ReadKey();
        }
    }
}
