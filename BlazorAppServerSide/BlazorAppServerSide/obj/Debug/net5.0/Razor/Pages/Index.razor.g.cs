#pragma checksum "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d68904d82734ebe3f21626df912dcaf36230f059"
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
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
