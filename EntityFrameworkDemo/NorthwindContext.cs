using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
	class NorthwindContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=DESKTOP-9B6VH46\SQLEXPRESS;Database=Northwind;Trusted_Connection=true");
		}
		public DbSet<Product> Products { get; set; }
	}
}
