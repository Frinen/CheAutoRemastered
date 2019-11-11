using System;
using System.Collections.Generic;
using CheAutoRemastered.Domain.Models.Common;

namespace CheAutoRemastered.Domain.Models
{
    public class AvailableCar : Entity
    {
        public AvailableCar()
        {
            UserOrders = new List<UserOrder>();
        }

        public Guid DealerId { get; set; }
        public Dealer Dealer { get; set; }

        public Guid CarModelId { get; set; }
        public CarModel CarModel { get; set; }

        public List<UserOrder> UserOrders { get; private set; } 

        public DateTime AvailableFrom { get; set; }
        public double Discount { get; set; }
        public int Count { get; set; }

    }
}
