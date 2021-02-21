using System;
using System.Linq;

namespace EntityFrameworkDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			//ADO.NET
			//Entity Framework - ORM - Object relational mapping
			//NHibernate
			//Dapper

			//GetAll();
			GetProductsByCategoryId(1);
		}

		private static void GetAll()
		{
			NorthwindContext northwindContext = new NorthwindContext();

			foreach (var product in northwindContext.Products)
			{
				Console.WriteLine(product.ProductName);
			}
		}
		private static void GetProductsByCategoryId(int categoryId)
		{
			NorthwindContext northwindContext = new NorthwindContext();

			var result = northwindContext.Products.Where(p => p.CategoryId == categoryId);

			foreach (var product in result)
			{
				Console.WriteLine(product.ProductName);
			}
		}
	}
}
