using System;
using System.IO;

public class Program
{
	public static void Main()
	{
		//Getting triangle input from a file that location
		string[] lines = File.ReadAllLines(@"C:\Users\HP\source\repos\KampIntro\Exercise2\Triangle.txt");

		var array2D = TriangleInto2DArray(lines);

		var max = CalculateMaxPath(lines, array2D);

		Console.WriteLine("The maximum sum of the numbers from top to bottom: {0}", max[0, 0]);


	}
	//Triangle input into 2-dimensional array
	private static int[,] TriangleInto2DArray(string[] lines)
	{
		int[,] array2D = new int[lines.Length, lines.Length + 1];

		for (int row = 0; row < lines.Length; row++)
		{
			var rowChar = lines[row].Trim().Split(' ');

			for (int column = 0; column < rowChar.Length; column++)
			{
				int number;
				int.TryParse(rowChar[column], out number);
				array2D[row, column] = number;
			}
		}
		return array2D;
	}
	//Checking number prime or not
	private static bool IsPrime(int number)
	{

		if (number == 1) return false;
		if (number == 2) return true;

		for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
		{
			if (number % i == 0) return false;
		}

		return true;

	}
	//Replacing prime numbers with zero
	private static int[,] ReplacePrimeNumber(string[] lines, int[,] array2D)
	{
		for (int i = 0; i < lines.Length; i++)
		{
			for (int j = 0; j < lines.Length; j++)
			{
				if (IsPrime(array2D[i, j]))
					array2D[i, j] = 0;
			}
		}
		return array2D;
	}

	private static int[,] CalculateMaxPath(string[] lines, int[,] array2D)
	{
		var alteredArray2D = ReplacePrimeNumber(lines, array2D);

		for (int i = lines.Length - 2; i >= 0; i--)
		{
			for (int j = 0; j < lines.Length; j++)
			{
				var parent = alteredArray2D[i, j];
				var leftNode = alteredArray2D[i + 1, j];
				var rightNode = alteredArray2D[i + 1, j + 1];

				if ((parent > 0 && leftNode > 0) || (parent > 0 && rightNode > 0))
				{
					array2D[i, j] = parent + Math.Max(leftNode, rightNode);
				}
			}
		}
		return array2D;
	}

}