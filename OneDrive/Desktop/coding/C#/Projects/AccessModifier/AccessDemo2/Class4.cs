using System;
//consuming all the member of class from non child class which from different 

namespace AccessDemo2
{
    class Class4
    {
        static void Main() {
            AccessDemo1.Program p = new AccessDemo1.Program();
            p.Test3();
            Console.ReadKey();
        }
    }
}
