#pragma checksum "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\Component.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9137eb84cea8215050847cce4e2467f832538dc1"
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
    public partial class Component : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Component</h3>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\Component.razor"
                              (()=> ClickMe())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Click Me");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n<br>\r\n");
#nullable restore
#line 6 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\Component.razor"
__builder.AddContent(6, BodyTemplate);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "\r\n\r\n<hr>\r\n<br>\r\n");
            __builder.OpenElement(8, "p");
            __builder.AddContent(9, "COunter Value: ");
#nullable restore
#line 10 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\Component.razor"
__builder.AddContent(10, Counter);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\Component.razor"
       

	[Parameter]
	public RenderFragment BodyTemplate { get; set; }

	[Parameter]
	public int Counter { get; set; }


	protected override void OnAfterRender(bool firstRender)
	{
		base.OnAfterRender(firstRender);
		Console.WriteLine($"Child Component - OnAfterRender at {DateTime.Now.ToString("hh:MM:ss.fff")}");
	}

	private void ClickMe()
	{

	}

	public void Refresh()
	{
		//this.StateHasChanged();
	}


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
