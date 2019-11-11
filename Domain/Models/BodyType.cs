using System.Collections.Generic;
using CheAutoRemastered.Domain.Models.Common;

namespace CheAutoRemastered.Domain.Models
{
    public class BodyType : NamedEntity
    {
        public BodyType()
        {
            CarModels = new List<CarModel>();
        }
        public IEnumerable<CarModel> CarModels { get; private set; }
    }
}
