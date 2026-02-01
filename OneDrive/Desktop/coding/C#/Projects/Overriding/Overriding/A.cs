//method overriding 
using System;

namespace Overriding
{
    class A
    {
        public void T1(int a)
        {
            Console.WriteLine(a);
        }
        public virtual void T1(int a , int  b) {
            Console.WriteLine(a+b);
        }
        public void T1()
        {
            Console.WriteLine("Some Message");
        }
    }
    class B : A
    {
        public override void T1(int a, int b)
        {
            Console.WriteLine(a*b);
        }
    }    class MainClass 
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.T1(4,5);
            b.T1(222);
            Console.ReadKey();
        }
    }

}
