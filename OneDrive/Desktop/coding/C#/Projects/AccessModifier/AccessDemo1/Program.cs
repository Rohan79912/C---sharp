using System;
//Accesing all type of the members inside the same class  

namespace AccessDemo1
{
    public class Program
    {
        private void Test1() {
            Console.WriteLine("Private Method Test1");

        }
        internal void Test2()
        {
            Console.WriteLine("internal Method Test2");
        }
        public void Test3()
        {
            Console.WriteLine("Public Method Test3");
        }
        protected void Test4()
        {
            Console.WriteLine("Protected Method Test4");
        }
        internal protected void Test5()
        {
            Console.WriteLine("Internal protected Method Test5");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test1();
            p.Test2();
            p.Test3();
            p.Test4();
            p.Test5();
            Console.ReadKey();
        }
    }
}
//1. private 
//2. internal
//3. public 
//4. protected 
//5. internal protected 
