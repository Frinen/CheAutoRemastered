using System.Collections.Generic;
using CheAutoRemastered.Domain.Models.Common;

namespace CheAutoRemastered.Domain.Models
{
    public class Country : NamedEntity
    {
        IEnumerable <CarManufacturer> CarManufacturers { get; set; }
    }
}
