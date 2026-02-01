using System;
class Consoverloading
{
	int num;
	 Consoverloading(){
	Console.Write(" default Constructor ");
	}
	 public Consoverloading(int a){
		num = a;
	 Console.Write(" overloading Result " +a);
	 }
	
	static void Main(string[] args){
		Consoverloading pc = new Consoverloading(2);
}
}