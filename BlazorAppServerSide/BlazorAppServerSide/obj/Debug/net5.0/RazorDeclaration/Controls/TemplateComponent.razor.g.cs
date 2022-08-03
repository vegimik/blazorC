// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAppServerSide.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using BlazorAppServerSide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using BlazorAppServerSide.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using BlazorAppServerSide.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using BlazorAppServerSide.BaseComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using BlazorAppServerSide.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using BlazorAppServerSide.Stores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using BlazorAppServerSide.Configuation;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/template")]
    public partial class TemplateComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\TemplateComponent.razor"
       

	public List<Employee> Employees { get; set; } = new List<Employee>();
	public List<Customer> Customers { get; set; } = new List<Customer>();
	private RepeaterComponent<Customer> repeater;

	[Parameter]
	public int Counter { get; set; }

	protected override void OnInitialized()
	{
		base.OnInitialized();

		Customers.AddRange(new Customer[3]{
			new Customer{ Id = 1, CompanyName= "ABC Comapny",       ContactName= "Frank Liu", PhoneNumber= "111-1234" },
			new Customer{ Id = 3, CompanyName= "DEF Comapny",       ContactName= "Thomas Train", PhoneNumber= "222-1234" },
			new Customer{ Id = 3, CompanyName= "GHI Comapny",   ContactName= "John Doe", PhoneNumber= "333-1234" }}
		);

		Employees.AddRange(new Employee[3]{
			new Employee { Id = 1, Name = "John Doe", Title = "Developer", Department = "Dev" },
			new Employee { Id = 3, Name = "Jane Doe", Title = "Developer", Department = "Dev" },
			new Employee { Id = 3, Name = "Jeff Thomas", Title = "Developer", Department = "Dev" }}
		);

	}

	protected override void OnAfterRender(bool firstRender)
	{
		base.OnAfterRender(firstRender);
		Console.WriteLine($"Counter - OnAfterRender at {DateTime.Now.ToString("hh:MM:ss.fff")}");
	}



	private void EditCustomer(Customer customer)
	{
		this.repeater.ItemToEdit = customer;

	}

	private void ClickBody()
	{
		Console.WriteLine($"ClickBody at {DateTime.Now.ToString("hh:MM:ss.fff")}");

	}




	public class Customer
	{
		public int Id { get; set; }
		public string CompanyName { get; set; }
		public string ContactName { get; set; }
		public string PhoneNumber { get; set; }
	}



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
