using System;

namespace OOPReferenceTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person1 = new Person();
			Person person2 = new Person();
			person1.FirstName = "Onur";

			person2 = person1;
			person1.FirstName = "Uğur";
			Console.WriteLine(person2.FirstName);

			Customer customer = new Customer();
			customer.FirstName = "Hülya";
			customer.CreditCardNumber = "13213131";

			Person person3 = customer;
			Console.WriteLine(person3.FirstName);
			Console.WriteLine(((Customer)person3).CreditCardNumber);

			Employee employee = new Employee();
			employee.FirstName = "Ceyda";

			PersonManager personManager = new PersonManager();
			personManager.Add(customer);
			personManager.Add(employee);
		}
	}
	class Person //Base Class
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
	class Customer:Person //Inheritance
	{
		public string CreditCardNumber { get; set; }
	}
	class Employee:Person //Inheritance
	{
		public int EmployeeNumber { get; set; }
	}
	class PersonManager
	{
		public void Add(Person person)
		{
			Console.WriteLine(person.FirstName);
		}
	}
}
