#pragma checksum "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\FormValidationsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9421a38270e96daaa192e02f8d7a694aad0764de"
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
#nullable restore
#line 3 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\FormValidationsComponent.razor"
using BlazorAppServerSide.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/forms")]
    public partial class FormValidationsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>FormValidationsComponent</h3>\r\n<br>\r\n");
            __builder.AddMarkupContent(1, "<h2>Form method 1</h2>\r\n");
            __builder.AddMarkupContent(2, @"<form method=""post"" action=""/backend_page""><input type=""text"" id=""fname"" value=""John"">
	<br>
	<input type=""text"" id=""lname"" value=""Doe"">
	<br>
	<input type=""text"" id=""emp_number"" value>
	<br>
	<input type=""text"" id=""email"" value>
	<br>

	<input type=""submit"" value=""Submit""></form>

<br>
<br>
");
            __builder.AddMarkupContent(3, "<h2>Form method 2</h2>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 24 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\FormValidationsComponent.razor"
                 person

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 24 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\FormValidationsComponent.razor"
                                        ValidFormSubitted

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\t");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n\t<br>\r\n\t");
                __builder2.OpenElement(12, "label");
                __builder2.AddMarkupContent(13, "\r\n\t\tFirst Name: <br>\r\n\t\t");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "id", "fname");
                __builder2.AddAttribute(16, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\FormValidationsComponent.razor"
                                           person.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => person.FirstName = __value, person.FirstName))));
                __builder2.AddAttribute(18, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => person.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n\t<br>\r\n\t<br>\r\n\t");
                __builder2.OpenElement(20, "label");
                __builder2.AddMarkupContent(21, "\r\n\t\tLast Name: <br>\r\n\t\t");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "id", "lname");
                __builder2.AddAttribute(24, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\FormValidationsComponent.razor"
                                           person.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => person.LastName = __value, person.LastName))));
                __builder2.AddAttribute(26, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => person.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n\t<br>\r\n\t");
                __builder2.OpenElement(28, "label");
                __builder2.AddMarkupContent(29, "\r\n\t\tEmployee Number: <br>\r\n\t\t");
                __Blazor.BlazorAppServerSide.Pages.FormValidationsComponent.TypeInference.CreateInputNumber_0(__builder2, 30, 31, "emp_number", 32, 
#nullable restore
#line 41 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\FormValidationsComponent.razor"
                                                  person.EmployeeNumber

#line default
#line hidden
#nullable disable
                , 33, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => person.EmployeeNumber = __value, person.EmployeeNumber)), 34, () => person.EmployeeNumber);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n\t<br>\r\n\t");
                __builder2.OpenElement(36, "label");
                __builder2.AddMarkupContent(37, "\r\n\t\tEmail: <br>\r\n\t\t");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(38);
                __builder2.AddAttribute(39, "id", "email");
                __builder2.AddAttribute(40, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\FormValidationsComponent.razor"
                                           person.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => person.Email = __value, person.Email))));
                __builder2.AddAttribute(42, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => person.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n\t<br>\r\n\r\n\t<input type=\"submit\" value=\"Submit\">\r\n\t");
                __builder2.AddMarkupContent(44, "<button type=\"button\" class=\"btn btn-primary\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\FormValidationsComponent.razor"
       

	Person person = new Person();

	private void ValidFormSubitted()
	{

	}



#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorAppServerSide.Pages.FormValidationsComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591