#pragma checksum "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aea1e5e46ff9bf90f5f34facee970bd40322c34d"
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
#nullable restore
#line 1 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Counter.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-primary");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, "Current count: ");
#nullable restore
#line 12 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Counter.razor"
__builder.AddContent(8, currentCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __Blazor.BlazorAppServerSide.Pages.Counter.TypeInference.CreateCascadingValue_0(__builder, 10, 11, "Counter", 12, 
#nullable restore
#line 14 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Counter.razor"
                                       currentCount

#line default
#line hidden
#nullable disable
            , 13, (__builder2) => {
                __Blazor.BlazorAppServerSide.Pages.Counter.TypeInference.CreateCascadingValue_1(__builder2, 14, 15, "TitileColor", 16, 
#nullable restore
#line 15 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Counter.razor"
                                                "blue"

#line default
#line hidden
#nullable disable
                , 17, 
#nullable restore
#line 15 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Counter.razor"
                                                                  true

#line default
#line hidden
#nullable disable
                , 18, (__builder3) => {
                    __builder3.OpenComponent<BlazorAppServerSide.Controls.Component1>(19);
                    __builder3.CloseComponent();
                }
                );
            }
            );
            __builder.AddMarkupContent(20, "\r\n\r\n<br>\r\n<hr>\r\n");
            __builder.AddMarkupContent(21, "<h3>Child</h3>\r\n");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "button");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Counter.razor"
                                 ()=>{
Child.ShowChild();
}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(25, "\r\n\tShow Child Component\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.OpenComponent<BlazorAppServerSide.Controls.ChildComponent>(27);
            __builder.AddComponentReferenceCapture(28, (__value) => {
#nullable restore
#line 28 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Counter.razor"
                      Child = (BlazorAppServerSide.Controls.ChildComponent)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\r\n<br>\r\n<br>\r\n\r\n");
            __builder.AddMarkupContent(30, "<p>Dialog Component</p>\r\n");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "button");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Counter.razor"
                                 ()=>{
dialog.Show();
}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(34, "\r\n\tShow Dialog Component\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.OpenComponent<BlazorAppServerSide.Controls.DialogComponent>(36);
            __builder.AddComponentReferenceCapture(37, (__value) => {
#nullable restore
#line 38 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Counter.razor"
                       dialog = (BlazorAppServerSide.Controls.DialogComponent)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n\r\n<br>\r\n");
            __builder.OpenComponent<BlazorAppServerSide.Controls.Component>(39);
            __builder.AddAttribute(40, "Counter", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Counter.razor"
                    currentCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "BodyTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(42, "button");
                __builder2.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Counter.razor"
                          (ClickBody)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(44, "Click in BodyTemplate");
                __builder2.CloseElement();
            }
            ));
            __builder.AddComponentReferenceCapture(45, (__value) => {
#nullable restore
#line 41 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Counter.razor"
                                        component = (BlazorAppServerSide.Controls.Component)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\Counter.razor"
       

	public ChildComponent Child { get; set; }
	public DialogComponent dialog { get; set; }
	public Component component { get; set; }

	[Parameter]
	public EventCallback<int> SetCurrentCount { get; set; }

	[Parameter]
	public Action<int> SetCount { get; set; }

	private int currentCount = 0;
	public Timer timer { get; set; }

	private void IncrementCount()
	{
		currentCount++;
		//SetCurrentCount.InvokeAsync(currentCount);
		SetCount.Invoke(currentCount);
		component.Counter = currentCount;
		//component.Refresh();

	}

	protected override void OnInitialized()
	{
		base.OnInitialized();

		this.timer = new Timer(2000);
		timer.Elapsed += OnTimedEvent;
		timer.Enabled = true;
	}

	public void OnTimedEvent(object source, ElapsedEventArgs e)
	{
		this.IncrementCount();
		Console.WriteLine($"Counter value: {this.currentCount}");


	}

	protected override void OnAfterRender(bool firstRender)
	{
		base.OnAfterRender(firstRender);
		Console.WriteLine($"Counter - OnAfterRender at {DateTime.Now.ToString("hh:MM:ss.fff")}");
	}

	private void ClickBody()
	{

	}








#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorAppServerSide.Pages.Counter
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateCascadingValue_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "IsFixed", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
