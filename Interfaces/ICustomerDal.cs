using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
	interface ICustomerDal
	{
		void Add();
		void Delete();
		void Update();
	}
	class SqlServerCustomerDal : ICustomerDal
	{
		public void Add()
		{
			Console.WriteLine("Sql Added");		
		}

		public void Delete()
		{
			Console.WriteLine("Sql Deleted");
		}

		public void Update()
		{
			Console.WriteLine("Sql Updated");
		}
	}
	class OracleCustomerDal : ICustomerDal
	{
		public void Add()
		{
			Console.WriteLine("Oracle Added");
		}

		public void Delete()
		{
			Console.WriteLine("Oracle Deleted");
		}

		public void Update()
		{
			Console.WriteLine("Oracle Updated");
		}
	}
	class MySqlCustomerDal : ICustomerDal
	{
		public void Add()
		{
			Console.WriteLine("MySql Added");
		}

		public void Delete()
		{
			Console.WriteLine("MySql Deleted");
		}

		public void Update()
		{
			Console.WriteLine("MySql Updated");
		}
	}
	class CustomerManager 
	{
		public void Add(ICustomerDal customerDal)
		{
			customerDal.Add();
		}
	}
}
