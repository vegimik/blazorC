#pragma checksum "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d1509d903131161c709b67a1195b3818861b536"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppServerSide.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<BlazorAppServerSide.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n<br>\r\n<br>");
#nullable restore
#line 11 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Index.razor"
 if (authState != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "p");
            __builder.AddMarkupContent(5, "\r\n\t\tName: ");
#nullable restore
#line 14 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Index.razor"
__builder.AddContent(6, authState.User.Identity.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Index.razor"
     foreach (var claimItem in authState.User.Claims)
	{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "p");
#nullable restore
#line 19 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Index.razor"
__builder.AddContent(8, claimItem.Type);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\t\t");
            __builder.OpenElement(10, "p");
#nullable restore
#line 22 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Index.razor"
__builder.AddContent(11, claimItem.Value);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\t\t");
            __builder.OpenElement(13, "p");
#nullable restore
#line 25 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Index.razor"
__builder.AddContent(14, claimItem.Issuer);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\t\t");
            __builder.OpenElement(16, "p");
#nullable restore
#line 28 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Index.razor"
__builder.AddContent(17, claimItem.OriginalIssuer);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Index.razor"

	}

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Index.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Index.razor"
       
	[CascadingParameter]
	public Task<AuthenticationState> _authState { get; set; }

	public AuthenticationState authState { get; set; }

	protected override async Task OnInitializedAsync()
	{
		authState = await _authState;

	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
