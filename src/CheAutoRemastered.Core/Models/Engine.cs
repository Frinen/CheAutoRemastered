using System.Collections.Generic;
using CheAutoRemastered.Core.Domain.Models.Common;

namespace CheAutoRemastered.Core.Domain.Models
{
    public class Engine : NamedEntity
    {
        public Engine()
        {
            CarComplectations = new List<CarComplectation>();
        }

        public int PistonsCount { get; set; }
        public double Volume { get; set; }
        public double Power { get; set; }
        public double Torque { get; set; }

        IEnumerable<CarComplectation> CarComplectations { get; set; }
    }
}
