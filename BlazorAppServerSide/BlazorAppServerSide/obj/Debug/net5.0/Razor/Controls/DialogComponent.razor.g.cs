#pragma checksum "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\Controls\DialogComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d5336af2345a77354355fdfb9a1e2002e9250e7"
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
#line 1 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using BlazorAppServerSide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using BlazorAppServerSide.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using BlazorAppServerSide.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\_Imports.razor"
using BlazorAppServerSide.BaseComponents;

#line default
#line hidden
#nullable disable
    public partial class DialogComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\Controls\DialogComponent.razor"
 if (display)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal is-active");
            __builder.AddMarkupContent(2, "<div class=\"modal-background\"></div>\r\n\t\t");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "modal-card");
            __builder.OpenElement(5, "header");
            __builder.AddAttribute(6, "class", "modal-card-head");
            __builder.AddMarkupContent(7, "<p class=\"modal-card-title\">Modal title</p>\r\n\t\t\t\t");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "delete");
            __builder.AddAttribute(10, "aria-label", "close");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\Controls\DialogComponent.razor"
                                                                    (()=>{
					this.Close();
					})

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\t\t\t<section class=\"modal-card-body\"></section>\r\n\t\t\t");
            __builder.OpenElement(13, "footer");
            __builder.AddAttribute(14, "class", "modal-card-foot");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "button is-success");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\Controls\DialogComponent.razor"
                                                            Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Save changes");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\t\t\t\t");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "button");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\Controls\DialogComponent.razor"
                                                 ()=>Close()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\Controls\DialogComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\Controls\DialogComponent.razor"
       

	private bool display { get; set; } = false;

	public void Show()
	{
		this.display = true;
		StateHasChanged();
	}
	public void Close()
	{
		this.display = false;
		StateHasChanged();
	}


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
