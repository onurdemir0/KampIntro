using System;
using System.Collections.Generic;

namespace OOP3
{
	class Program
	{
		static void Main(string[] args)
		{
			ICreditManager personalFinanceCredit = new PersonalFinanceCreditManager();
			ICreditManager vehicleCreditManager = new VehicleCreditManager();
			ICreditManager housingCreditManager = new HousingCreditManager();

			ILoggerService databaseLoggerService = new DatabaseLoggerService();
			ILoggerService fileLoggerService = new FileLoggerService();

			List<ILoggerService> loggers = new List<ILoggerService>() { databaseLoggerService, fileLoggerService, new SmsLoggerService() };

			ReferenceManager referenceManager = new ReferenceManager();
			referenceManager.MakeReference(new ArtisanCreditManager(), loggers);
				

			List<ICreditManager> credits = new List<ICreditManager>() { vehicleCreditManager, personalFinanceCredit };
			//referenceManager.CreditPreInfo(credits);
			 
		}
	}
}
