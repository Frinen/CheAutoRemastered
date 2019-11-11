using CheAutoRemastered.Domain.Models.Common;

namespace CheAutoRemastered.Domain.Models
{
    public class Dealer : NamedEntity
    {
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
