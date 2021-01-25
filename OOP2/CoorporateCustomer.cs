using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
	//Coorporate
	class CoorporateCustomer:Customer  //Inheritance - Meaning: CorporateCustomer is a Customer
	{
		public string CompanyName { get; set; }
		public string TaxNo { get; set; }
	}
}
