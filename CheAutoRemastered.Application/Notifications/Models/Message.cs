﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CheAutoRemastered.Core.Domain.Models.Notifications.Models
{
    public class Message
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
