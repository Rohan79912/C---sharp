// copy constructor
using System;
public class Person{
	public string Name{get; set;}
	public int Age{get; set;}
	
	public Person(string name ,int age ){
		Name = name;
		Age = age;
	}
	public Person(Person other){
		Name = other.Name;
		Age = other.Age;
	}
	static void Main(string[] args)
{
    Person p = new Person("Rohan", 20);
    Person q = new Person(p);

    Console.WriteLine("Original Person: " + p.Name + ", " + p.Age);
    Console.WriteLine("Copied Person: " + q.Name + ", " + q.Age);

    Console.ReadLine(); 
}
}
