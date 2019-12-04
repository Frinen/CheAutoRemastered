using CheAutoRemastered.Application.Interfaces;
using CheAutoRemastered.Domain.Models;
using IdentityServer4.EntityFramework.Options;
using Infrastructure.Identity;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Infrastructure.Persistense
{
    internal class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>, ICheAutoDbContext
    {
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Country> Countries{ get; set; }
        public DbSet<AvailableCar> AvailableCars { get; set; }
        public DbSet<BodyType> BodyTypes { get; set; }
        public DbSet<CarComplectation> CaeComplectations { get; set; }
        public DbSet<CarManufacturer> CarManufacturers { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<UserOrder> UserOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
