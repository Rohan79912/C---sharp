using System;

namespace Error
{
    class DivideByOddException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "can't divide by even number";
            }
        }
    }
    class CustomException

    {
        static void Main(String[] args)
        {
            Console.WriteLine("Starting of program");
            
                Console.Write("Enter the first number");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nEnter the second number");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b % 2 == 0)
                {
                    throw new DivideByOddException();
                }
                int res = a / b;
                Console.Write("\nResult :" + res);
            
           
            Console.WriteLine("\nEnding of Program");
            Console.ReadKey();
        }
    }
}
