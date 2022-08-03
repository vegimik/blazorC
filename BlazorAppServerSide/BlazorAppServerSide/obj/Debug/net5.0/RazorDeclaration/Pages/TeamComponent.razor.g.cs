// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/team/{id:int}")]
    public partial class TeamComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Twin\source\repos\Blazor\BlazorAppServerSide\BlazorAppServerSide\Pages\TeamComponent.razor"
       

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
