using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CheAutoRemastered.Core.Domain.Models.Notifications.Models;

namespace CheAutoRemastered.Core.Domain.Models.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(Message message);
    }
}
