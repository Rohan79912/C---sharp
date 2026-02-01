using System;

namespace First
{
    class Matrix1
    {
        int a; int b; int c; int d;

        public override string ToString()
        {
            return a + "\t" + b + "\n" + c + "\t" + d;
        }
        public Matrix1(int x, int y, int z, int w)
        {
            a = x; b = y; c = z; d = w;
        }
        public static Matrix1 operator +(Matrix1 o1, Matrix1 o2)
        {
            Matrix1 sum = new Matrix1(o1.a + o2.a, o1.b + o2.b, o1.c + o2.c, o1.d + o2.d);
            return sum;
        }
        public static Matrix1 operator -(Matrix1 o1, Matrix1 o2)
        {
            Matrix1 sub = new Matrix1(o1.a - o2.a, o1.b - o2.b, o1.c - o2.c, o1.d - o2.d);
            return sub;
        }

        static void Main(string[] args)
        {
            Matrix1 m1 = new Matrix1(1, 2, 3, 4);
            Matrix1 m2 = new Matrix1(5, 6, 7, 8);
            Matrix1 m3 = m1 + m2;
            Matrix1 m4 = m1 - m2;
            Console.WriteLine("Matrix1 \n" + m1);
            Console.WriteLine("Matrix2 \n" + m2);
            Console.WriteLine("Matrix3 \n" + m3);
            Console.WriteLine("Matrix4 \n" + m4);
            Console.ReadKey();
        }
    }
}
