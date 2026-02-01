using System;

namespace Error
{
    class ExceptionDemo
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Starting of program");
            try
            {
                Console.Write("Enter the first number");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nEnter the second number");
                int b = Convert.ToInt32(Console.ReadLine());
                int res = a / b;
                Console.Write("\nResult :"+res);
            }
            catch (OverflowException ow)
            {
                Console.WriteLine("Input only four digit ");
            }
            catch (FormatException ft)
            {
                Console.WriteLine("Enter only Number ");
            }
            catch (DivideByZeroException dz)
            {
                Console.WriteLine("It is universal rule that a number can't divide by zero ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("\nEnding of Program");
            Console.ReadKey();
        }
    }
}
