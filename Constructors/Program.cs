﻿using System;

namespace Constructors
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Bişey yaz: ");
			string name2 = Console.ReadLine();

			

			Customer customer1 = new Customer { Id = 1, FirstName = "Onur", LastName = "Demir", City = "İstanbu" };
			Customer customer2 = new Customer(2,"Uğur","Demir","İstanbul");

			Console.WriteLine(customer2.FirstName);
		}
	}
	class Customer
	{
		//Default Constructor
		public Customer() 
		{

		}
		//Constructor
		public Customer(int id,string firstName,string lastname,string city) 
		{
			Id = id;
			FirstName = firstName;
			LastName = lastname;
			City = city;
		}
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string City { get; set; }
	}
}
