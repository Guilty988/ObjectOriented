using System;
namespace OOP2
{
	public class CustomerManager
	{
		// Business Classes
		public void Add(Customer customer)
		{
			
			if(customer.CustomerId.Equals(1)) {
				Console.WriteLine("Individual customer");
			}
			if (customer.CustomerId.Equals(2)) {
				Console.WriteLine("corporate customer");
			}


		}
	}
}

