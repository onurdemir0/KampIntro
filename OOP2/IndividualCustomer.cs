using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
	//Individual
	class IndividualCustomer:Customer  //Inheritance - Meaning: IndividualCustomer is a Customer
	{
		public string TcNo { get; set; }
		
		string _firstName;
		public string FirstName 
		{ 
			get { return "Mr." + _firstName; }
			set { _firstName = value; } 
		}
		public string LastName { get; set; }
		
		
	}
}
