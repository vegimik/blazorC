#pragma checksum "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\TemplateComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a575b5ffcdb0ff2fdf3af424dc133c78ce0fb5cb"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>TemplateComponent</h3>\r\n<br>\r\n");
            __builder.AddMarkupContent(1, "<p> 1. RenderFragment</p>\r\n");
            __builder.OpenComponent<BlazorAppServerSide.Controls.FieldComponent>(2);
            __builder.AddAttribute(3, "Label", "Name");
            __builder.AddAttribute(4, "Control", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "<input class=\"input\" type=\"email\" placeholder=\"Recipient email\">");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenComponent<BlazorAppServerSide.Controls.FieldComponent>(7);
            __builder.AddAttribute(8, "Label", "Title");
            __builder.AddAttribute(9, "Control", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "<input class=\"input\" type=\"email\" placeholder=\"Recipient email\">");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenComponent<BlazorAppServerSide.Controls.FieldComponent>(12);
            __builder.AddAttribute(13, "Label", "Department");
            __builder.AddAttribute(14, "Control", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(15, "<input class=\"input\" type=\"email\" placeholder=\"Recipient email\">");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n\r\n<hr>\r\n<br>\r\n");
            __builder.AddMarkupContent(17, "<p>2. Generic Type Items List</p>\r\n");
            __Blazor.BlazorAppServerSide.Controls.TemplateComponent.TypeInference.CreateGridAutoComponent_0(__builder, 18, 19, 
#nullable restore
#line 18 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\TemplateComponent.razor"
                           Employees

#line default
#line hidden
#nullable disable
            , 20, "is-striped is-hoverable", 21, "Id, Department");
            __builder.AddMarkupContent(22, "\r\n<hr>\r\n<br>\r\n");
            __builder.AddMarkupContent(23, "<p>3. Repeater Component with Type Items List</p>\r\n");
            __builder.AddMarkupContent(24, "<p>4. Gnereic Typed Render Component as a Form</p>\r\n");
            __Blazor.BlazorAppServerSide.Controls.TemplateComponent.TypeInference.CreateRepeaterComponent_1(__builder, 25, 26, 
#nullable restore
#line 27 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\TemplateComponent.razor"
                          Customers

#line default
#line hidden
#nullable disable
            , 27, (__builder2) => {
                __builder2.AddMarkupContent(28, "<h2> Customer</h2>");
            }
            , 29, (customer) => (__builder2) => {
                __builder2.OpenElement(30, "div");
                __builder2.OpenElement(31, "b");
#nullable restore
#line 33 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\TemplateComponent.razor"
__builder2.AddContent(32, customer.CompanyName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n\t\t\t&nbsp;\r\n\t\t\t");
                __builder2.OpenElement(34, "button");
                __builder2.AddAttribute(35, "class", "btn");
                __builder2.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\TemplateComponent.razor"
                                            ()=>{
EditCustomer(customer);
}

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(37, "\r\n\t\t\t\tEdit\r\n\t\t\t");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n\t\t");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "ml-5");
#nullable restore
#line 41 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\TemplateComponent.razor"
__builder2.AddContent(41, customer.ContactName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\t\t");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "ml-5");
#nullable restore
#line 42 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\TemplateComponent.razor"
__builder2.AddContent(45, customer.PhoneNumber);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            , 46, (currentCustomer) => (__builder2) => {
                __builder2.OpenElement(47, "div");
                __builder2.AddMarkupContent(48, "<text>Company Name: </text>");
                __builder2.OpenElement(49, "input");
                __builder2.AddAttribute(50, "type", "text");
                __builder2.AddAttribute(51, "class", "form-control");
                __builder2.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\TemplateComponent.razor"
                                                                                            currentCustomer.CompanyName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => currentCustomer.CompanyName = __value, currentCustomer.CompanyName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n\t\t");
                __builder2.OpenElement(55, "div");
                __builder2.AddMarkupContent(56, "<text>Contact Name: </text>");
                __builder2.OpenElement(57, "input");
                __builder2.AddAttribute(58, "type", "text");
                __builder2.AddAttribute(59, "class", "form-control");
                __builder2.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\TemplateComponent.razor"
                                                                                            currentCustomer.ContactName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => currentCustomer.ContactName = __value, currentCustomer.ContactName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n\t\t");
                __builder2.OpenElement(63, "div");
                __builder2.AddMarkupContent(64, "<text>Phone Number: </text>");
                __builder2.OpenElement(65, "input");
                __builder2.AddAttribute(66, "type", "text");
                __builder2.AddAttribute(67, "class", "form-control");
                __builder2.AddAttribute(68, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\TemplateComponent.razor"
                                                                                            currentCustomer.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => currentCustomer.PhoneNumber = __value, currentCustomer.PhoneNumber));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            , 70, (__value) => {
#nullable restore
#line 26 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\TemplateComponent.razor"
                         repeater = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(71, "\r\n<hr>\r\n<br>\r\n");
            __builder.AddMarkupContent(72, "<p>5. Lifecycle events - Whren is Rendering Triggered</p>\r\n");
            __builder.OpenComponent<BlazorAppServerSide.Controls.Component>(73);
            __builder.AddAttribute(74, "BodyTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(75, "button");
                __builder2.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\TemplateComponent.razor"
                          (ClickBody)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(77, "Click in BodyTemplate");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(78, "\r\n<br>\r\n");
            __builder.OpenElement(79, "p");
            __builder.AddContent(80, "Counter Value: ");
#nullable restore
#line 66 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\TemplateComponent.razor"
__builder.AddContent(81, Counter);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
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
namespace __Blazor.BlazorAppServerSide.Controls.TemplateComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGridAutoComponent_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2)
        {
        __builder.OpenComponent<global::BlazorAppServerSide.Controls.GridAutoComponent<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "CssClass", __arg1);
        __builder.AddAttribute(__seq2, "ColumnsToExcludeCSV", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateRepeaterComponent_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg3, int __seq4, global::System.Action<global::BlazorAppServerSide.Controls.RepeaterComponent<TItem>> __arg4)
        {
        __builder.OpenComponent<global::BlazorAppServerSide.Controls.RepeaterComponent<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Header", __arg1);
        __builder.AddAttribute(__seq2, "Row", __arg2);
        __builder.AddAttribute(__seq3, "EditTemplate", __arg3);
        __builder.AddComponentReferenceCapture(__seq4, (__value) => { __arg4((global::BlazorAppServerSide.Controls.RepeaterComponent<TItem>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
