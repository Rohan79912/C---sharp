using System;

namespace Abstract
{
    abstract class A
    {
        public abstract void T(); // Abstract method
        public void T1()
        {
            Console.WriteLine("Inside Abstract Class ");
        }
    }
    class B : A
    {
        public override void T()
        {
            Console.WriteLine("Override Abstract Method");
        }
    }
    class MainClass
    {
        static void Main(string [] args)
        {
            B obj = new B();
            obj.T();
            obj.T1();
            Console.ReadKey();
        }
    }
}
