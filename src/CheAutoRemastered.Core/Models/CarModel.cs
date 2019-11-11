using System;
using CheAutoRemastered.Core.Domain.Models.Common;

namespace CheAutoRemastered.Core.Domain.Models
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
