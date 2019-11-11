﻿using System;
using CheAutoRemastered.Domain.Models.Common;

namespace CheAutoRemastered.Domain.Models
{
    public  class UserOrder : Entity
    {
        public User User { get; set; }
        public Guid UserId { get; set; }

        public AvailableCar AvailableCar { get; set; }
        public Guid AvailableCarId { get; set; }

        public int Count { get; set; }
    }
}
