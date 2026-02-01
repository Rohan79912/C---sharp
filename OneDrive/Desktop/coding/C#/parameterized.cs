using System;
class parameterized
{
	int num;
	public parameterized(int a){
		num = a;
	Console.Write("parameterized Constructor " + a);
	}
	static void Main(string[] args){
		parameterized pc = new parameterized(2);
}
}