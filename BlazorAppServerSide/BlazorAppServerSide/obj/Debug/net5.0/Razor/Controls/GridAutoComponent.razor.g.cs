#pragma checksum "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\GridAutoComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8245e76e0fa71d3e4fe9142de94c6629018049e0"
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
#line 1 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\GridAutoComponent.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
    public partial class GridAutoComponent<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\GridAutoComponent.razor"
 if (memberInfo != null && memberInfo.Length > 0)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 6 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\GridAutoComponent.razor"
                    $"table {this.CssClass}"

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(2, "thead");
            __builder.OpenElement(3, "tr");
#nullable restore
#line 9 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\GridAutoComponent.razor"
                 foreach (var memberInfoItem in memberInfo)
				{
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\GridAutoComponent.razor"
                     if (memberInfoItem.MemberType == MemberTypes.Property &&
							!ColumnsToExcludeCSV.Contains(memberInfoItem.Name, StringComparison.OrdinalIgnoreCase))
					{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "th");
#nullable restore
#line 14 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\GridAutoComponent.razor"
__builder.AddContent(5, memberInfoItem.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\GridAutoComponent.razor"
					}

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\GridAutoComponent.razor"
                     
				}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\t\t");
            __builder.OpenElement(7, "tbody");
#nullable restore
#line 20 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\GridAutoComponent.razor"
             foreach (var item in Items)
			{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "tr");
#nullable restore
#line 23 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\GridAutoComponent.razor"
                     foreach (var memberInfoItem in memberInfo)
					{
						

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\GridAutoComponent.razor"
                         if (memberInfoItem.MemberType == MemberTypes.Property &&
								!ColumnsToExcludeCSV.Contains(memberInfoItem.Name, StringComparison.OrdinalIgnoreCase))
						{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "td");
#nullable restore
#line 28 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\GridAutoComponent.razor"
__builder.AddContent(10, item.GetType().GetProperty(@memberInfoItem.Name).GetValue(item));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\GridAutoComponent.razor"
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\GridAutoComponent.razor"
                         
					}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\GridAutoComponent.razor"
			}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\GridAutoComponent.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\GridAutoComponent.razor"
       

	[Parameter]
	public List<TItem> Items { get; set; }

	[Parameter]
	public string ColumnsToExcludeCSV { get; set; }
	[Parameter]
	public string CssClass { get; set; }

	MemberInfo[] memberInfo;

	protected override void OnParametersSet()
	{
		base.OnParametersSet();

		if (Items != null && Items.Count > 0)
		{
			Type typeOfItem = this.Items[0].GetType();
			memberInfo = typeOfItem.GetMembers();

		}
	}



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
