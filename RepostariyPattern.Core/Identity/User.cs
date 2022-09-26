using Microsoft.AspNetCore.Identity;
using RepostaryPattren.Core.Entities;
using System.Collections.Generic;

namespace RepostaryPattren.Core.Identity
{
    public class User : IdentityUser
    {


        public ICollection<certificate> certificates { get; set; } 
    }
}
