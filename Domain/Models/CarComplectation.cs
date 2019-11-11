using System;
using System.Collections.Generic;
using System.IO;
using CheAutoRemastered.Domain.Models.Common;

namespace CheAutoRemastered.Domain.Models
{
    public class CarComplectation : NamedEntity
    {
        public CarComplectation()
        {
            CarModels = new List<CarModel>();
        }

        public int Price { get; set; }
        public DriveType DriveType { get; set; }
        public string Interior { get; set; }

        public int PassengerCount { get; set; }
        public double LoadCapacity { get; set; }

        public Engine Engine { get; set; }
        public Guid EngineId { get; set; }

        public IEnumerable<CarModel> CarModels { get; private set; }
    }
}
