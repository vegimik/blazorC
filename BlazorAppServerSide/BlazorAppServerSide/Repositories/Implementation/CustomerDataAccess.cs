using BlazorAppServerSide.Models;
using System.Collections.Generic;

namespace BlazorAppServerSide.Repositories.Implementation
{
	public class CustomerDataAccess : ICustomerDataAccess
	{
		IEnumerable<Customer> ICustomerDataAccess.GetCustomers()
		{
			throw new System.NotImplementedException();
		}
	}
}
