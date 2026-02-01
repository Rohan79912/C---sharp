using System;
namespace Overloading
{
    class A
    {
        public void T1(int a) {
            Console.WriteLine(a);
        }
        public void T1(int a, int b)
        {
            Console.WriteLine(a + b); 
            }
         public void T1()
        {
            Console.WriteLine("Some Message");
        }
    }
    class MainClass { 
    static void Main(string[] args)
    {
        A obj = new A();
        obj.T1();
        obj.T1(5);
        obj.T1(2,3);
        Console.ReadKey();
    }
}
}
