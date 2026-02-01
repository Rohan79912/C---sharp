// rule 3
class SuperClass{
    // public	int a;
	// public SuperClass(){                                         //default constructor 
		// System.Console.WriteLine("Parent Class Constructor");               
	// }
	public SuperClass(int x){                                       ///parameterized constructor
		System.Console.WriteLine("Parent Class Constructor : " + x);               
	}
	public void Test1(){
		System.Console.WriteLine("Parent Class ");
	}
}
class SubClass:SuperClass{
	public SubClass():base(10){
		System.Console.WriteLine("Child Class Constructor");
	}
	public void Test2(){
		System.Console.WriteLine("Child Class");
	}	
}
class MainClass{
	public void Test3(){
		System.Console.WriteLine("Main Class");
	}
	static void Main(string [] args){ 
	     //SuperClass sc;                            // sc is parent class variable 
		SubClass t2 = new SubClass();         // t2 is instance of child class 
		 //sc.Test2();
		// sc = t2;                                 //Initializing parent class variable through child class instance to make reference  
		// sc.Test1();
		// sc.Test2();
		// SubClass t2 = new SubClass();
		// t2.a = 10;
		// MainClass m = new MainClass();
		// m.Test3();
		t2.Test1();
	    t2.Test2();
	}
}

