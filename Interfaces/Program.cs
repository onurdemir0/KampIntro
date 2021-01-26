using System;

namespace Interfaces
{
	class Program
	{
		static void Main(string[] args)
		{
			PersonManager personManager = new PersonManager();

			Customer customer1 = new Customer { Id=1,FirstName="Onur",LastName="Demir",Address="İstanbul"};
			personManager.Add(customer1);

			Student student1 = new Student { Id =, FirstName = "Uğur", LastName = "Demir", Departmant="Technology" };
			personManager.Add(student1); 

		}
	}
	interface IPerson 
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
	class Customer : IPerson
	{
		public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public string Address { get; set; }
	}
	class Student : IPerson
	{
		public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public string Departmant { get; set; }
	}
	class PersonManager
	{
		public void Add(IPerson person)
		{
			Console.WriteLine(person.FirstName);
		}
	}
}
