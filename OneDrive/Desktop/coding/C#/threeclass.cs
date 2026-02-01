using System;

public class A
{
    public void Show()
    {
        Console.WriteLine(" class A!");
    }
}

public class B
{
    public void Show()
    {
        Console.WriteLine(" class B!");
    }
}

public class C
{
    public void Show()
    {
        Console.WriteLine(" class C!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        A Obj = new A();
        B Obj = new B();
        C Obj = new C();

        Obj.Show();
        Obj.Show();
        Obj.Show();
    }
}