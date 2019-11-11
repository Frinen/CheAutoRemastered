using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System;

namespace CheAutoRemastered.Domain.Models
{
    public class Role : IdentityRole<Guid>
    {
        public User User { get; set; }
    }
}
