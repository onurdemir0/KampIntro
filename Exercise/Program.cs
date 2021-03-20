using System;

namespace Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("First number: ");
			int number1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Second number: ");
			int number2 = Convert.ToInt32(Console.ReadLine());

			number1 += number2;
			number2 = number1 - number2;
			number1 -= number2;

			Console.WriteLine("After swapping: First number: {0} / Second number: {1}", number1, number2);
		}
	}
}
