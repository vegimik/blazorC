using BlazorAppServerSide.Models;
using System.Collections.Generic;

namespace BlazorAppServerSide.Repositories
{
	public interface ICustomerDataAccess
	{
		IEnumerable<Customer> GetCustomers();
	}
}
