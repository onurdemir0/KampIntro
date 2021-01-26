using System;

namespace InterfacesDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			//SOLID - Interface Segregation
			IWorker[] workers = new IWorker[]
			{
				new Manager(),
				new Worker(),
				new Robot()
			};
			foreach (var item in workers)
			{
				item.Work();
			}

			IEat[] eats = new IEat[]
			{
				new Manager(),
				new Worker()
			};
			foreach (var item in eats)
			{
				item.Eat();
			}
		}
	}

	interface IWorker
	{
		void Work();
	}
	interface IEat
	{
		void Eat();
	}
	interface ISalary
	{
		void GetSalary();
	}
	class Manager : IWorker, IEat, ISalary
	{
		public void Eat()
		{
			throw new NotImplementedException();
		}

		public void GetSalary()
		{
			throw new NotImplementedException();
		}

		public void Work()
		{
			throw new NotImplementedException();
		}
	}
	class Worker : IWorker, IEat, ISalary
	{
		public void Eat()
		{
			throw new NotImplementedException();
		}

		public void GetSalary()
		{
			throw new NotImplementedException();
		}

		public void Work()
		{
			throw new NotImplementedException();
		}
	}
	class Robot : IWorker
	{
		public void Work()
		{
			throw new NotImplementedException();
		}
	}
}
