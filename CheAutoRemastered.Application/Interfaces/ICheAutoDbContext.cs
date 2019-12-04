using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CheAutoRemastered.Domain.Models;

namespace CheAutoRemastered.Application.Interfaces
{
    public interface ICheAutoDbContext
    {
        DbSet<Domain.Models.Engine> Engines { get; set; }
         DbSet<Country> Countries { get; set; }
         DbSet<AvailableCar> AvailableCars { get; set; }
         DbSet<BodyType> BodyTypes { get; set; }
         DbSet<CarComplectation> CaeComplectations { get; set; }
         DbSet<CarManufacturer> CarManufacturers { get; set; }
         DbSet<CarModel> CarModels { get; set; }
         DbSet<Dealer> Dealers { get; set; }
         DbSet<UserOrder> UserOrders { get; set; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
