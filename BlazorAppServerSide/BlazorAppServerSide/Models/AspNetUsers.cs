using Microsoft.AspNetCore.Identity;

namespace BlazorAppServerSide.Models
{
    public class AspNetUsers : IdentityUser
    {
        public string School { get; set; }

    }
}
