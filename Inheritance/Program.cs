using System;

namespace Inheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			Person[] persons = new Person[]
			{
				new Customer{ FirstName="Onur",LastName="Demir"},
				new Student{ FirstName="Uğur",LastName="Demir"},
				new Person{ FirstName="Hülya",LastName="Demir"}
			};
			foreach (var item in persons)
			{
				Console.WriteLine(item.FirstName);
			}
			
		}
	}
	class Person
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
	class Customer:Person
	{
		public string City { get; set; }
	}
	class Student:Person
	{
		public string Department { get; set; }
	}
}
