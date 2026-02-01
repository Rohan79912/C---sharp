using System;

namespace Interface
{
    public interface A
    {
        void Show();
    }
    public class B : A
    {
        public void Show()
        {
            Console.WriteLine("Class B  ");
        }
    }
    class Interface
    {
        static void Main(string [] args)
        {
            B b = new B();
            b.Show();
            Console.ReadKey();
        }
    }
}
