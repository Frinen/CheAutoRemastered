using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace CheAutoRemastered.Core.Domain.Models
{
    public class User : IdentityUser<Guid>
    {
        public User()
        {
            UserOrders = new List<UserOrder>();
        }
        public List<UserOrder> UserOrders{ get; private set; }
        public Guid UserOrderId { get; set; }

        public Role Role { get; set; }
        public Guid RoleId { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
