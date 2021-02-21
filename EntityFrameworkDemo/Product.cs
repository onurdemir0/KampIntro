using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
	class Product
	{
		public int ProductId { get; set; } //PK
		public int CategoryId { get; set; } //FK
		public string ProductName { get; set; }
		public string QuantityPerUnit { get; set; }
		public decimal UnitPrice { get; set; }
		public short UnitsInStock { get; set; }
	}
}
