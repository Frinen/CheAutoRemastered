using System.Collections.Generic;
using CheAutoRemastered.Core.Domain.Models.Common;

namespace CheAutoRemastered.Core.Domain.Models
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
