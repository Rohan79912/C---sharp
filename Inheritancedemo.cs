// Rule 1
class SuperClass{
	public SuperClass(){       //pub
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
		SubClass t2 = new SubClass();
		MainClass m = new MainClass();
		m.Test3();
		t2.Test1();
		t2.Test2();
	}
}

