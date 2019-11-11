using System.Collections.Generic;
using CheAutoRemastered.Core.Domain.Models.Common;

namespace CheAutoRemastered.Core.Domain.Models
{
    public class Country : NamedEntity
    {
        IEnumerable <CarManufacturer> CarManufacturers { get; set; }
    }
}
