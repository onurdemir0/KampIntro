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

			Student student1 = new Student { Id =1, FirstName = "Uğur", LastName = "Demir", Departmant="Technology" };
			personManager.Add(student1);



			CustomerManager customerManager = new CustomerManager();
			customerManager.Add(new OracleCustomerDal());



			ICustomerDal[] customerDals = new ICustomerDal[]
			{
				new SqlServerCustomerDal(),
				new OracleCustomerDal(),
				new MySqlCustomerDal()
			};
			foreach (var item in customerDals)
			{
				item.Add();
			}

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
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public string Address { get; set; }
	}
	class Student : IPerson
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

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
