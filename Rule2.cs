class SuperClass{
	public SuperClass(){
		System.Console.WriteLine("Parent Class Constructor");               
	}
	public void Test1(){
		System.Console.WriteLine("Parent Class ");
	}
}
class SubClass:SuperClass{
	public void Test2(){
		System.Console.WriteLine("Child Class");
	}	
}
class MainClass{
	public void Test3(){
		System.Console.WriteLine("Main Class");
	}
	static void Main(string [] args){ 
		SuperClass sc = new SuperClass();         // not accessible because superclass has no information about the Subclass 
		 sc.Test2();
		 
		SubClass t2 = new SubClass();
		MainClass m = new MainClass();
		m.Test3();
		t2.Test1();
		t2.Test2();
	}
}

