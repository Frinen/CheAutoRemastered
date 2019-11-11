using System;
using System.Collections.Generic;
using System.Text;

namespace CheAutoRemastered.Domain.Models.Common
{
    public class Entity
    {
        public Guid Id { get; set; }
        public bool Deleted { get; set; }
    }
}
