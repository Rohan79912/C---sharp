using System;
//consuming 

namespace AccessDemo2
{
    class Class3 : AccessDemo1.Program
    {
        static void Main(string[] args)
        {
            //AccessDemo1.Program p = new AccessDemo1.Program();
            Class3 c = new Class3();
            c.Test3();
            c.Test4();
            c.Test5();
            Console.ReadKey();
        }
    }
}
