using System;

namespace OOP2
{
	class Program
	{
		static void Main(string[] args)
		{
			//SOLID
			// Onur Demir - Individual
			IndividualCustomer customer1 = new IndividualCustomer();
			customer1.Id = 1;
			customer1.CustomerNo = "12121";
			customer1.FirstName = "Onur";
			customer1.LastName = "Demir";
			customer1.TcNo = "125564";

			Console.WriteLine(customer1.FirstName);

			// Kodlama.io - Coorporate
			CoorporateCustomer customer2 = new CoorporateCustomer();
			customer2.Id = 2;
			customer2.CustomerNo = "65656556";
			customer2.CompanyName = "abc";
			customer2.TaxNo = "454654";

			// Customer class can keep both references
			Customer customer3 = new IndividualCustomer();
			Customer customer4 = new CoorporateCustomer();

			CustomerManager customerManager = new CustomerManager();
			customerManager.Add(customer1);
			customerManager.Add(customer2);
		}
	}
}
