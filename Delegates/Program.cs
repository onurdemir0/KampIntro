﻿using System;

namespace Delegates
{
	public delegate void MyDelegate();
	public delegate void MyDelegate2(string text);
	public delegate int MyDelegate3(int number1, int number2);
	class Program
	{
		static void Main(string[] args)
		{
			CustomerManager customerManager = new CustomerManager();

			MyDelegate myDelegate = customerManager.SendMessage;
			myDelegate += customerManager.ShowAlert;
			myDelegate -= customerManager.SendMessage;

			MyDelegate2 myDelegate2 = customerManager.SendMessage2;
			myDelegate2 += customerManager.ShowAlert2;

			Matematik matematik = new Matematik();
			MyDelegate3 myDelegate3 = matematik.Topla;
			myDelegate3 += matematik.Carp;

			var sonuc = myDelegate3(2, 3);
			Console.WriteLine(sonuc);

			myDelegate();
			myDelegate2("Hi");
		}
	}
	public class CustomerManager
	{
		public void SendMessage()
		{
			Console.WriteLine("Hello!");
		}
		public void ShowAlert()
		{
			Console.WriteLine("Be careful!");
		}
		public void SendMessage2(string message)
		{
			Console.WriteLine(message);
		}
		public void ShowAlert2(string alert)
		{
			Console.WriteLine(alert);
		}
	}
	public class Matematik
	{
		public int Topla(int number1,int number2)
		{
			return number1 + number2;
		}
		public int Carp(int number1, int number2)
		{
			return number1 * number2;
		}
	}
}
