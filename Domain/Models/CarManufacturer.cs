using System;
using System.Collections.Generic;
using CheAutoRemastered.Domain.Models.Common;

namespace CheAutoRemastered.Domain.Models
{
    public class CarManufacturer : NamedEntity
    {
        public CarManufacturer()
        {
            CarModels = new List<CarModel>();
        }
        public Guid CountryId { get; set; }
        public Country Country { get; set; }

        public IEnumerable<CarModel> CarModels { get; private set; }
    }
}
