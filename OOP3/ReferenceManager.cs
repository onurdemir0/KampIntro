using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
	class ReferenceManager
	{
		//Method injection
		public void MakeReference(ICreditManager creditManager, List<ILoggerService> loggerServices)
		{
			//references information evaluation
			creditManager.Calculate();
			foreach (var logger in loggerServices)
			{
				logger.Log(); 
			}
		}
		public void CreditPreInfo(List<ICreditManager> credits) //Preliminary Information
		{
			foreach (var credit in credits)
			{
				credit.Calculate();
			}
		}
	}
}
