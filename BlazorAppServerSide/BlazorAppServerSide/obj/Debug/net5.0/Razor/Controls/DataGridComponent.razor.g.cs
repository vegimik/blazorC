#pragma checksum "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87657af5eea2a7c6e919094d23981c3c5ed3d22c"
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
    public partial class DataGridComponent<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>DataGridComponent</h3>\r\n\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table is-fullwidth");
            __builder.OpenElement(3, "thead");
            __builder.OpenElement(4, "tr");
#nullable restore
#line 8 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
             if (Columns == null || Columns.Count <= 0)
			{
				//Create the header with reflection
			}
			else
			{
				//Create the header based on clomun definition
				

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                 foreach (var column in Columns)
				{

					

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                     if (column.Alignment != Alignment.NotSet)
					{
						

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                         switch (column.Alignment)
						{
							case Alignment.Left:

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "th");
            __builder.AddAttribute(6, "class", "align-left");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                                                                 ()=> SortData(column)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 24 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
__builder.AddContent(8, column.Caption);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "\r\n\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(10, "span");
            __builder.AddAttribute(11, "style", "float:right");
            __builder.AddAttribute(12, "class", 
#nullable restore
#line 25 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                                                                       SortClass(column)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
								break;
							case Alignment.Center:

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "th");
            __builder.AddAttribute(14, "class", "align-center");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                                                                   ()=> SortData(column)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 30 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
__builder.AddContent(16, column.Caption);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "\r\n\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(18, "span");
            __builder.AddAttribute(19, "style", "float:right");
            __builder.AddAttribute(20, "class", 
#nullable restore
#line 31 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                                                                       SortClass(column)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
								break;
							case Alignment.Right:

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "th");
            __builder.AddAttribute(22, "class", "align-right");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                                                                  ()=> SortData(column)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 36 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
__builder.AddContent(24, column.Caption);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "\r\n\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(26, "span");
            __builder.AddAttribute(27, "style", "float:right");
            __builder.AddAttribute(28, "class", 
#nullable restore
#line 37 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                                                                       SortClass(column)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
								break;
							default:

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "th");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                                              ()=> SortData(column)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 42 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
__builder.AddContent(31, column.Caption);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "\r\n\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(33, "span");
            __builder.AddAttribute(34, "style", "float:right");
            __builder.AddAttribute(35, "class", 
#nullable restore
#line 43 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                                                                       SortClass(column)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
								break;
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                         
					}
					else
					{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "th");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                                      ()=> SortData(column)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 51 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
__builder.AddContent(38, column.Caption);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(39, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(40, "span");
            __builder.AddAttribute(41, "style", "float:right");
            __builder.AddAttribute(42, "class", 
#nullable restore
#line 52 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                                                               SortClass(column)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
					}

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                     

				}

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                 
			}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\t");
            __builder.OpenElement(44, "tbody");
#nullable restore
#line 61 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
         foreach (var item in Items.Skip(this.Paging.NumberOFItemsToSkip(CurrentPageNumber)).Take(Paging.NumberOfItemsToTake(Items.Count)))
		{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "tr");
#nullable restore
#line 64 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                 foreach (var column in Columns)
				{
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                     if (!string.IsNullOrWhiteSpace(column.Format) && column.DataType != DataType.NotSet)
					{
						string value = string.Empty;
						switch (column.DataType)
						{
							case DataType.Date:
							case DataType.DateTime:
								value = DateTime.Parse(typeof(TItem).GetProperty(column.DataField).GetValue(item).ToString()).ToString(column.Format);
								break;
							case DataType.Boolean:
								value = bool.Parse(typeof(TItem).GetProperty(column.DataField).GetValue(item).ToString()).ToString();
								break;
							case DataType.Currency:
								value = Math.Round(double.Parse(typeof(TItem).GetProperty(column.DataField).GetValue(item).ToString()), 2).ToString("c");
								break;
							default:
								break;

						}

						

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                         if (column.Alignment != Alignment.NotSet)
						{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(46, "td");
            __builder.AddAttribute(47, "align", 
#nullable restore
#line 89 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                                        column.Alignment.ToString().ToLower()

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 89 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
__builder.AddContent(48, value);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 90 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
						}
						else
						{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(49, "td");
#nullable restore
#line 93 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
__builder.AddContent(50, value);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 94 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                         

					}
					else
					{
						

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                         if (column.Alignment != Alignment.NotSet)
						{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(51, "td");
            __builder.AddAttribute(52, "align", 
#nullable restore
#line 102 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                                        column.Alignment.ToString().ToLower()

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 102 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
__builder.AddContent(53, typeof(TItem).GetProperty(column.DataField).GetValue(item));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 103 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
						}
						else
						{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(54, "td");
#nullable restore
#line 106 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
__builder.AddContent(55, typeof(TItem).GetProperty(column.DataField).GetValue(item));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 107 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                                                                                                        
					}

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                     
				}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 112 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"

		}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "level");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "level-left");
            __builder.OpenElement(61, "p");
            __builder.AddContent(62, "Totola items: ");
#nullable restore
#line 119 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
__builder.AddContent(63, Items.Count);

#line default
#line hidden
#nullable disable
            __builder.AddContent(64, ", Page: ");
#nullable restore
#line 119 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
__builder.AddContent(65, CurrentPageNumber);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\t");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "level-right");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "level-item");
#nullable restore
#line 123 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
             if (Paging != null && Paging.Enabled)
			{
				

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                 if (Paging.CustomPager)
				{
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
__builder.AddContent(71, CustomPager);

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                                
				}
				else
				{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(72, "span");
            __builder.AddAttribute(73, "style", "font-size:14px");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 131 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                                                           GoToPrevPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(75, "<b>&lt; Previous</b>");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\t\t\t\t\t");
            __builder.OpenElement(77, "span");
            __builder.AddAttribute(78, "style", "font-size:12px; color:grey");
            __builder.AddMarkupContent(79, "\r\n\t\t\t\t\t\t&nbsp;>&nbsp; Page:\r\n\t\t\t\t\t\t");
#nullable restore
#line 134 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
__builder.AddContent(80, CurrentPageNumber);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(81, "\r\n\t\t\t\t\t\tof\r\n\t\t\t\t\t\t");
#nullable restore
#line 136 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
__builder.AddContent(82, Paging.MaxPageNumber(Items.Count));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n\t\t\t\t\t");
            __builder.OpenElement(84, "span");
            __builder.AddAttribute(85, "style", "font-size:14px");
            __builder.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 138 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                                                           GoToNextPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(87, "<b>&gt; Next</b>");
            __builder.CloseElement();
#nullable restore
#line 139 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
				}

#line default
#line hidden
#nullable disable
#nullable restore
#line 139 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
                 

			}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 146 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
       

	[Parameter]
	public int CurrentPageNumber { get; set; } = 0;

	[Parameter]
	public List<TItem> Items { get; set; }

	[Parameter]
	public List<ColumnDefinition> Columns { get; set; }

	[Parameter]
	public PagingConfig Paging { get; set; }

	[Parameter]
	public RenderFragment CustomPager { get; set; }



	protected override void OnParametersSet()
	{
		base.OnParametersSet();

		SortData();



	}

	public void GoToPrevPage()
	{
		this.CurrentPageNumber = Paging.PrevPageNumber(CurrentPageNumber);
		this.StateHasChanged();
	}
	public void GoToNextPage()
	{
		this.CurrentPageNumber = Paging.NextPageNumber(CurrentPageNumber, Items.Count);
		this.StateHasChanged();
	}

	public int MaxPageNumber { get => Paging.MaxPageNumber(Items.Count); }

	private string SortClass(ColumnDefinition column)
	{
		if (column.SortDirection != SortDirection.NotSet)
		{
			return $"sort {column.SortDirection.ToString().ToLower()}";

		}
		return "no-sort";
	}

	private void SortData(ColumnDefinition sortByColumn = null)
	{
		if (sortByColumn == null)
		{
			sortByColumn = Columns.FirstOrDefault(x => x.SortDirection != SortDirection.NotSet);
			if (sortByColumn == null)
				return;
		}
		

#line default
#line hidden
#nullable disable
#nullable restore
#line 206 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
         foreach (var column in Columns)
		{
			if (column.DataField != sortByColumn.DataField)
				column.SortDirection = SortDirection.NotSet;
		}

#line default
#line hidden
#nullable disable
#nullable restore
#line 210 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Controls\DataGridComponent.razor"
         
		switch (sortByColumn.SortDirection)
		{
			case SortDirection.NotSet:
				sortByColumn.SortDirection = SortDirection.Asc;
				break;
			case SortDirection.Asc:
				sortByColumn.SortDirection = SortDirection.Desc;
				break;
			case SortDirection.Desc:
				sortByColumn.SortDirection = SortDirection.Asc;
				break;
			default:
				sortByColumn.SortDirection = SortDirection.Asc;
				break;
		}
		if (sortByColumn.SortDirection == SortDirection.Asc)
		{
			Items.Sort((a, b) => typeof(TItem).GetProperty(sortByColumn.DataField).GetValue(a).ToString().CompareTo(typeof(TItem).GetProperty(sortByColumn.DataField).GetValue(b).ToString()));
		}
		else
		{
			Items.Sort((a, b) => typeof(TItem).GetProperty(sortByColumn.DataField).GetValue(b).ToString().CompareTo(typeof(TItem).GetProperty(sortByColumn.DataField).GetValue(a).ToString()));
		}
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
