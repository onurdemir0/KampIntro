using System;

public class Program
{
	public static void Main()
	{
		var input = GetInput();

		string[] lines = input.Split('\n');

		var array2D = TriangleInto2DArray(lines);

		var max = CalculateMaxPath(lines, array2D);

		Console.WriteLine("The maximum sum of the numbers from top to bottom: {0}", max[0, 0]);

	}
	private static string GetInput()
	{
		const string input = @"		215
                                    193 124
                                    117 237 442
                                    218 935 347 235
                                    320 804 522 417 345
                                    229 601 723 835 133 124
                                    248 202 277 433 207 263 257
                                    359 464 504 528 516 716 871 182
                                    461 441 426 656 863 560 380 171 923
                                    381 348 573 533 447 632 387 176 975 449
                                    223 711 445 645 245 543 931 532 937 541 444
                                    330 131 333 928 377 733 017 778 839 168 197 197
                                    131 171 522 137 217 224 291 413 528 520 227 229 928
                                    223 626 034 683 839 53  627 310 713 999 629 817 410 121
                                    924 622 911 233 325 139 721 218 253 223 107 233 230 124 233";
		return input;
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