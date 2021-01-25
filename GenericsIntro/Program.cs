using System;

namespace GenericsIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList<string> isimler = new MyList<string>();
			isimler.Add("Engin"); //<bunun içinde> tanımlanan türde veri girilmeli (burada string)
			isimler.Add("Onur"); 

			Console.WriteLine(isimler.Length);
			Console.WriteLine(isimler.Items[0]);
			foreach (var i in isimler.Items)
			{
				Console.WriteLine(i); 
			}
		}
	}
}
