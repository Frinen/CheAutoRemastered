using System.Collections.Generic;
using CheAutoRemastered.Domain.Models.Common;

namespace CheAutoRemastered.Domain.Models
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
