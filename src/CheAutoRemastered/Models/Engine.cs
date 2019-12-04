using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheAutoRemastered.Presentation.Models
{
    public class Engine
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int PistonsCount { get; set; }
        public double Volume { get; set; }
        public double Power { get; set; }
        public double Torque { get; set; }
    }
}
