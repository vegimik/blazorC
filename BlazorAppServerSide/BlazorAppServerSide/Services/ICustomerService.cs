using BlazorAppServerSide.Models;

namespace BlazorAppServerSide.Services
{
	public interface ICustomerService
	{
		public string uid { get; set; }
		Customer GetCustomerById(int id);
	}
}
