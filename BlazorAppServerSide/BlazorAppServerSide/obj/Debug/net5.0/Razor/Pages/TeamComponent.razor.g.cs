#pragma checksum "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\Pages\TeamComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d9c70a4bc0ddd71a1165e9b49c24cb90a3f962c"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/team/{id:int}")]
    public partial class TeamComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>TeamComponent</h3>\r\n");
            __builder.OpenElement(1, "h2");
            __builder.AddContent(2, "The Id is: ");
#nullable restore
#line 4 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\Pages\TeamComponent.razor"
__builder.AddContent(3, Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(5, "ul");
            __builder.AddAttribute(6, "class", "list-group");
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "class", "list-group-item");
            __builder.AddContent(9, "Team Name: ");
#nullable restore
#line 8 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\Pages\TeamComponent.razor"
__builder.AddContent(10, team?.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\t");
            __builder.OpenElement(12, "li");
            __builder.AddAttribute(13, "class", "list-group-item");
            __builder.AddContent(14, "Team Region: ");
#nullable restore
#line 9 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\Pages\TeamComponent.razor"
__builder.AddContent(15, team?.Region);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(17, "ul");
            __builder.AddAttribute(18, "class", "list-group");
#nullable restore
#line 14 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\Pages\TeamComponent.razor"
     foreach (var memberItem in Members)
	{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "li");
            __builder.AddAttribute(20, "class", "list-group-item");
            __builder.AddContent(21, "Member Name: ");
#nullable restore
#line 16 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\Pages\TeamComponent.razor"
__builder.AddContent(22, memberItem?.Name);

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, ", Member Age: ");
#nullable restore
#line 16 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\Pages\TeamComponent.razor"
__builder.AddContent(24, memberItem?.Age);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\Pages\TeamComponent.razor"
	}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Twin\source\repos\BlazorAppServerSide\BlazorAppServerSide\Pages\TeamComponent.razor"
       

	[Parameter]
	public int Id { get; set; }

	private Team team { get; set; }

	private IEnumerable<Member> Members { get; set; }

	protected override void OnInitialized()
	{
		base.OnInitialized();

		var Teams = new List<Team>();
		Teams.Add(new Team { Id = 1, Name = "Red", Region = "Region One" });
		Teams.Add(new Team { Id = 2, Name = "BLue", Region = "Region Two" });
		Teams.Add(new Team { Id = 3, Name = "Yellow", Region = "Region Three" });

		var allMembers = new List<Member>();
		allMembers.Add(new Member { Id = 1, Name = "John", Age = 20, TeamId = 1 });
		allMembers.Add(new Member { Id = 2, Name = "Mike", Age = 25, TeamId = 1 });
		allMembers.Add(new Member { Id = 3, Name = "Joe", Age = 26, TeamId = 2 });
		allMembers.Add(new Member { Id = 4, Name = "Ross", Age = 21, TeamId = 2 });
		allMembers.Add(new Member { Id = 5, Name = "Ruan", Age = 23, TeamId = 3 });
		allMembers.Add(new Member { Id = 6, Name = "Fox", Age = 22, TeamId = 3 });

		team = Teams.FirstOrDefault(x => x.Id == this.Id);
		Members = allMembers.Where(x => x.TeamId == this.Id);

	}





	class Team
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Region { get; set; }

	}

	class Member
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public int TeamId { get; set; }

	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
