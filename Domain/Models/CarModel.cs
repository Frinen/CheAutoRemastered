using System;
using CheAutoRemastered.Domain.Models.Common;

namespace CheAutoRemastered.Domain.Models
{
    public class CarModel : NamedEntity
    {
        public CarManufacturer CarManufacturer { get; set; }
        public Guid CarManufacturerId { get; set; }

        public BodyType BodyType { get; set; }
        public Guid BodyTypeId { get; set; }
        
        public CarComplectation CarComplectation { get; set; }
        public Guid CarComplectationId { get; set; }


    }
}
