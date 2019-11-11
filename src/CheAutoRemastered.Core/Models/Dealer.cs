

using CheAutoRemastered.Core.Domain.Models.Common;

namespace CheAutoRemastered.Core.Domain.Models
{
    public class Dealer : NamedEntity
    {
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
