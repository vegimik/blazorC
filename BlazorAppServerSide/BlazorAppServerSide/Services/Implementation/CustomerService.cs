using BlazorAppServerSide.Models;
using BlazorAppServerSide.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorAppServerSide.Services.Implementation
{
	public class CustomerService : ICustomerService
	{
		public List<Customer> customers { get; set; }
		ICustomerDataAccess CustomerDataAccess { get; set; }
		public string uid { get; set; }
		public CustomerService()
		{
			uid=Guid.NewGuid().ToString();
			customers = new List<Customer>()
			{
				new Customer() { Id = 1, Name = "Tom"},
				new Customer() { Id = 2, Name = "John"},
				new Customer() { Id = 3, Name = "Jane" }
			};

		}

		public Customer GetCustomerById(int id)
		{
			return customers.FirstOrDefault(x => x.Id == id);
		}
	}
}
